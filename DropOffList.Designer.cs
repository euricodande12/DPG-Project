namespace NoahsArk
{
    partial class DropOffList
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
            lblTodaysDropOffList = new Label();
            dgvTodaysDropOffList = new DataGridView();
            btnBack = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvTodaysDropOffList).BeginInit();
            SuspendLayout();
            // 
            // lblTodaysDropOffList
            // 
            lblTodaysDropOffList.AutoSize = true;
            lblTodaysDropOffList.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTodaysDropOffList.ForeColor = SystemColors.ControlDark;
            lblTodaysDropOffList.Location = new Point(21, 23);
            lblTodaysDropOffList.Margin = new Padding(2, 0, 2, 0);
            lblTodaysDropOffList.Name = "lblTodaysDropOffList";
            lblTodaysDropOffList.Size = new Size(151, 25);
            lblTodaysDropOffList.TabIndex = 5;
            lblTodaysDropOffList.Text = "Today's Drop Off List";
            // 
            // dgvTodaysDropOffList
            // 
            dgvTodaysDropOffList.AllowUserToAddRows = false;
            dgvTodaysDropOffList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTodaysDropOffList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvTodaysDropOffList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodaysDropOffList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodaysDropOffList.Location = new Point(21, 81);
            dgvTodaysDropOffList.Margin = new Padding(2, 5, 2, 5);
            dgvTodaysDropOffList.Name = "dgvTodaysDropOffList";
            dgvTodaysDropOffList.ReadOnly = true;
            dgvTodaysDropOffList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvTodaysDropOffList.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTodaysDropOffList.RowTemplate.DefaultCellStyle.Padding = new Padding(3, 2, 3, 3);
            dgvTodaysDropOffList.RowTemplate.ReadOnly = true;
            dgvTodaysDropOffList.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvTodaysDropOffList.Size = new Size(1034, 497);
            dgvTodaysDropOffList.TabIndex = 4;
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1007, 23);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 32);
            btnBack.TabIndex = 6;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // DropOffList
            // 
            AutoScaleDimensions = new SizeF(6F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1084, 605);
            Controls.Add(btnBack);
            Controls.Add(lblTodaysDropOffList);
            Controls.Add(dgvTodaysDropOffList);
            Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "DropOffList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DropOffList";
            FormClosing += DropOffList_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvTodaysDropOffList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTodaysDropOffList;
        private DataGridView dgvTodaysDropOffList;
        private Button btnBack;
    }
}