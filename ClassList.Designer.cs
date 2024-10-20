namespace NoahsArk
{
    partial class ClassList
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
            dgvClassListTable = new DataGridView();
            label1 = new Label();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvClassListTable).BeginInit();
            SuspendLayout();
            // 
            // dgvClassListTable
            // 
            dgvClassListTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvClassListTable.Location = new Point(19, 82);
            dgvClassListTable.Margin = new Padding(3, 4, 3, 4);
            dgvClassListTable.Name = "dgvClassListTable";
            dgvClassListTable.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvClassListTable.Size = new Size(144, 234);
            dgvClassListTable.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ControlDark;
            label1.Location = new Point(19, 29);
            label1.Name = "label1";
            label1.Size = new Size(91, 29);
            label1.TabIndex = 1;
            label1.Text = "Class List";
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.Location = new Point(114, 32);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(49, 28);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // ClassList
            // 
            AutoScaleDimensions = new SizeF(6F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(184, 338);
            Controls.Add(btnBack);
            Controls.Add(label1);
            Controls.Add(dgvClassListTable);
            Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "ClassList";
            StartPosition = FormStartPosition.CenterScreen;
            FormClosing += ClassList_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvClassListTable).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvClassListTable;
        private Label label1;
        private Button btnBack;
    }
}