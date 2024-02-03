namespace car_wash
{
    partial class Employer
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            dgvemployeer = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column10 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewImageColumn();
            Delete = new DataGridViewImageColumn();
            panel1 = new Panel();
            btnadd = new Button();
            txtsearch = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvemployeer).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // dgvemployeer
            // 
            dgvemployeer.AllowUserToAddRows = false;
            dgvemployeer.AllowUserToDeleteRows = false;
            dgvemployeer.AllowUserToResizeColumns = false;
            dgvemployeer.BackgroundColor = Color.White;
            dgvemployeer.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 205, 219);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvemployeer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvemployeer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvemployeer.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column10, Column6, Column7, Column8, Column9, Edit, Delete });
            dgvemployeer.Dock = DockStyle.Top;
            dgvemployeer.EnableHeadersVisualStyles = false;
            dgvemployeer.Location = new Point(0, 0);
            dgvemployeer.Name = "dgvemployeer";
            dgvemployeer.RowHeadersVisible = false;
            dgvemployeer.RowTemplate.Height = 25;
            dgvemployeer.Size = new Size(951, 382);
            dgvemployeer.TabIndex = 0;
            dgvemployeer.CellContentClick += dgvemployeer_CellContentClick;
            // 
            // Column1
            // 
            Column1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column1.HeaderText = "No";
            Column1.Name = "Column1";
            Column1.Width = 53;
            // 
            // Column2
            // 
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column2.HeaderText = "Id";
            Column2.Name = "Column2";
            Column2.Width = 47;
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Name";
            Column3.Name = "Column3";
            Column3.Width = 76;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Phone";
            Column4.Name = "Column4";
            Column4.Width = 79;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column5.HeaderText = "Address";
            Column5.Name = "Column5";
            // 
            // Column10
            // 
            Column10.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column10.HeaderText = "Date of Birth";
            Column10.Name = "Column10";
            Column10.Width = 122;
            // 
            // Column6
            // 
            Column6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column6.HeaderText = "Gender";
            Column6.Name = "Column6";
            Column6.Width = 89;
            // 
            // Column7
            // 
            Column7.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column7.HeaderText = "Role";
            Column7.Name = "Column7";
            Column7.Width = 64;
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            Column8.DefaultCellStyle = dataGridViewCellStyle2;
            Column8.HeaderText = "Salary";
            Column8.Name = "Column8";
            Column8.Width = 75;
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "Password";
            Column9.Name = "Column9";
            Column9.Width = 102;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "";
            Edit.Image = Properties.Resources.edit;
            Edit.Name = "Edit";
            Edit.Width = 5;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "";
            Delete.Image = Properties.Resources.delete;
            Delete.Name = "Delete";
            Delete.Width = 5;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(15, 205, 219);
            panel1.Controls.Add(btnadd);
            panel1.Controls.Add(txtsearch);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 382);
            panel1.Name = "panel1";
            panel1.Size = new Size(951, 64);
            panel1.TabIndex = 1;
            // 
            // btnadd
            // 
            btnadd.FlatAppearance.BorderSize = 0;
            btnadd.FlatStyle = FlatStyle.Flat;
            btnadd.Image = Properties.Resources.add_user__1_;
            btnadd.Location = new Point(894, 0);
            btnadd.Name = "btnadd";
            btnadd.Size = new Size(45, 45);
            btnadd.TabIndex = 2;
            btnadd.UseVisualStyleBackColor = true;
            btnadd.Click += btnadd_Click;
            // 
            // txtsearch
            // 
            txtsearch.Location = new Point(78, 16);
            txtsearch.Name = "txtsearch";
            txtsearch.Size = new Size(175, 26);
            txtsearch.TabIndex = 1;
            txtsearch.TextChanged += txtsearch_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // Employer
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(951, 446);
            Controls.Add(panel1);
            Controls.Add(dgvemployeer);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Employer";
            Text = "Employer";
            ((System.ComponentModel.ISupportInitialize)dgvemployeer).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvemployeer;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column10;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
        private Panel panel1;
        private Button btnadd;
        private TextBox txtsearch;
        private Label label1;
    }
}