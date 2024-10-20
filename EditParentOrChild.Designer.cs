namespace NoahsArk
{
    partial class EditParentOrChild
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
            btnEditParentInformation = new Button();
            gbxChildInformation = new GroupBox();
            txtChildUniqueCode = new TextBox();
            lblChildUniqueCode = new Label();
            dtpDateOfBirth = new DateTimePicker();
            lblDateOfBirth = new Label();
            txtChildLastName = new TextBox();
            lblChildLastName = new Label();
            txtChildFirstName = new TextBox();
            lblChildFirstName = new Label();
            gbxParentInformation = new GroupBox();
            txtParentID = new TextBox();
            lblParentID = new Label();
            txtParentPhoneNumber = new TextBox();
            lblParentPhoneNumber = new Label();
            txtParentEmail = new TextBox();
            lblParentEmail = new Label();
            txtParentLastName = new TextBox();
            lblParentLastName = new Label();
            txtParentFirstName = new TextBox();
            lblParentFirstName = new Label();
            lblDrop = new Label();
            btnEditChildInformation = new Button();
            btnBack = new Button();
            gbxChildInformation.SuspendLayout();
            gbxParentInformation.SuspendLayout();
            SuspendLayout();
            // 
            // btnEditParentInformation
            // 
            btnEditParentInformation.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditParentInformation.Location = new Point(32, 351);
            btnEditParentInformation.Name = "btnEditParentInformation";
            btnEditParentInformation.Size = new Size(350, 28);
            btnEditParentInformation.TabIndex = 8;
            btnEditParentInformation.Text = "Edit Parent Information";
            btnEditParentInformation.UseVisualStyleBackColor = true;
            btnEditParentInformation.Click += btnEditParentInformation_Click;
            // 
            // gbxChildInformation
            // 
            gbxChildInformation.Controls.Add(txtChildUniqueCode);
            gbxChildInformation.Controls.Add(lblChildUniqueCode);
            gbxChildInformation.Controls.Add(dtpDateOfBirth);
            gbxChildInformation.Controls.Add(lblDateOfBirth);
            gbxChildInformation.Controls.Add(txtChildLastName);
            gbxChildInformation.Controls.Add(lblChildLastName);
            gbxChildInformation.Controls.Add(txtChildFirstName);
            gbxChildInformation.Controls.Add(lblChildFirstName);
            gbxChildInformation.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxChildInformation.ForeColor = SystemColors.ControlDark;
            gbxChildInformation.Location = new Point(415, 75);
            gbxChildInformation.Name = "gbxChildInformation";
            gbxChildInformation.Size = new Size(350, 250);
            gbxChildInformation.TabIndex = 5;
            gbxChildInformation.TabStop = false;
            gbxChildInformation.Text = "Child Information";
            // 
            // txtChildUniqueCode
            // 
            txtChildUniqueCode.BackColor = SystemColors.Control;
            txtChildUniqueCode.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChildUniqueCode.ForeColor = SystemColors.ControlDark;
            txtChildUniqueCode.Location = new Point(24, 61);
            txtChildUniqueCode.Name = "txtChildUniqueCode";
            txtChildUniqueCode.Size = new Size(297, 27);
            txtChildUniqueCode.TabIndex = 13;
            // 
            // lblChildUniqueCode
            // 
            lblChildUniqueCode.AutoSize = true;
            lblChildUniqueCode.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChildUniqueCode.ForeColor = SystemColors.ControlDarkDark;
            lblChildUniqueCode.Location = new Point(22, 38);
            lblChildUniqueCode.Name = "lblChildUniqueCode";
            lblChildUniqueCode.Size = new Size(103, 19);
            lblChildUniqueCode.TabIndex = 12;
            lblChildUniqueCode.Text = "Child Unique Code";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CalendarMonthBackground = SystemColors.Control;
            dtpDateOfBirth.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Location = new Point(24, 195);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(300, 27);
            dtpDateOfBirth.TabIndex = 11;
            // 
            // lblDateOfBirth
            // 
            lblDateOfBirth.AutoSize = true;
            lblDateOfBirth.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDateOfBirth.ForeColor = SystemColors.ControlDarkDark;
            lblDateOfBirth.Location = new Point(21, 172);
            lblDateOfBirth.Name = "lblDateOfBirth";
            lblDateOfBirth.Size = new Size(76, 19);
            lblDateOfBirth.TabIndex = 10;
            lblDateOfBirth.Text = "Date Of Birth";
            // 
            // txtChildLastName
            // 
            txtChildLastName.BackColor = SystemColors.Control;
            txtChildLastName.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChildLastName.ForeColor = SystemColors.ControlDark;
            txtChildLastName.Location = new Point(184, 125);
            txtChildLastName.Name = "txtChildLastName";
            txtChildLastName.Size = new Size(140, 27);
            txtChildLastName.TabIndex = 7;
            // 
            // lblChildLastName
            // 
            lblChildLastName.AutoSize = true;
            lblChildLastName.BackColor = Color.FromArgb(0, 0, 0, 0);
            lblChildLastName.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChildLastName.ForeColor = SystemColors.ControlDarkDark;
            lblChildLastName.Location = new Point(182, 101);
            lblChildLastName.Name = "lblChildLastName";
            lblChildLastName.Size = new Size(65, 19);
            lblChildLastName.TabIndex = 6;
            lblChildLastName.Text = "Last Name";
            // 
            // txtChildFirstName
            // 
            txtChildFirstName.BackColor = SystemColors.Control;
            txtChildFirstName.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChildFirstName.ForeColor = SystemColors.ControlDark;
            txtChildFirstName.Location = new Point(24, 125);
            txtChildFirstName.Name = "txtChildFirstName";
            txtChildFirstName.Size = new Size(140, 27);
            txtChildFirstName.TabIndex = 5;
            // 
            // lblChildFirstName
            // 
            lblChildFirstName.AutoSize = true;
            lblChildFirstName.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblChildFirstName.ForeColor = SystemColors.ControlDarkDark;
            lblChildFirstName.Location = new Point(21, 102);
            lblChildFirstName.Name = "lblChildFirstName";
            lblChildFirstName.Size = new Size(66, 19);
            lblChildFirstName.TabIndex = 4;
            lblChildFirstName.Text = "First Name";
            // 
            // gbxParentInformation
            // 
            gbxParentInformation.Controls.Add(txtParentID);
            gbxParentInformation.Controls.Add(lblParentID);
            gbxParentInformation.Controls.Add(txtParentPhoneNumber);
            gbxParentInformation.Controls.Add(lblParentPhoneNumber);
            gbxParentInformation.Controls.Add(txtParentEmail);
            gbxParentInformation.Controls.Add(lblParentEmail);
            gbxParentInformation.Controls.Add(txtParentLastName);
            gbxParentInformation.Controls.Add(lblParentLastName);
            gbxParentInformation.Controls.Add(txtParentFirstName);
            gbxParentInformation.Controls.Add(lblParentFirstName);
            gbxParentInformation.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbxParentInformation.ForeColor = SystemColors.ControlDark;
            gbxParentInformation.Location = new Point(32, 75);
            gbxParentInformation.Name = "gbxParentInformation";
            gbxParentInformation.Size = new Size(350, 250);
            gbxParentInformation.TabIndex = 7;
            gbxParentInformation.TabStop = false;
            gbxParentInformation.Text = "Parent Information";
            // 
            // txtParentID
            // 
            txtParentID.BackColor = SystemColors.Control;
            txtParentID.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParentID.ForeColor = SystemColors.ControlDark;
            txtParentID.Location = new Point(26, 61);
            txtParentID.Name = "txtParentID";
            txtParentID.Size = new Size(297, 27);
            txtParentID.TabIndex = 6;
            // 
            // lblParentID
            // 
            lblParentID.AutoSize = true;
            lblParentID.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParentID.ForeColor = SystemColors.ControlDarkDark;
            lblParentID.Location = new Point(24, 38);
            lblParentID.Name = "lblParentID";
            lblParentID.Size = new Size(19, 19);
            lblParentID.TabIndex = 5;
            lblParentID.Text = "ID";
            // 
            // txtParentPhoneNumber
            // 
            txtParentPhoneNumber.BackColor = SystemColors.Control;
            txtParentPhoneNumber.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParentPhoneNumber.ForeColor = SystemColors.ControlDark;
            txtParentPhoneNumber.Location = new Point(183, 195);
            txtParentPhoneNumber.Name = "txtParentPhoneNumber";
            txtParentPhoneNumber.Size = new Size(140, 27);
            txtParentPhoneNumber.TabIndex = 2;
            // 
            // lblParentPhoneNumber
            // 
            lblParentPhoneNumber.AutoSize = true;
            lblParentPhoneNumber.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParentPhoneNumber.ForeColor = SystemColors.ControlDarkDark;
            lblParentPhoneNumber.Location = new Point(183, 172);
            lblParentPhoneNumber.Name = "lblParentPhoneNumber";
            lblParentPhoneNumber.Size = new Size(86, 19);
            lblParentPhoneNumber.TabIndex = 2;
            lblParentPhoneNumber.Text = "Phone Number";
            // 
            // txtParentEmail
            // 
            txtParentEmail.BackColor = SystemColors.Control;
            txtParentEmail.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParentEmail.ForeColor = SystemColors.ControlDark;
            txtParentEmail.Location = new Point(29, 195);
            txtParentEmail.Name = "txtParentEmail";
            txtParentEmail.Size = new Size(137, 27);
            txtParentEmail.TabIndex = 4;
            // 
            // lblParentEmail
            // 
            lblParentEmail.AutoSize = true;
            lblParentEmail.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParentEmail.ForeColor = SystemColors.ControlDarkDark;
            lblParentEmail.Location = new Point(26, 172);
            lblParentEmail.Name = "lblParentEmail";
            lblParentEmail.Size = new Size(39, 19);
            lblParentEmail.TabIndex = 2;
            lblParentEmail.Text = "Email";
            // 
            // txtParentLastName
            // 
            txtParentLastName.BackColor = SystemColors.Control;
            txtParentLastName.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParentLastName.ForeColor = SystemColors.ControlDark;
            txtParentLastName.Location = new Point(183, 125);
            txtParentLastName.Name = "txtParentLastName";
            txtParentLastName.Size = new Size(140, 27);
            txtParentLastName.TabIndex = 3;
            // 
            // lblParentLastName
            // 
            lblParentLastName.AutoSize = true;
            lblParentLastName.BackColor = Color.FromArgb(0, 0, 0, 0);
            lblParentLastName.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParentLastName.ForeColor = SystemColors.ControlDarkDark;
            lblParentLastName.Location = new Point(181, 101);
            lblParentLastName.Name = "lblParentLastName";
            lblParentLastName.Size = new Size(65, 19);
            lblParentLastName.TabIndex = 2;
            lblParentLastName.Text = "Last Name";
            // 
            // txtParentFirstName
            // 
            txtParentFirstName.BackColor = SystemColors.Control;
            txtParentFirstName.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParentFirstName.ForeColor = SystemColors.ControlDark;
            txtParentFirstName.Location = new Point(26, 125);
            txtParentFirstName.Name = "txtParentFirstName";
            txtParentFirstName.Size = new Size(140, 27);
            txtParentFirstName.TabIndex = 1;
            // 
            // lblParentFirstName
            // 
            lblParentFirstName.AutoSize = true;
            lblParentFirstName.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblParentFirstName.ForeColor = SystemColors.ControlDarkDark;
            lblParentFirstName.Location = new Point(24, 102);
            lblParentFirstName.Name = "lblParentFirstName";
            lblParentFirstName.Size = new Size(66, 19);
            lblParentFirstName.TabIndex = 0;
            lblParentFirstName.Text = "First Name";
            // 
            // lblDrop
            // 
            lblDrop.AutoSize = true;
            lblDrop.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblDrop.ForeColor = SystemColors.ControlDark;
            lblDrop.Location = new Point(25, 26);
            lblDrop.Name = "lblDrop";
            lblDrop.Size = new Size(168, 29);
            lblDrop.TabIndex = 6;
            lblDrop.Text = "Edit Parent or Child";
            // 
            // btnEditChildInformation
            // 
            btnEditChildInformation.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnEditChildInformation.Location = new Point(415, 351);
            btnEditChildInformation.Name = "btnEditChildInformation";
            btnEditChildInformation.Size = new Size(350, 28);
            btnEditChildInformation.TabIndex = 9;
            btnEditChildInformation.Text = "Edit Child Information";
            btnEditChildInformation.UseVisualStyleBackColor = true;
            btnEditChildInformation.Click += btnEditChildInformation_Click;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(709, 33);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(56, 25);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // EditParentOrChild
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(795, 406);
            Controls.Add(btnBack);
            Controls.Add(btnEditChildInformation);
            Controls.Add(btnEditParentInformation);
            Controls.Add(gbxChildInformation);
            Controls.Add(gbxParentInformation);
            Controls.Add(lblDrop);
            Name = "EditParentOrChild";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditParentOrChild";
            FormClosing += EditParentOrChild_FormClosing;
            gbxChildInformation.ResumeLayout(false);
            gbxChildInformation.PerformLayout();
            gbxParentInformation.ResumeLayout(false);
            gbxParentInformation.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnEditParentInformation;
        private GroupBox gbxChildInformation;
        private DateTimePicker dtpDateOfBirth;
        private Label lblDateOfBirth;
        private TextBox txtChildLastName;
        private Label lblChildLastName;
        private TextBox txtChildFirstName;
        private Label lblChildFirstName;
        private GroupBox gbxParentInformation;
        private TextBox txtParentID;
        private Label lblParentID;
        private TextBox txtParentPhoneNumber;
        private Label lblParentPhoneNumber;
        private TextBox txtParentEmail;
        private Label lblParentEmail;
        private TextBox txtParentLastName;
        private Label lblParentLastName;
        private TextBox txtParentFirstName;
        private Label lblParentFirstName;
        private Label lblDrop;
        private TextBox txtChildUniqueCode;
        private Label lblChildUniqueCode;
        private Button btnEditChildInformation;
        private Button btnBack;
    }
}