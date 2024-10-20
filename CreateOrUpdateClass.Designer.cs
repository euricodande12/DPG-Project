namespace NoahsArk
{
    partial class CreateOrUpdateClass
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
            lblCreateClass = new Label();
            lblClassName = new Label();
            txtClassName = new TextBox();
            btnCreateClass = new Button();
            lblUpdateClass = new Label();
            lblClassOldName = new Label();
            txtClassOldName = new TextBox();
            lblClassNewName = new Label();
            txtClassNewName = new TextBox();
            btnUpdateClass = new Button();
            btnBack = new Button();
            SuspendLayout();
            // 
            // lblCreateClass
            // 
            lblCreateClass.AutoSize = true;
            lblCreateClass.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreateClass.ForeColor = SystemColors.ControlDark;
            lblCreateClass.Location = new Point(16, 18);
            lblCreateClass.Name = "lblCreateClass";
            lblCreateClass.Size = new Size(113, 29);
            lblCreateClass.TabIndex = 0;
            lblCreateClass.Text = "Create class";
            // 
            // lblClassName
            // 
            lblClassName.AutoSize = true;
            lblClassName.ForeColor = SystemColors.ControlDarkDark;
            lblClassName.Location = new Point(22, 65);
            lblClassName.Name = "lblClassName";
            lblClassName.Size = new Size(72, 19);
            lblClassName.TabIndex = 1;
            lblClassName.Text = "Class Name";
            // 
            // txtClassName
            // 
            txtClassName.BackColor = SystemColors.Control;
            txtClassName.ForeColor = SystemColors.ControlDark;
            txtClassName.Location = new Point(22, 94);
            txtClassName.Name = "txtClassName";
            txtClassName.Size = new Size(295, 27);
            txtClassName.TabIndex = 2;
            // 
            // btnCreateClass
            // 
            btnCreateClass.Cursor = Cursors.Hand;
            btnCreateClass.Location = new Point(23, 137);
            btnCreateClass.Name = "btnCreateClass";
            btnCreateClass.Size = new Size(294, 30);
            btnCreateClass.TabIndex = 3;
            btnCreateClass.Text = "Create Class";
            btnCreateClass.UseVisualStyleBackColor = true;
            btnCreateClass.Click += btnCreateClass_Click;
            // 
            // lblUpdateClass
            // 
            lblUpdateClass.AutoSize = true;
            lblUpdateClass.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUpdateClass.ForeColor = SystemColors.ControlDark;
            lblUpdateClass.Location = new Point(16, 186);
            lblUpdateClass.Name = "lblUpdateClass";
            lblUpdateClass.Size = new Size(117, 29);
            lblUpdateClass.TabIndex = 4;
            lblUpdateClass.Text = "Update Class";
            // 
            // lblClassOldName
            // 
            lblClassOldName.AutoSize = true;
            lblClassOldName.ForeColor = SystemColors.ControlDarkDark;
            lblClassOldName.Location = new Point(23, 231);
            lblClassOldName.Name = "lblClassOldName";
            lblClassOldName.Size = new Size(95, 19);
            lblClassOldName.TabIndex = 5;
            lblClassOldName.Text = "Class Old Name ";
            // 
            // txtClassOldName
            // 
            txtClassOldName.BackColor = SystemColors.Control;
            txtClassOldName.ForeColor = SystemColors.ControlDark;
            txtClassOldName.Location = new Point(23, 255);
            txtClassOldName.Name = "txtClassOldName";
            txtClassOldName.Size = new Size(294, 27);
            txtClassOldName.TabIndex = 6;
            // 
            // lblClassNewName
            // 
            lblClassNewName.AutoSize = true;
            lblClassNewName.ForeColor = SystemColors.ControlDarkDark;
            lblClassNewName.Location = new Point(23, 298);
            lblClassNewName.Name = "lblClassNewName";
            lblClassNewName.Size = new Size(97, 19);
            lblClassNewName.TabIndex = 7;
            lblClassNewName.Text = "Class New Name";
            // 
            // txtClassNewName
            // 
            txtClassNewName.BackColor = SystemColors.Control;
            txtClassNewName.ForeColor = SystemColors.ControlDark;
            txtClassNewName.Location = new Point(23, 328);
            txtClassNewName.Name = "txtClassNewName";
            txtClassNewName.Size = new Size(294, 27);
            txtClassNewName.TabIndex = 8;
            // 
            // btnUpdateClass
            // 
            btnUpdateClass.Cursor = Cursors.Hand;
            btnUpdateClass.Location = new Point(22, 370);
            btnUpdateClass.Name = "btnUpdateClass";
            btnUpdateClass.Size = new Size(295, 28);
            btnUpdateClass.TabIndex = 9;
            btnUpdateClass.Text = "Update Class";
            btnUpdateClass.UseVisualStyleBackColor = true;
            btnUpdateClass.Click += btnUpdateClass_Click;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Location = new Point(242, 21);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(75, 29);
            btnBack.TabIndex = 10;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // CreateOrUpdateClass
            // 
            AutoScaleDimensions = new SizeF(6F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 417);
            Controls.Add(btnBack);
            Controls.Add(btnUpdateClass);
            Controls.Add(txtClassNewName);
            Controls.Add(lblClassNewName);
            Controls.Add(txtClassOldName);
            Controls.Add(lblClassOldName);
            Controls.Add(lblUpdateClass);
            Controls.Add(btnCreateClass);
            Controls.Add(txtClassName);
            Controls.Add(lblClassName);
            Controls.Add(lblCreateClass);
            Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "CreateOrUpdateClass";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CreateOrUpdateClass";
            FormClosing += CreateOrUpdateClass_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCreateClass;
        private Label lblClassName;
        private TextBox txtClassName;
        private Button btnCreateClass;
        private Label lblUpdateClass;
        private Label lblClassOldName;
        private TextBox txtClassOldName;
        private Label lblClassNewName;
        private TextBox txtClassNewName;
        private Button btnUpdateClass;
        private Button btnBack;
    }
}