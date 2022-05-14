using System;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XOGame {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            b_OFF();
            b_X.Enabled = false;
            b_O.Enabled = false;

        }
        public Form2 form2 = new Form2();
        StringBuilder dataServer;//Serv
        string XorO = "";
        public static string ECHO = "";

        string message = "";//client
        StringBuilder answer;//client

        private async void Client() {
            await Task.Run(() => {
                if (textBox3.Text != "" || textBox4.Text != "") {
                    var TcpEndPoint = new IPEndPoint(IPAddress.Parse(textBox3.Text), Convert.ToInt32(textBox4.Text));
                    var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                    var data = Encoding.UTF8.GetBytes(message);
                    try {
                        tcpSocket.Connect(TcpEndPoint);
                        tcpSocket.Send(data);

                        while (true) {
                            var buffer = new byte[256];
                            var size = 0;
                            answer = new StringBuilder();
                            do {
                                size = tcpSocket.Receive(buffer);
                                answer.Append(Encoding.UTF8.GetString(buffer, 0, size));
                            }
                            while (tcpSocket.Available > 0);
                            //ECHO = answer.ToString();                  
                            tcpSocket.Shutdown(SocketShutdown.Both);
                            tcpSocket.Close();
                        }
                    } catch (Exception) {
                        return;
                    }
                }
            });
        }
        private async void Server() {
            try {
                await Task.Run(() => {
                    if (textBox1.Text != "" || textBox2.Text != "") {
                        var TcpEndPoint = new IPEndPoint(IPAddress.Parse(textBox1.Text), Convert.ToInt32(textBox2.Text));
                        var tcpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                        tcpSocket.Bind(TcpEndPoint);
                        tcpSocket.Listen(5);
                        while (true) {
                            var listner = tcpSocket.Accept();
                            var buffer = new byte[256];
                            var size = 0;
                            dataServer = new StringBuilder();
                            do {
                                size = listner.Receive(buffer);
                                dataServer.Append(Encoding.UTF8.GetString(buffer, 0, size));
                            }
                            while (listner.Available > 0);
                            b_Check();

                            listner.Send(Encoding.UTF8.GetBytes("Sucsess"));
                            listner.Shutdown(SocketShutdown.Both);
                            listner.Close();
                        }
                    } else { MessageBox.Show("Input value"); }
                });
            } catch (Exception) {
                //return; 
            }
        }

        public void Renew() {
            b_OFF();
            b_X.Enabled = false;
            b_O.Enabled = false;
            form2.ShowDialog();
            if (ECHO == "YES") {
                XorO = "";
                b_X.Enabled = true;
                b_O.Enabled = true;
                b_X.BackColor = b_O.BackColor = b1.BackColor = b2.BackColor = b3.BackColor = b4.BackColor = b5.BackColor = b6.BackColor = b7.BackColor = b8.BackColor = b9.BackColor = Color.Gainsboro;
                b1.Text = b2.Text = b3.Text = b4.Text = b5.Text = b6.Text = b7.Text = b8.Text = b9.Text = "";
                WINNER.Text = "";
            }
            if (ECHO == "NO") { message = "OUT"; Client(); Thread.Sleep(500); Close(); }
        }

        void WINNERCheck() {
            if (b1.Text != "") {
                b1.Enabled = false;
                if (b1.Text == b2.Text && b1.Text == b3.Text) {
                    WINNER.Text = "WINNER123: " + b1.Text; form2.label2.Text = WINNER.Text; Renew();
                }
            }
            if (b2.Text != "") {
                b2.Enabled = false;
                if (b2.Text == b5.Text && b2.Text == b8.Text) {
                    WINNER.Text = ("WINNER258: " + b2.Text); form2.label2.Text = WINNER.Text; Renew();
                }
            }
            if (b3.Text != "") {
                b3.Enabled = false;
                if (b3.Text == b5.Text && b3.Text == b7.Text) {
                    WINNER.Text = ("WINNER357: " + b3.Text); form2.label2.Text = WINNER.Text; Renew();
                }
            }
            if (b4.Text != "") {
                b4.Enabled = false;
                if (b4.Text == b5.Text && b4.Text == b6.Text) {
                    WINNER.Text = ("WINNER456: " + b4.Text); form2.label2.Text = WINNER.Text; Renew();
                }
            }
            if (b5.Text != "") {
                b5.Enabled = false;
                if (b5.Text == b1.Text && b5.Text == b9.Text) {
                    WINNER.Text = ("WINNER: " + b5.Text); form2.label2.Text = WINNER.Text; Renew();
                }
            }
            if (b6.Text != "") {
                b6.Enabled = false;
                if (b6.Text == b3.Text && b6.Text == b9.Text) {
                    WINNER.Text = ("WINNER: " + b6.Text); form2.label2.Text = WINNER.Text; Renew();
                }
            }
            if (b7.Text != "") {
                b7.Enabled = false;
                if (b7.Text == b4.Text && b7.Text == b1.Text) {
                    WINNER.Text = ("WINNER: " + b7.Text); form2.label2.Text = WINNER.Text; Renew();
                }
            }
            if (b8.Text != "") {
                b8.Enabled = false;
                if (b8.Text == b7.Text && b8.Text == b9.Text) {
                    WINNER.Text = ("WINNER: " + b8.Text); form2.label2.Text = WINNER.Text; Renew();
                }
            }
            if (b9.Text != "") {
                b9.Enabled = false;
            }
            if (b1.Text != "" && b2.Text != "" && b3.Text != "" && b4.Text != "" && b5.Text != ""
               && b6.Text != "" && b7.Text != "" && b8.Text != "" && b9.Text != "" && WINNER.Text == "") {
                WINNER.Text = "НИЧЬЯ!!! "; form2.label2.Text = WINNER.Text; Renew();
            }
        }
        void b_Check() {
            if (dataServer.ToString() == "X") {
                b_X.Enabled = false;
                button1.Enabled = false;
                XorO = "O";
                b_O.Enabled = false;
                b_O.BackColor = Color.Green;
            }
            if (dataServer.ToString() == "O") {
                b_O.Enabled = false;
                button1.Enabled = false;
                XorO = "X";
                b_X.Enabled = false;
                b_X.BackColor = Color.Red;
            }

            if (dataServer.ToString() == "1X") {
                b1.Text = "X";
                b1.BackColor = Color.Red;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "2X") {
                b2.Text = "X";
                b2.BackColor = Color.Red;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "3X") {
                b3.Text = "X";
                b3.BackColor = Color.Red;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "4X") {
                b4.Text = "X";
                b4.BackColor = Color.Red;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "5X") {
                b5.Text = "X";
                b5.BackColor = Color.Red;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "6X") {
                b6.Text = "X";
                b6.BackColor = Color.Red;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "7X") {
                b7.Text = "X";
                b7.BackColor = Color.Red;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "8X") {
                b8.Text = "X";
                b8.BackColor = Color.Red;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "9X") {
                b9.Text = "X";
                b9.BackColor = Color.Red;
                b_ON();
                WINNERCheck();
            }////////////////////////////////////
            if (dataServer.ToString() == "1O") {
                b1.Text = "O";
                b1.BackColor = Color.Green;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "2O") {
                b2.Text = "O";
                b2.BackColor = Color.Green;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "3O") {
                b3.Text = "O";
                b3.BackColor = Color.Green;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "4O") {
                b4.Text = "O";
                b4.BackColor = Color.Green;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "5O") {
                b5.Text = "O";
                b5.BackColor = Color.Green;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "6O") {
                b6.Text = "O";
                b6.BackColor = Color.Green;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "7O") {
                b7.Text = "O";
                b7.BackColor = Color.Green;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "8O") {
                b8.Text = "O";
                b8.BackColor = Color.Green;
                b_ON();
                WINNERCheck();
            }
            if (dataServer.ToString() == "9O") {
                b9.Text = "O";
                b9.BackColor = Color.Green;
                b_ON();
                WINNERCheck();
            }

            if (dataServer.ToString() == "OUT") {
                textBox5.Text = "Другой игрок покинул игру";
            }
        }
        private void button1_Click(object sender, EventArgs e) {
            Socket tcpSocket = null;
            if (tcpSocket == null) {
                Server();
                timer1.Enabled = true;
            }
        }

        private void b1_Click(object sender, EventArgs e) {
            b1.Text = XorO;
            if (XorO == "X") {
                message = "1X";
                b1.BackColor = Color.Red;
            } else if (XorO == "O") {
                message = "1O";
                b1.BackColor = Color.Green;
            }
            b_OFF();
            Client();
            WINNERCheck();
        }
        private void b2_Click(object sender, EventArgs e) {
            b2.Text = XorO;
            if (XorO == "X") { message = "2X"; b2.BackColor = Color.Red; } else if (XorO == "O") { message = "2O"; b2.BackColor = Color.Green; }
            b_OFF();
            Client();
            WINNERCheck();
        }
        private void b3_Click(object sender, EventArgs e) {
            b3.Text = XorO;
            if (XorO == "X") { message = "3X"; b3.BackColor = Color.Red; } else if (XorO == "O") { message = "3O"; b3.BackColor = Color.Green; }
            b_OFF();
            Client();
            WINNERCheck();
        }
        private void b4_Click(object sender, EventArgs e) {
            b4.Text = XorO;
            if (XorO == "X") { message = "4X"; b4.BackColor = Color.Red; } else if (XorO == "O") { message = "4O"; b4.BackColor = Color.Green; }
            b_OFF();
            Client();
            WINNERCheck();
        }
        private void b5_Click(object sender, EventArgs e) {
            b5.Text = XorO;
            if (XorO == "X") { message = "5X"; b5.BackColor = Color.Red; } else if (XorO == "O") { message = "5O"; b5.BackColor = Color.Green; }
            b_OFF();
            Client();
            WINNERCheck();
        }
        private void b6_Click(object sender, EventArgs e) {
            b6.Text = XorO;
            if (XorO == "X") { message = "6X"; b6.BackColor = Color.Red; } else if (XorO == "O") { message = "6O"; b6.BackColor = Color.Green; }
            b_OFF();
            Client();
            WINNERCheck();
        }
        private void b7_Click(object sender, EventArgs e) {
            b7.Text = XorO;
            if (XorO == "X") { message = "7X"; b7.BackColor = Color.Red; } else if (XorO == "O") { message = "7O"; b7.BackColor = Color.Green; }
            b_OFF();
            Client();
            WINNERCheck();
        }
        private void b8_Click(object sender, EventArgs e) {
            b8.Text = XorO;
            if (XorO == "X") { message = "8X"; b8.BackColor = Color.Red; } else if (XorO == "O") { message = "8O"; b8.BackColor = Color.Green; }
            b_OFF();
            Client();
            WINNERCheck();
        }
        private void b9_Click(object sender, EventArgs e) {
            b9.Text = XorO;
            if (XorO == "X") { message = "9X"; b9.BackColor = Color.Red; } else if (XorO == "O") { message = "9O"; b9.BackColor = Color.Green; }
            b_OFF();
            Client();
            WINNERCheck();
        }


        private void b_X_Click(object sender, EventArgs e) {
            button1.Enabled = false;
            b_X.BackColor = Color.Red;
            b_X.Enabled = false;
            b_O.Enabled = false;
            XorO = "X";
            message = "X";
            Client();
            b_ON();
        }
        private void b_O_Click(object sender, EventArgs e) {
            button1.Enabled = false;
            b_X.Enabled = false;
            b_O.BackColor = Color.Green;
            b_O.Enabled = false;
            XorO = "O";
            message = "O";
            Client();
            b_ON();
        }


        private void bADRESS_Click(object sender, EventArgs e) {
            textBox1.Text = GetIPAddress3().ToString();
            textBox2.Text = "8888";
            textBox3.Text = GetIPAddress3().ToString();
            textBox4.Text = "4444";
        }
        public static IPAddress GetIPAddress3() {
            using (Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, 0)) {
                socket.Connect("8.8.8.8", 65530);
                IPEndPoint endPoint = socket.LocalEndPoint as IPEndPoint;
                return endPoint.Address;
            }
        }
        private void b_TIMER_Click(object sender, EventArgs e) {
            TIMER_CHECK();
        }
        void TIMER_CHECK() {
            message = "111";
            Client();
            if (answer != null) {
                b_X.Enabled = true;
                b_O.Enabled = true;
                timer1.Enabled = false;
            } else {
                textBox5.Text += "NO ANSWER\r\n ";

            }
        }
        void b_ON() {
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
        }
        void b_OFF() {
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = false;
            b6.Enabled = false;
            b7.Enabled = false;
            b8.Enabled = false;
            b9.Enabled = false;
        }


        private void Form1_FormClosed(object sender, FormClosedEventArgs e) {
            message = "OUT"; Client(); Thread.Sleep(500);
        }

        

        //private void button2_Click(object sender, EventArgs e) {
        //    textBox2.Text = "4444"; textBox4.Text = "8888"; 
        //}       
    }
}
