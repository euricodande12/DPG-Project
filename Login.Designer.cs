namespace NoahsArk
{
    partial class Login
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
            lblLogin = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lblDontHaveAnAccount = new Label();
            llbSignUp = new LinkLabel();
            SuspendLayout();
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogin.ForeColor = SystemColors.ControlDark;
            lblLogin.Location = new Point(27, 24);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(56, 29);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Login";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsername.ForeColor = SystemColors.ControlDarkDark;
            lblUsername.Location = new Point(27, 72);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(73, 23);
            lblUsername.TabIndex = 1;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.ForeColor = SystemColors.ControlDark;
            txtUsername.Location = new Point(27, 98);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(241, 27);
            txtUsername.TabIndex = 2;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPassword.ForeColor = SystemColors.ControlDarkDark;
            lblPassword.Location = new Point(27, 145);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(72, 23);
            lblPassword.TabIndex = 3;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.ForeColor = SystemColors.ControlDark;
            txtPassword.Location = new Point(27, 171);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(241, 27);
            txtPassword.TabIndex = 4;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = SystemColors.ControlDarkDark;
            btnLogin.FlatStyle = FlatStyle.System;
            btnLogin.ForeColor = SystemColors.Control;
            btnLogin.Location = new Point(27, 216);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(241, 29);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblDontHaveAnAccount
            // 
            lblDontHaveAnAccount.AutoSize = true;
            lblDontHaveAnAccount.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDontHaveAnAccount.ForeColor = SystemColors.ControlDarkDark;
            lblDontHaveAnAccount.Location = new Point(118, 261);
            lblDontHaveAnAccount.Name = "lblDontHaveAnAccount";
            lblDontHaveAnAccount.Size = new Size(105, 16);
            lblDontHaveAnAccount.TabIndex = 6;
            lblDontHaveAnAccount.Text = "Don't have an account?";
            // 
            // llbSignUp
            // 
            llbSignUp.ActiveLinkColor = SystemColors.ControlDark;
            llbSignUp.AutoSize = true;
            llbSignUp.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbSignUp.LinkColor = SystemColors.ControlDarkDark;
            llbSignUp.Location = new Point(229, 261);
            llbSignUp.Name = "llbSignUp";
            llbSignUp.Size = new Size(39, 16);
            llbSignUp.TabIndex = 7;
            llbSignUp.TabStop = true;
            llbSignUp.Text = "Sign Up";
            llbSignUp.LinkClicked += llbSignUp_LinkClicked;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(6F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 308);
            Controls.Add(llbSignUp);
            Controls.Add(lblDontHaveAnAccount);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblLogin);
            Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MinimizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblLogin;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnLogin;
        private Label lblDontHaveAnAccount;
        private LinkLabel llbSignUp;
    }
}