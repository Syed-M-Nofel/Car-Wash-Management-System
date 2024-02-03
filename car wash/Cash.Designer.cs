namespace car_wash
{
    partial class Cash
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
            panel1 = new Panel();
            btnaddservice = new Button();
            btnaddcustomer = new Button();
            panel2 = new Panel();
            lbltotal = new Label();
            lbltransno = new Label();
            label2 = new Label();
            label1 = new Label();
            btncash = new Button();
            panelcashC = new Panel();
            panel4 = new Panel();
            dgvcash = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            Column7 = new DataGridViewTextBoxColumn();
            Column8 = new DataGridViewTextBoxColumn();
            Column9 = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcash).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnaddservice);
            panel1.Controls.Add(btnaddcustomer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(900, 43);
            panel1.TabIndex = 0;
            // 
            // btnaddservice
            // 
            btnaddservice.FlatAppearance.BorderSize = 0;
            btnaddservice.FlatStyle = FlatStyle.Flat;
            btnaddservice.Image = Properties.Resources.car_service;
            btnaddservice.ImageAlign = ContentAlignment.MiddleLeft;
            btnaddservice.Location = new Point(142, 0);
            btnaddservice.Name = "btnaddservice";
            btnaddservice.Size = new Size(136, 40);
            btnaddservice.TabIndex = 39;
            btnaddservice.Text = "Service";
            btnaddservice.UseVisualStyleBackColor = true;
            btnaddservice.Click += btnaddservice_Click_1;
            // 
            // btnaddcustomer
            // 
            btnaddcustomer.FlatAppearance.BorderSize = 0;
            btnaddcustomer.FlatStyle = FlatStyle.Flat;
            btnaddcustomer.Image = Properties.Resources.add_user__1_;
            btnaddcustomer.ImageAlign = ContentAlignment.MiddleLeft;
            btnaddcustomer.Location = new Point(0, 0);
            btnaddcustomer.Name = "btnaddcustomer";
            btnaddcustomer.Size = new Size(136, 40);
            btnaddcustomer.TabIndex = 38;
            btnaddcustomer.Text = "Customer";
            btnaddcustomer.UseVisualStyleBackColor = true;
            btnaddcustomer.Click += btnaddcustomer_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(lbltotal);
            panel2.Controls.Add(lbltransno);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btncash);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 404);
            panel2.Name = "panel2";
            panel2.Size = new Size(900, 46);
            panel2.TabIndex = 1;
            // 
            // lbltotal
            // 
            lbltotal.AutoSize = true;
            lbltotal.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lbltotal.Location = new Point(669, 13);
            lbltotal.Name = "lbltotal";
            lbltotal.Size = new Size(40, 20);
            lbltotal.TabIndex = 44;
            lbltotal.Text = "0.00";
            // 
            // lbltransno
            // 
            lbltransno.AutoSize = true;
            lbltransno.Location = new Point(142, 13);
            lbltransno.Name = "lbltransno";
            lbltransno.Size = new Size(61, 15);
            lbltransno.TabIndex = 43;
            lbltransno.Text = "000000000";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(442, 13);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 42;
            label2.Text = "Total Price :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 13);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 41;
            label1.Text = "Transaction no:";
            // 
            // btncash
            // 
            btncash.FlatAppearance.BorderSize = 0;
            btncash.FlatStyle = FlatStyle.Flat;
            btncash.Image = Properties.Resources.money_flow1;
            btncash.ImageAlign = ContentAlignment.MiddleLeft;
            btncash.Location = new Point(798, 0);
            btncash.Name = "btncash";
            btncash.Size = new Size(102, 40);
            btncash.TabIndex = 40;
            btncash.Text = "Cash";
            btncash.UseVisualStyleBackColor = true;
            btncash.Click += btncash_Click;
            // 
            // panelcashC
            // 
            panelcashC.Dock = DockStyle.Top;
            panelcashC.Location = new Point(0, 43);
            panelcashC.Name = "panelcashC";
            panelcashC.Size = new Size(900, 1);
            panelcashC.TabIndex = 2;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(193, 0, 55);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 44);
            panel4.Name = "panel4";
            panel4.Size = new Size(900, 15);
            panel4.TabIndex = 36;
            // 
            // dgvcash
            // 
            dgvcash.AllowUserToAddRows = false;
            dgvcash.AllowUserToDeleteRows = false;
            dgvcash.AllowUserToResizeColumns = false;
            dgvcash.BackgroundColor = Color.White;
            dgvcash.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 205, 219);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvcash.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvcash.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcash.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6, Column7, Column8, Column9 });
            dgvcash.Dock = DockStyle.Fill;
            dgvcash.EnableHeadersVisualStyles = false;
            dgvcash.Location = new Point(0, 59);
            dgvcash.Name = "dgvcash";
            dgvcash.RowHeadersVisible = false;
            dgvcash.RowTemplate.Height = 25;
            dgvcash.Size = new Size(900, 345);
            dgvcash.TabIndex = 37;
            dgvcash.CellContentClick += dgvcash_CellContentClick_1;
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
            Column5.HeaderText = "Car no";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "Car Model";
            Column6.Name = "Column6";
            // 
            // Column7
            // 
            Column7.HeaderText = "Car Type";
            Column7.Name = "Column7";
            // 
            // Column8
            // 
            Column8.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column8.HeaderText = "Address";
            Column8.Name = "Column8";
            // 
            // Column9
            // 
            Column9.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column9.HeaderText = "Points";
            Column9.Name = "Column9";
            Column9.Width = 74;
            // 
            // Cash
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(900, 450);
            Controls.Add(dgvcash);
            Controls.Add(panel4);
            Controls.Add(panelcashC);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Cash";
            Text = "Cash";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcash).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel4;
        private Label label2;
        private Label label1;
        public Panel panelcashC;
        public DataGridView dgvcash;
        public Button btnaddservice;
        public Button btnaddcustomer;
        public Label lbltotal;
        public Label lbltransno;
        public Button btncash;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
    }
}