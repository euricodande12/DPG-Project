namespace NoahsArk
{
    partial class ParentChildList
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            btnLogout = new Button();
            tblParentsAndChildren = new DataGridView();
            lblListOfParentsAndTheirRespectiveChildren = new Label();
            btnParentsAndChildren = new Button();
            btnCreateOrEditClass = new Button();
            btnClassList = new Button();
            label2 = new Label();
            btnDropOff = new Button();
            btnPickUp = new Button();
            btnDropOffList = new Button();
            btnPickUpList = new Button();
            btnEditParent = new Button();
            ((System.ComponentModel.ISupportInitialize)tblParentsAndChildren).BeginInit();
            SuspendLayout();
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(23, 530);
            btnLogout.Margin = new Padding(2, 4, 2, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(818, 32);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // tblParentsAndChildren
            // 
            tblParentsAndChildren.AllowUserToAddRows = false;
            tblParentsAndChildren.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tblParentsAndChildren.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            tblParentsAndChildren.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tblParentsAndChildren.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tblParentsAndChildren.Location = new Point(23, 111);
            tblParentsAndChildren.Margin = new Padding(2, 4, 2, 4);
            tblParentsAndChildren.Name = "tblParentsAndChildren";
            tblParentsAndChildren.ReadOnly = true;
            tblParentsAndChildren.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            tblParentsAndChildren.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            tblParentsAndChildren.RowTemplate.DefaultCellStyle.Padding = new Padding(3, 2, 3, 3);
            tblParentsAndChildren.RowTemplate.ReadOnly = true;
            tblParentsAndChildren.RowTemplate.Resizable = DataGridViewTriState.False;
            tblParentsAndChildren.Size = new Size(818, 392);
            tblParentsAndChildren.TabIndex = 2;
            // 
            // lblListOfParentsAndTheirRespectiveChildren
            // 
            lblListOfParentsAndTheirRespectiveChildren.AutoSize = true;
            lblListOfParentsAndTheirRespectiveChildren.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblListOfParentsAndTheirRespectiveChildren.ForeColor = SystemColors.ControlDark;
            lblListOfParentsAndTheirRespectiveChildren.Location = new Point(263, 64);
            lblListOfParentsAndTheirRespectiveChildren.Margin = new Padding(2, 0, 2, 0);
            lblListOfParentsAndTheirRespectiveChildren.Name = "lblListOfParentsAndTheirRespectiveChildren";
            lblListOfParentsAndTheirRespectiveChildren.Size = new Size(321, 25);
            lblListOfParentsAndTheirRespectiveChildren.TabIndex = 3;
            lblListOfParentsAndTheirRespectiveChildren.Text = "List of parents and their respective children";
            // 
            // btnParentsAndChildren
            // 
            btnParentsAndChildren.Cursor = Cursors.Hand;
            btnParentsAndChildren.FlatAppearance.BorderSize = 0;
            btnParentsAndChildren.FlatStyle = FlatStyle.Flat;
            btnParentsAndChildren.Font = new Font("Bahnschrift Condensed", 12F);
            btnParentsAndChildren.ForeColor = SystemColors.ControlDarkDark;
            btnParentsAndChildren.Location = new Point(14, 14);
            btnParentsAndChildren.Margin = new Padding(4);
            btnParentsAndChildren.Name = "btnParentsAndChildren";
            btnParentsAndChildren.Size = new Size(155, 31);
            btnParentsAndChildren.TabIndex = 4;
            btnParentsAndChildren.Text = "Parents and Children List";
            btnParentsAndChildren.UseVisualStyleBackColor = true;
            // 
            // btnCreateOrEditClass
            // 
            btnCreateOrEditClass.Cursor = Cursors.Hand;
            btnCreateOrEditClass.FlatAppearance.BorderSize = 0;
            btnCreateOrEditClass.FlatStyle = FlatStyle.Flat;
            btnCreateOrEditClass.Font = new Font("Bahnschrift Condensed", 12F);
            btnCreateOrEditClass.ForeColor = SystemColors.ControlDarkDark;
            btnCreateOrEditClass.Location = new Point(177, 13);
            btnCreateOrEditClass.Margin = new Padding(4);
            btnCreateOrEditClass.Name = "btnCreateOrEditClass";
            btnCreateOrEditClass.Size = new Size(119, 31);
            btnCreateOrEditClass.TabIndex = 5;
            btnCreateOrEditClass.Text = "Create / Edit Class";
            btnCreateOrEditClass.UseVisualStyleBackColor = true;
            btnCreateOrEditClass.Click += btnCreateOrEditClass_Click;
            // 
            // btnClassList
            // 
            btnClassList.Cursor = Cursors.Hand;
            btnClassList.FlatAppearance.BorderSize = 0;
            btnClassList.FlatStyle = FlatStyle.Flat;
            btnClassList.Font = new Font("Bahnschrift Condensed", 12F);
            btnClassList.ForeColor = SystemColors.ControlDarkDark;
            btnClassList.Location = new Point(311, 13);
            btnClassList.Margin = new Padding(4);
            btnClassList.Name = "btnClassList";
            btnClassList.Size = new Size(70, 31);
            btnClassList.TabIndex = 6;
            btnClassList.Text = "Class List";
            btnClassList.UseVisualStyleBackColor = true;
            btnClassList.Click += btnClassList_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(386, 45);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(0, 19);
            label2.TabIndex = 7;
            // 
            // btnDropOff
            // 
            btnDropOff.Cursor = Cursors.Hand;
            btnDropOff.FlatAppearance.BorderSize = 0;
            btnDropOff.FlatStyle = FlatStyle.Flat;
            btnDropOff.ForeColor = SystemColors.ControlDarkDark;
            btnDropOff.Location = new Point(398, 15);
            btnDropOff.Margin = new Padding(4);
            btnDropOff.Name = "btnDropOff";
            btnDropOff.Size = new Size(60, 27);
            btnDropOff.TabIndex = 13;
            btnDropOff.Text = "Drop Off";
            btnDropOff.UseVisualStyleBackColor = true;
            btnDropOff.Click += btnDropOff_Click;
            // 
            // btnPickUp
            // 
            btnPickUp.Cursor = Cursors.Hand;
            btnPickUp.FlatAppearance.BorderSize = 0;
            btnPickUp.FlatStyle = FlatStyle.Flat;
            btnPickUp.ForeColor = SystemColors.ControlDarkDark;
            btnPickUp.Location = new Point(474, 17);
            btnPickUp.Margin = new Padding(4);
            btnPickUp.Name = "btnPickUp";
            btnPickUp.Size = new Size(55, 27);
            btnPickUp.TabIndex = 14;
            btnPickUp.Text = "Pick Up";
            btnPickUp.UseVisualStyleBackColor = true;
            btnPickUp.Click += btnPickUp_Click;
            // 
            // btnDropOffList
            // 
            btnDropOffList.Cursor = Cursors.Hand;
            btnDropOffList.FlatAppearance.BorderSize = 0;
            btnDropOffList.FlatStyle = FlatStyle.Flat;
            btnDropOffList.ForeColor = SystemColors.ControlDarkDark;
            btnDropOffList.Location = new Point(544, 16);
            btnDropOffList.Margin = new Padding(4);
            btnDropOffList.Name = "btnDropOffList";
            btnDropOffList.Size = new Size(83, 27);
            btnDropOffList.TabIndex = 15;
            btnDropOffList.Text = "Drop Off List";
            btnDropOffList.UseVisualStyleBackColor = true;
            btnDropOffList.Click += btnDropOffList_Click;
            // 
            // btnPickUpList
            // 
            btnPickUpList.Cursor = Cursors.Hand;
            btnPickUpList.FlatAppearance.BorderSize = 0;
            btnPickUpList.FlatStyle = FlatStyle.Flat;
            btnPickUpList.ForeColor = SystemColors.ControlDarkDark;
            btnPickUpList.Location = new Point(638, 16);
            btnPickUpList.Margin = new Padding(4);
            btnPickUpList.Name = "btnPickUpList";
            btnPickUpList.Size = new Size(78, 27);
            btnPickUpList.TabIndex = 16;
            btnPickUpList.Text = "Pick Up List";
            btnPickUpList.UseVisualStyleBackColor = true;
            btnPickUpList.Click += btnPickUpList_Click;
            // 
            // btnEditParent
            // 
            btnEditParent.Cursor = Cursors.Hand;
            btnEditParent.FlatAppearance.BorderSize = 0;
            btnEditParent.FlatStyle = FlatStyle.Flat;
            btnEditParent.ForeColor = SystemColors.ControlDarkDark;
            btnEditParent.Location = new Point(728, 16);
            btnEditParent.Margin = new Padding(4);
            btnEditParent.Name = "btnEditParent";
            btnEditParent.Size = new Size(113, 27);
            btnEditParent.TabIndex = 17;
            btnEditParent.Text = "Edit Parent / Child";
            btnEditParent.UseVisualStyleBackColor = true;
            btnEditParent.Click += btnEditParent_Click;
            // 
            // ParentChildList
            // 
            AutoScaleDimensions = new SizeF(6F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(866, 585);
            Controls.Add(btnEditParent);
            Controls.Add(btnPickUpList);
            Controls.Add(btnDropOffList);
            Controls.Add(btnPickUp);
            Controls.Add(btnDropOff);
            Controls.Add(label2);
            Controls.Add(btnClassList);
            Controls.Add(btnCreateOrEditClass);
            Controls.Add(btnParentsAndChildren);
            Controls.Add(lblListOfParentsAndTheirRespectiveChildren);
            Controls.Add(tblParentsAndChildren);
            Controls.Add(btnLogout);
            Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(2, 4, 2, 4);
            MaximizeBox = false;
            Name = "ParentChildList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "List of parents and their respective children";
            FormClosing += ParentChildList_FormClosing;
            ((System.ComponentModel.ISupportInitialize)tblParentsAndChildren).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogout;
        private DataGridView tblParentsAndChildren;
        private Label lblListOfParentsAndTheirRespectiveChildren;
        private Button btnParentsAndChildren;
        private Button btnCreateOrEditClass;
        private Button btnClassList;
        private Label label2;
        private Button btnDropOff;
        private Button btnPickUp;
        private Button btnDropOffList;
        private Button btnPickUpList;
        private Button btnEditParent;
    }
}