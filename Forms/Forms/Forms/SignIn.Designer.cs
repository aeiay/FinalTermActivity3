namespace Forms
{
    partial class SignIn
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            linkRegister = new LinkLabel();
            btnSignIn = new Button();
            label6 = new Label();
            checkBox1 = new CheckBox();
            txtUsername = new TextBox();
            label4 = new Label();
            txtPassword = new TextBox();
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
            panel1.Controls.Add(linkRegister);
            panel1.Controls.Add(btnSignIn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(checkBox1);
            panel1.Controls.Add(txtUsername);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txtPassword);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(263, 29);
            panel1.Name = "panel1";
            panel1.Size = new Size(387, 437);
            panel1.TabIndex = 0;
            // 
            // linkRegister
            // 
            linkRegister.AutoSize = true;
            linkRegister.Font = new Font("Segoe UI Semibold", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            linkRegister.LinkColor = SystemColors.ControlDarkDark;
            linkRegister.Location = new Point(230, 387);
            linkRegister.Name = "linkRegister";
            linkRegister.Size = new Size(60, 19);
            linkRegister.TabIndex = 10;
            linkRegister.TabStop = true;
            linkRegister.Text = "Register";
            linkRegister.Click += linkRegister_Click;
            // 
            // btnSignIn
            // 
            btnSignIn.BackColor = Color.FromArgb(0, 0, 64);
            btnSignIn.Font = new Font("Segoe UI", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignIn.ForeColor = Color.White;
            btnSignIn.Location = new Point(34, 327);
            btnSignIn.Margin = new Padding(3, 4, 3, 4);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(320, 59);
            btnSignIn.TabIndex = 9;
            btnSignIn.Text = "SIGN IN";
            btnSignIn.UseVisualStyleBackColor = false;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label6.ForeColor = SystemColors.ControlDarkDark;
            label6.Location = new Point(94, 387);
            label6.Name = "label6";
            label6.Size = new Size(155, 19);
            label6.TabIndex = 8;
            label6.Text = "Don't have an account?";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new Font("Segoe UI Semibold", 7.20000029F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBox1.ForeColor = Color.Gray;
            checkBox1.Location = new Point(34, 239);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(125, 21);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(34, 135);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(319, 27);
            txtUsername.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label4.ForeColor = SystemColors.ControlDarkDark;
            label4.Location = new Point(30, 181);
            label4.Name = "label4";
            label4.Size = new Size(68, 19);
            label4.TabIndex = 4;
            label4.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(33, 204);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(321, 27);
            txtPassword.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 8F, FontStyle.Bold);
            label3.ForeColor = SystemColors.ControlDarkDark;
            label3.Location = new Point(31, 113);
            label3.Name = "label3";
            label3.Size = new Size(71, 19);
            label3.TabIndex = 2;
            label3.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft PhagsPa", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(23, 23);
            label2.Name = "label2";
            label2.Size = new Size(218, 37);
            label2.TabIndex = 1;
            label2.Text = "Welcome Back!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft PhagsPa", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(31, 60);
            label1.Name = "label1";
            label1.Size = new Size(142, 17);
            label1.TabIndex = 0;
            label1.Text = "Sign In to your account";
            // 
            // SignIn
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(874, 513);
            Controls.Add(panel1);
            Name = "SignIn";
            Text = "SignIn";
            Load += SignIn_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label4;
        private CheckBox checkBox1;
        private Label label6;
        private Button btnSignIn;
        private LinkLabel linkRegister;
    }
}
