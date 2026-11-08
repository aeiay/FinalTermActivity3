namespace Forms
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            buttonReg = new Button();
            linkLabel1 = new LinkLabel();
            textBox5 = new TextBox();
            label9 = new Label();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(buttonReg);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(textBox3);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(177, 27);
            panel1.Name = "panel1";
            panel1.Size = new Size(441, 507);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // buttonReg
            // 
            buttonReg.BackColor = Color.FromArgb(0, 0, 64);
            buttonReg.ForeColor = Color.White;
            buttonReg.Location = new Point(43, 385);
            buttonReg.Name = "buttonReg";
            buttonReg.Size = new Size(342, 49);
            buttonReg.TabIndex = 19;
            buttonReg.Text = "REGISTER";
            buttonReg.UseVisualStyleBackColor = false;
            buttonReg.Click += buttonReg_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(96, 437);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(227, 20);
            linkLabel1.TabIndex = 18;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Already have an account? Sign In";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(43, 297);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(343, 27);
            textBox5.TabIndex = 14;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label9.ForeColor = SystemColors.ControlDarkDark;
            label9.Location = new Point(43, 275);
            label9.Name = "label9";
            label9.Size = new Size(123, 19);
            label9.TabIndex = 13;
            label9.Text = "Confirm Password";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(43, 239);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(343, 27);
            textBox3.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label7.ForeColor = SystemColors.ControlDarkDark;
            label7.Location = new Point(42, 217);
            label7.Name = "label7";
            label7.Size = new Size(68, 19);
            label7.TabIndex = 11;
            label7.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(43, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(343, 27);
            textBox2.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(43, 159);
            label4.Name = "label4";
            label4.Size = new Size(71, 19);
            label4.TabIndex = 4;
            label4.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(43, 123);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(342, 27);
            textBox1.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(43, 101);
            label3.Name = "label3";
            label3.Size = new Size(73, 19);
            label3.TabIndex = 2;
            label3.Text = "Full Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(33, 27);
            label2.Name = "label2";
            label2.Size = new Size(273, 39);
            label2.TabIndex = 1;
            label2.Text = "Create an Account";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(41, 63);
            label1.Name = "label1";
            label1.Size = new Size(241, 17);
            label1.TabIndex = 0;
            label1.Text = "Get started by filling in your information";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 563);
            Controls.Add(panel1);
            Name = "Register";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox5;
        private Label label9;
        private LinkLabel linkLabel1;
        private Button buttonReg;
    }
}