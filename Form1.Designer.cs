
namespace XOGame {
    partial class Form1 {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.b_X = new System.Windows.Forms.Button();
            this.b_O = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.bADRESS = new System.Windows.Forms.Button();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.b1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.WINNER = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "PORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "SERVER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "CLIENT";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(79, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(79, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(121, 22);
            this.textBox2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(232, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "PORT";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(322, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(116, 22);
            this.textBox3.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(322, 76);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(116, 22);
            this.textBox4.TabIndex = 9;
            this.textBox4.Text = "4444";
            // 
            // b_X
            // 
            this.b_X.Location = new System.Drawing.Point(15, 113);
            this.b_X.Name = "b_X";
            this.b_X.Size = new System.Drawing.Size(32, 27);
            this.b_X.TabIndex = 10;
            this.b_X.Text = "X";
            this.b_X.UseVisualStyleBackColor = true;
            this.b_X.Click += new System.EventHandler(this.b_X_Click);
            // 
            // b_O
            // 
            this.b_O.Location = new System.Drawing.Point(53, 113);
            this.b_O.Name = "b_O";
            this.b_O.Size = new System.Drawing.Size(34, 27);
            this.b_O.TabIndex = 11;
            this.b_O.Text = "O";
            this.b_O.UseVisualStyleBackColor = true;
            this.b_O.Click += new System.EventHandler(this.b_O_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(94, 113);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 27);
            this.button1.TabIndex = 12;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bADRESS
            // 
            this.bADRESS.Location = new System.Drawing.Point(322, 113);
            this.bADRESS.Name = "bADRESS";
            this.bADRESS.Size = new System.Drawing.Size(100, 23);
            this.bADRESS.TabIndex = 13;
            this.bADRESS.Text = "GetAdress";
            this.bADRESS.UseVisualStyleBackColor = true;
            this.bADRESS.Click += new System.EventHandler(this.bADRESS_Click);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(322, 154);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(116, 176);
            this.textBox5.TabIndex = 9;
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(21, 174);
            this.b1.Margin = new System.Windows.Forms.Padding(0);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(61, 52);
            this.b1.TabIndex = 14;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(82, 178);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 52);
            this.button3.TabIndex = 14;
            this.button3.Text = "button2";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(139, 174);
            this.b3.Margin = new System.Windows.Forms.Padding(0);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(61, 52);
            this.b3.TabIndex = 14;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b3_Click);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(21, 226);
            this.b4.Margin = new System.Windows.Forms.Padding(0);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(61, 52);
            this.b4.TabIndex = 14;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b4_Click);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(139, 226);
            this.b6.Margin = new System.Windows.Forms.Padding(0);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(61, 52);
            this.b6.TabIndex = 14;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b6_Click);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(79, 174);
            this.b2.Margin = new System.Windows.Forms.Padding(0);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(61, 52);
            this.b2.TabIndex = 14;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b2_Click);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(79, 226);
            this.b5.Margin = new System.Windows.Forms.Padding(0);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(61, 52);
            this.b5.TabIndex = 14;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b5_Click);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(78, 278);
            this.b8.Margin = new System.Windows.Forms.Padding(0);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(61, 52);
            this.b8.TabIndex = 14;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b8_Click);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(21, 278);
            this.b7.Margin = new System.Windows.Forms.Padding(0);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(61, 52);
            this.b7.TabIndex = 14;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b7_Click);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(139, 278);
            this.b9.Margin = new System.Windows.Forms.Padding(0);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(61, 52);
            this.b9.TabIndex = 14;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b9_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.b_TIMER_Click);
            // 
            // WINNER
            // 
            this.WINNER.AutoSize = true;
            this.WINNER.Location = new System.Drawing.Point(21, 347);
            this.WINNER.Name = "WINNER";
            this.WINNER.Size = new System.Drawing.Size(0, 17);
            this.WINNER.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 376);
            this.Controls.Add(this.WINNER);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.bADRESS);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.b_O);
            this.Controls.Add(this.b_X);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Крестики-Нолики";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button b_X;
        private System.Windows.Forms.Button b_O;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bADRESS;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label WINNER;
    }
}

