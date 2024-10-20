namespace NoahsArk
{
    partial class Form1
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
            txtFirstName = new TextBox();
            lblSignUp = new Label();
            lblFirstName = new Label();
            txtLastName = new TextBox();
            lblLastName = new Label();
            lblUsername = new Label();
            txtUsername = new TextBox();
            lblPassword = new Label();
            txtPassword = new TextBox();
            btnSignUp = new Button();
            lblAlreadyHasAnAccount = new Label();
            llbLogin = new LinkLabel();
            chkShowPassword = new CheckBox();
            SuspendLayout();
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = SystemColors.Control;
            txtFirstName.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtFirstName.ForeColor = SystemColors.ControlDark;
            txtFirstName.Location = new Point(22, 96);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(135, 27);
            txtFirstName.TabIndex = 0;
            // 
            // lblSignUp
            // 
            lblSignUp.AutoSize = true;
            lblSignUp.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSignUp.ForeColor = SystemColors.ControlDark;
            lblSignUp.Location = new Point(21, 21);
            lblSignUp.Name = "lblSignUp";
            lblSignUp.Size = new Size(73, 29);
            lblSignUp.TabIndex = 1;
            lblSignUp.Text = "Sign Up";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.ForeColor = SystemColors.ControlDarkDark;
            lblFirstName.Location = new Point(22, 70);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(78, 23);
            lblFirstName.TabIndex = 2;
            lblFirstName.Text = "First Name";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = SystemColors.Control;
            txtLastName.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtLastName.ForeColor = SystemColors.ControlDark;
            txtLastName.Location = new Point(176, 96);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(135, 27);
            txtLastName.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.ForeColor = SystemColors.ControlDarkDark;
            lblLastName.Location = new Point(176, 70);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(76, 23);
            lblLastName.TabIndex = 4;
            lblLastName.Text = "Last Name";
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.ForeColor = SystemColors.ControlDarkDark;
            lblUsername.Location = new Point(22, 143);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(73, 23);
            lblUsername.TabIndex = 5;
            lblUsername.Text = "Username";
            // 
            // txtUsername
            // 
            txtUsername.BackColor = SystemColors.Control;
            txtUsername.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsername.ForeColor = SystemColors.ControlDark;
            txtUsername.Location = new Point(22, 169);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(135, 27);
            txtUsername.TabIndex = 6;
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.ForeColor = SystemColors.ControlDarkDark;
            lblPassword.Location = new Point(176, 143);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(72, 23);
            lblPassword.TabIndex = 7;
            lblPassword.Text = "Password";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = SystemColors.Control;
            txtPassword.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = SystemColors.ControlDark;
            txtPassword.Location = new Point(176, 169);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(135, 27);
            txtPassword.TabIndex = 8;
            // 
            // btnSignUp
            // 
            btnSignUp.BackColor = SystemColors.ControlDarkDark;
            btnSignUp.Cursor = Cursors.Hand;
            btnSignUp.FlatStyle = FlatStyle.System;
            btnSignUp.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnSignUp.ForeColor = SystemColors.Control;
            btnSignUp.Location = new Point(22, 258);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(289, 30);
            btnSignUp.TabIndex = 9;
            btnSignUp.Text = "Sign Up";
            btnSignUp.UseVisualStyleBackColor = false;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // lblAlreadyHasAnAccount
            // 
            lblAlreadyHasAnAccount.AutoSize = true;
            lblAlreadyHasAnAccount.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblAlreadyHasAnAccount.ForeColor = SystemColors.ControlDarkDark;
            lblAlreadyHasAnAccount.Location = new Point(163, 307);
            lblAlreadyHasAnAccount.Name = "lblAlreadyHasAnAccount";
            lblAlreadyHasAnAccount.Size = new Size(112, 16);
            lblAlreadyHasAnAccount.TabIndex = 10;
            lblAlreadyHasAnAccount.Text = "Already has an account?";
            // 
            // llbLogin
            // 
            llbLogin.ActiveLinkColor = Color.Black;
            llbLogin.AutoSize = true;
            llbLogin.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            llbLogin.LinkColor = SystemColors.ControlDarkDark;
            llbLogin.Location = new Point(279, 308);
            llbLogin.Name = "llbLogin";
            llbLogin.Size = new Size(30, 16);
            llbLogin.TabIndex = 11;
            llbLogin.TabStop = true;
            llbLogin.Text = "Login";
            llbLogin.LinkClicked += llbLogin_LinkClicked;
            // 
            // chkShowPassword
            // 
            chkShowPassword.AutoSize = true;
            chkShowPassword.Location = new Point(180, 212);
            chkShowPassword.Name = "chkShowPassword";
            chkShowPassword.Size = new Size(129, 27);
            chkShowPassword.TabIndex = 12;
            chkShowPassword.Text = "Show Password";
            chkShowPassword.UseVisualStyleBackColor = true;
            chkShowPassword.CheckedChanged += chkShowPassword_CheckedChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(332, 347);
            Controls.Add(chkShowPassword);
            Controls.Add(llbLogin);
            Controls.Add(lblAlreadyHasAnAccount);
            Controls.Add(btnSignUp);
            Controls.Add(txtPassword);
            Controls.Add(lblPassword);
            Controls.Add(txtUsername);
            Controls.Add(lblUsername);
            Controls.Add(lblLastName);
            Controls.Add(txtLastName);
            Controls.Add(lblFirstName);
            Controls.Add(lblSignUp);
            Controls.Add(txtFirstName);
            Font = new Font("Bahnschrift Condensed", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 5, 3, 5);
            MinimizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoahsArk";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFirstName;
        private Label lblSignUp;
        private Label lblFirstName;
        private TextBox txtLastName;
        private Label lblLastName;
        private Label lblUsername;
        private TextBox txtUsername;
        private Label lblPassword;
        private TextBox txtPassword;
        private Button btnSignUp;
        private Label lblAlreadyHasAnAccount;
        private LinkLabel llbLogin;
        private CheckBox chkShowPassword;
    }
}
