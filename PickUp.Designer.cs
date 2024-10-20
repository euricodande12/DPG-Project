namespace NoahsArk
{
    partial class PickUp
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
            btnPickUp = new Button();
            txtChildUniqueCode = new TextBox();
            lblChildUniqueCode = new Label();
            lblParentPhoneNumber = new Label();
            lblPickUp = new Label();
            txtParentPhoneNumber = new TextBox();
            btnBack = new Button();
            SuspendLayout();
            // 
            // btnPickUp
            // 
            btnPickUp.BackColor = SystemColors.ControlDarkDark;
            btnPickUp.Cursor = Cursors.Hand;
            btnPickUp.FlatStyle = FlatStyle.System;
            btnPickUp.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPickUp.ForeColor = SystemColors.Control;
            btnPickUp.Location = new Point(21, 223);
            btnPickUp.Name = "btnPickUp";
            btnPickUp.Size = new Size(270, 30);
            btnPickUp.TabIndex = 15;
            btnPickUp.Text = "Pick Up";
            btnPickUp.UseVisualStyleBackColor = false;
            btnPickUp.Click += btnPickUp_Click;
            // 
            // txtChildUniqueCode
            // 
            txtChildUniqueCode.BackColor = SystemColors.Control;
            txtChildUniqueCode.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtChildUniqueCode.ForeColor = SystemColors.ControlDark;
            txtChildUniqueCode.Location = new Point(21, 176);
            txtChildUniqueCode.Name = "txtChildUniqueCode";
            txtChildUniqueCode.Size = new Size(270, 27);
            txtChildUniqueCode.TabIndex = 14;
            // 
            // lblChildUniqueCode
            // 
            lblChildUniqueCode.AutoSize = true;
            lblChildUniqueCode.Font = new Font("Bahnschrift Condensed", 12F);
            lblChildUniqueCode.ForeColor = SystemColors.ControlDarkDark;
            lblChildUniqueCode.Location = new Point(21, 150);
            lblChildUniqueCode.Name = "lblChildUniqueCode";
            lblChildUniqueCode.Size = new Size(103, 19);
            lblChildUniqueCode.TabIndex = 13;
            lblChildUniqueCode.Text = "Child Unique Code";
            // 
            // lblParentPhoneNumber
            // 
            lblParentPhoneNumber.AutoSize = true;
            lblParentPhoneNumber.Font = new Font("Bahnschrift Condensed", 12F);
            lblParentPhoneNumber.ForeColor = SystemColors.ControlDarkDark;
            lblParentPhoneNumber.Location = new Point(21, 77);
            lblParentPhoneNumber.Name = "lblParentPhoneNumber";
            lblParentPhoneNumber.Size = new Size(125, 19);
            lblParentPhoneNumber.TabIndex = 12;
            lblParentPhoneNumber.Text = "Parent Phone Number";
            // 
            // lblPickUp
            // 
            lblPickUp.AutoSize = true;
            lblPickUp.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPickUp.ForeColor = SystemColors.ControlDark;
            lblPickUp.Location = new Point(20, 28);
            lblPickUp.Name = "lblPickUp";
            lblPickUp.Size = new Size(72, 29);
            lblPickUp.TabIndex = 11;
            lblPickUp.Text = "Pick Up";
            // 
            // txtParentPhoneNumber
            // 
            txtParentPhoneNumber.BackColor = SystemColors.Control;
            txtParentPhoneNumber.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtParentPhoneNumber.ForeColor = SystemColors.ControlDark;
            txtParentPhoneNumber.Location = new Point(21, 103);
            txtParentPhoneNumber.Name = "txtParentPhoneNumber";
            txtParentPhoneNumber.Size = new Size(270, 27);
            txtParentPhoneNumber.TabIndex = 10;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(235, 32);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(56, 25);
            btnBack.TabIndex = 16;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // PickUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(310, 272);
            Controls.Add(btnBack);
            Controls.Add(btnPickUp);
            Controls.Add(txtChildUniqueCode);
            Controls.Add(lblChildUniqueCode);
            Controls.Add(lblParentPhoneNumber);
            Controls.Add(lblPickUp);
            Controls.Add(txtParentPhoneNumber);
            Name = "PickUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PickUp";
            FormClosing += PickUp_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnPickUp;
        private TextBox txtChildUniqueCode;
        private Label lblChildUniqueCode;
        private Label lblParentPhoneNumber;
        private Label lblPickUp;
        private TextBox txtParentPhoneNumber;
        private Button btnBack;
    }
}