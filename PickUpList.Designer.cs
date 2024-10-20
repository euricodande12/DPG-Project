namespace NoahsArk
{
    partial class PickUpList
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            btnBack = new Button();
            lblTodaysPickUpList = new Label();
            dgvTodaysPickUpList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvTodaysPickUpList).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Cursor = Cursors.Hand;
            btnBack.Font = new Font("Bahnschrift Condensed", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnBack.Location = new Point(1007, 25);
            btnBack.Margin = new Padding(3, 4, 3, 4);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 32);
            btnBack.TabIndex = 9;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblTodaysPickUpList
            // 
            lblTodaysPickUpList.AutoSize = true;
            lblTodaysPickUpList.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTodaysPickUpList.ForeColor = SystemColors.ControlDark;
            lblTodaysPickUpList.Location = new Point(20, 25);
            lblTodaysPickUpList.Margin = new Padding(2, 0, 2, 0);
            lblTodaysPickUpList.Name = "lblTodaysPickUpList";
            lblTodaysPickUpList.Size = new Size(146, 25);
            lblTodaysPickUpList.TabIndex = 8;
            lblTodaysPickUpList.Text = "Today's Pick Up List";
            // 
            // dgvTodaysPickUpList
            // 
            dgvTodaysPickUpList.AllowUserToAddRows = false;
            dgvTodaysPickUpList.AllowUserToDeleteRows = false;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTodaysPickUpList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            dgvTodaysPickUpList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTodaysPickUpList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTodaysPickUpList.Location = new Point(29, 84);
            dgvTodaysPickUpList.Margin = new Padding(2, 5, 2, 5);
            dgvTodaysPickUpList.Name = "dgvTodaysPickUpList";
            dgvTodaysPickUpList.ReadOnly = true;
            dgvTodaysPickUpList.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dgvTodaysPickUpList.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvTodaysPickUpList.RowTemplate.DefaultCellStyle.Padding = new Padding(3, 2, 3, 3);
            dgvTodaysPickUpList.RowTemplate.ReadOnly = true;
            dgvTodaysPickUpList.RowTemplate.Resizable = DataGridViewTriState.False;
            dgvTodaysPickUpList.Size = new Size(1026, 497);
            dgvTodaysPickUpList.TabIndex = 7;
            // 
            // PickUpList
            // 
            AutoScaleDimensions = new SizeF(6F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1083, 605);
            Controls.Add(btnBack);
            Controls.Add(lblTodaysPickUpList);
            Controls.Add(dgvTodaysPickUpList);
            Font = new Font("Bahnschrift Condensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Margin = new Padding(3, 4, 3, 4);
            Name = "PickUpList";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "PickUpList";
            FormClosing += PickUpList_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dgvTodaysPickUpList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblTodaysPickUpList;
        private DataGridView dgvTodaysPickUpList;
    }
}