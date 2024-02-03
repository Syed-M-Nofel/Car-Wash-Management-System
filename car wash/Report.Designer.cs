namespace car_wash
{
    partial class Report
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            dgvtopselling = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            dttotopselling = new DateTimePicker();
            label2 = new Label();
            dtfromtopselling = new DateTimePicker();
            label1 = new Label();
            tabPage2 = new TabPage();
            dgvrevenus = new DataGridView();
            dataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn3 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn4 = new DataGridViewTextBoxColumn();
            panel3 = new Panel();
            lblrevenus = new Label();
            label5 = new Label();
            dttorevenus = new DateTimePicker();
            label3 = new Label();
            dtfromrevenus = new DateTimePicker();
            label4 = new Label();
            tabPage3 = new TabPage();
            dgvcost = new DataGridView();
            dataGridViewTextBoxColumn2 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn5 = new DataGridViewTextBoxColumn();
            dataGridViewTextBoxColumn6 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            panel4 = new Panel();
            lblcost = new Label();
            label7 = new Label();
            dttocost = new DateTimePicker();
            label8 = new Label();
            dtfromcost = new DateTimePicker();
            label9 = new Label();
            tabPage4 = new TabPage();
            txtgrossprofit = new TextBox();
            txtcog = new TextBox();
            txtrevenus = new TextBox();
            pictureBox3 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            label13 = new Label();
            label10 = new Label();
            label6 = new Label();
            panel5 = new Panel();
            dttogross = new DateTimePicker();
            label11 = new Label();
            dtfromgross = new DateTimePicker();
            label12 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvtopselling).BeginInit();
            panel2.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvrevenus).BeginInit();
            panel3.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvcost).BeginInit();
            panel4.SuspendLayout();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(193, 0, 55);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(967, 27);
            panel1.TabIndex = 2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 27);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(967, 458);
            tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(dgvtopselling);
            tabPage1.Controls.Add(panel2);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(959, 430);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Top Selling";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvtopselling
            // 
            dgvtopselling.AllowUserToAddRows = false;
            dgvtopselling.AllowUserToDeleteRows = false;
            dgvtopselling.AllowUserToResizeColumns = false;
            dgvtopselling.BackgroundColor = Color.White;
            dgvtopselling.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(15, 205, 219);
            dataGridViewCellStyle1.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvtopselling.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvtopselling.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvtopselling.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvtopselling.Dock = DockStyle.Fill;
            dgvtopselling.EnableHeadersVisualStyles = false;
            dgvtopselling.Location = new Point(3, 47);
            dgvtopselling.Name = "dgvtopselling";
            dgvtopselling.RowHeadersVisible = false;
            dgvtopselling.RowTemplate.Height = 25;
            dgvtopselling.Size = new Size(953, 380);
            dgvtopselling.TabIndex = 4;
            dgvtopselling.CellContentClick += dgvtopselling_CellContentClick;
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
            Column2.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Column2.HeaderText = "Service Name";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column3.HeaderText = "Quantity";
            Column3.Name = "Column3";
            Column3.Width = 94;
            // 
            // Column4
            // 
            Column4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column4.HeaderText = "Price";
            Column4.Name = "Column4";
            Column4.Width = 69;
            // 
            // panel2
            // 
            panel2.Controls.Add(dttotopselling);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(dtfromtopselling);
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(953, 44);
            panel2.TabIndex = 0;
            // 
            // dttotopselling
            // 
            dttotopselling.CustomFormat = "dd/MM/yyyy";
            dttotopselling.Format = DateTimePickerFormat.Custom;
            dttotopselling.Location = new Point(231, 9);
            dttotopselling.Name = "dttotopselling";
            dttotopselling.Size = new Size(98, 23);
            dttotopselling.TabIndex = 3;
            dttotopselling.ValueChanged += dttotopselling_ValueChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(203, 15);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 2;
            label2.Text = "To:";
            // 
            // dtfromtopselling
            // 
            dtfromtopselling.CustomFormat = "dd/MM/yyyy";
            dtfromtopselling.Format = DateTimePickerFormat.Custom;
            dtfromtopselling.Location = new Point(99, 9);
            dtfromtopselling.Name = "dtfromtopselling";
            dtfromtopselling.Size = new Size(98, 23);
            dtfromtopselling.TabIndex = 1;
            dtfromtopselling.ValueChanged += dtfromtopselling_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 15);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 0;
            label1.Text = "Filter by: From";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(dgvrevenus);
            tabPage2.Controls.Add(panel3);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(959, 430);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Revenus";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvrevenus
            // 
            dgvrevenus.AllowUserToAddRows = false;
            dgvrevenus.AllowUserToDeleteRows = false;
            dgvrevenus.AllowUserToResizeColumns = false;
            dgvrevenus.BackgroundColor = Color.White;
            dgvrevenus.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(15, 205, 219);
            dataGridViewCellStyle2.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvrevenus.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvrevenus.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvrevenus.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn1, dataGridViewTextBoxColumn3, dataGridViewTextBoxColumn4 });
            dgvrevenus.Dock = DockStyle.Fill;
            dgvrevenus.EnableHeadersVisualStyles = false;
            dgvrevenus.Location = new Point(3, 47);
            dgvrevenus.Name = "dgvrevenus";
            dgvrevenus.RowHeadersVisible = false;
            dgvrevenus.RowTemplate.Height = 25;
            dgvrevenus.Size = new Size(953, 380);
            dgvrevenus.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            dataGridViewTextBoxColumn1.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn1.HeaderText = "No";
            dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            dataGridViewTextBoxColumn1.Width = 53;
            // 
            // dataGridViewTextBoxColumn3
            // 
            dataGridViewTextBoxColumn3.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn3.HeaderText = "Date";
            dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            dataGridViewTextBoxColumn4.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn4.HeaderText = "Price";
            dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            dataGridViewTextBoxColumn4.Width = 69;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblrevenus);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(dttorevenus);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(dtfromrevenus);
            panel3.Controls.Add(label4);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(953, 44);
            panel3.TabIndex = 1;
            // 
            // lblrevenus
            // 
            lblrevenus.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblrevenus.Location = new Point(840, 12);
            lblrevenus.Name = "lblrevenus";
            lblrevenus.Size = new Size(110, 20);
            lblrevenus.TabIndex = 11;
            lblrevenus.Text = "0.00";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(748, 12);
            label5.Name = "label5";
            label5.Size = new Size(86, 20);
            label5.TabIndex = 10;
            label5.Text = "Total Price:";
            // 
            // dttorevenus
            // 
            dttorevenus.CustomFormat = "dd/MM/yyyy";
            dttorevenus.Format = DateTimePickerFormat.Custom;
            dttorevenus.Location = new Point(231, 9);
            dttorevenus.Name = "dttorevenus";
            dttorevenus.Size = new Size(98, 23);
            dttorevenus.TabIndex = 3;
            dttorevenus.ValueChanged += dttorevenus_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(203, 15);
            label3.Name = "label3";
            label3.Size = new Size(22, 15);
            label3.TabIndex = 2;
            label3.Text = "To:";
            // 
            // dtfromrevenus
            // 
            dtfromrevenus.CustomFormat = "dd/MM/yyyy";
            dtfromrevenus.Format = DateTimePickerFormat.Custom;
            dtfromrevenus.Location = new Point(99, 9);
            dtfromrevenus.Name = "dtfromrevenus";
            dtfromrevenus.Size = new Size(98, 23);
            dtfromrevenus.TabIndex = 1;
            dtfromrevenus.ValueChanged += dtfromrevenus_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 15);
            label4.Name = "label4";
            label4.Size = new Size(83, 15);
            label4.TabIndex = 0;
            label4.Text = "Filter by: From";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(dgvcost);
            tabPage3.Controls.Add(panel4);
            tabPage3.Location = new Point(4, 24);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(959, 430);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Cost of Good Sold";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvcost
            // 
            dgvcost.AllowUserToAddRows = false;
            dgvcost.AllowUserToDeleteRows = false;
            dgvcost.AllowUserToResizeColumns = false;
            dgvcost.BackgroundColor = Color.White;
            dgvcost.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(15, 205, 219);
            dataGridViewCellStyle3.Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvcost.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvcost.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvcost.Columns.AddRange(new DataGridViewColumn[] { dataGridViewTextBoxColumn2, dataGridViewTextBoxColumn5, dataGridViewTextBoxColumn6, Column5 });
            dgvcost.Dock = DockStyle.Fill;
            dgvcost.EnableHeadersVisualStyles = false;
            dgvcost.Location = new Point(0, 44);
            dgvcost.Name = "dgvcost";
            dgvcost.RowHeadersVisible = false;
            dgvcost.RowTemplate.Height = 25;
            dgvcost.Size = new Size(959, 386);
            dgvcost.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn2
            // 
            dataGridViewTextBoxColumn2.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn2.HeaderText = "No";
            dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            dataGridViewTextBoxColumn2.Width = 53;
            // 
            // dataGridViewTextBoxColumn5
            // 
            dataGridViewTextBoxColumn5.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewTextBoxColumn5.HeaderText = "Cost of dood sold";
            dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            dataGridViewTextBoxColumn6.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewTextBoxColumn6.HeaderText = "Price";
            dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            dataGridViewTextBoxColumn6.Width = 69;
            // 
            // Column5
            // 
            Column5.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Column5.HeaderText = "Date";
            Column5.Name = "Column5";
            Column5.Width = 68;
            // 
            // panel4
            // 
            panel4.Controls.Add(lblcost);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(dttocost);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(dtfromcost);
            panel4.Controls.Add(label9);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(0, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(959, 44);
            panel4.TabIndex = 2;
            // 
            // lblcost
            // 
            lblcost.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblcost.Location = new Point(840, 12);
            lblcost.Name = "lblcost";
            lblcost.Size = new Size(110, 20);
            lblcost.TabIndex = 11;
            lblcost.Text = "0.00";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(748, 12);
            label7.Name = "label7";
            label7.Size = new Size(86, 20);
            label7.TabIndex = 10;
            label7.Text = "Total Price:";
            // 
            // dttocost
            // 
            dttocost.CustomFormat = "dd/MM/yyyy";
            dttocost.Format = DateTimePickerFormat.Custom;
            dttocost.Location = new Point(231, 9);
            dttocost.Name = "dttocost";
            dttocost.Size = new Size(98, 23);
            dttocost.TabIndex = 3;
            dttocost.ValueChanged += dttocost_ValueChanged;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(203, 15);
            label8.Name = "label8";
            label8.Size = new Size(22, 15);
            label8.TabIndex = 2;
            label8.Text = "To:";
            // 
            // dtfromcost
            // 
            dtfromcost.CustomFormat = "dd/MM/yyyy";
            dtfromcost.Format = DateTimePickerFormat.Custom;
            dtfromcost.Location = new Point(99, 9);
            dtfromcost.Name = "dtfromcost";
            dtfromcost.Size = new Size(98, 23);
            dtfromcost.TabIndex = 1;
            dtfromcost.ValueChanged += dtfromcost_ValueChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(10, 15);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 0;
            label9.Text = "Filter by: From";
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(txtgrossprofit);
            tabPage4.Controls.Add(txtcog);
            tabPage4.Controls.Add(txtrevenus);
            tabPage4.Controls.Add(pictureBox3);
            tabPage4.Controls.Add(pictureBox2);
            tabPage4.Controls.Add(pictureBox1);
            tabPage4.Controls.Add(label13);
            tabPage4.Controls.Add(label10);
            tabPage4.Controls.Add(label6);
            tabPage4.Controls.Add(panel5);
            tabPage4.Location = new Point(4, 24);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(959, 430);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Gross Profit";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // txtgrossprofit
            // 
            txtgrossprofit.Location = new Point(524, 211);
            txtgrossprofit.Name = "txtgrossprofit";
            txtgrossprofit.Size = new Size(285, 23);
            txtgrossprofit.TabIndex = 12;
            txtgrossprofit.TextAlign = HorizontalAlignment.Right;
            // 
            // txtcog
            // 
            txtcog.Location = new Point(524, 152);
            txtcog.Name = "txtcog";
            txtcog.Size = new Size(285, 23);
            txtcog.TabIndex = 11;
            txtcog.TextAlign = HorizontalAlignment.Right;
            // 
            // txtrevenus
            // 
            txtrevenus.Location = new Point(524, 93);
            txtrevenus.Name = "txtrevenus";
            txtrevenus.Size = new Size(285, 23);
            txtrevenus.TabIndex = 10;
            txtrevenus.TextAlign = HorizontalAlignment.Right;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.profits;
            pictureBox3.Location = new Point(203, 194);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(40, 40);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.withdrawal;
            pictureBox2.Location = new Point(203, 142);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.sales;
            pictureBox1.Location = new Point(203, 85);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(297, 214);
            label13.Name = "label13";
            label13.Size = new Size(97, 20);
            label13.TabIndex = 6;
            label13.Text = "Gross Profit:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(297, 152);
            label10.Name = "label10";
            label10.Size = new Size(139, 20);
            label10.TabIndex = 5;
            label10.Text = "Cost of Good Sold:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(297, 95);
            label6.Name = "label6";
            label6.Size = new Size(72, 20);
            label6.TabIndex = 4;
            label6.Text = "Revenus:";
            // 
            // panel5
            // 
            panel5.Controls.Add(dttogross);
            panel5.Controls.Add(label11);
            panel5.Controls.Add(dtfromgross);
            panel5.Controls.Add(label12);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(959, 44);
            panel5.TabIndex = 3;
            // 
            // dttogross
            // 
            dttogross.CustomFormat = "dd/MM/yyyy";
            dttogross.Format = DateTimePickerFormat.Custom;
            dttogross.Location = new Point(231, 9);
            dttogross.Name = "dttogross";
            dttogross.Size = new Size(98, 23);
            dttogross.TabIndex = 3;
            dttogross.ValueChanged += dttogross_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(203, 15);
            label11.Name = "label11";
            label11.Size = new Size(22, 15);
            label11.TabIndex = 2;
            label11.Text = "To:";
            // 
            // dtfromgross
            // 
            dtfromgross.CustomFormat = "dd/MM/yyyy";
            dtfromgross.Format = DateTimePickerFormat.Custom;
            dtfromgross.Location = new Point(99, 9);
            dtfromgross.Name = "dtfromgross";
            dtfromgross.Size = new Size(98, 23);
            dtfromgross.TabIndex = 1;
            dtfromgross.ValueChanged += dtfromgross_ValueChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 15);
            label12.Name = "label12";
            label12.Size = new Size(83, 15);
            label12.TabIndex = 0;
            label12.Text = "Filter by: From";
            // 
            // Report
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(967, 485);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Report";
            Text = "Report";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvtopselling).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvrevenus).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvcost).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Panel panel2;
        private DateTimePicker dttotopselling;
        private Label label2;
        private DateTimePicker dtfromtopselling;
        private Label label1;
        private DataGridView dgvtopselling;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridView dgvrevenus;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private Panel panel3;
        private DateTimePicker dttorevenus;
        private Label label3;
        private DateTimePicker dtfromrevenus;
        private Label label4;
        private Label lblrevenus;
        private Label label5;
        private DataGridView dgvcost;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn Column5;
        private Panel panel4;
        private Label lblcost;
        private Label label7;
        private DateTimePicker dttocost;
        private Label label8;
        private DateTimePicker dtfromcost;
        private Label label9;
        private Panel panel5;
        private DateTimePicker dttogross;
        private Label label11;
        private DateTimePicker dtfromgross;
        private Label label12;
        private Label label13;
        private Label label10;
        private Label label6;
        private PictureBox pictureBox3;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private TextBox txtgrossprofit;
        private TextBox txtcog;
        private TextBox txtrevenus;
    }
}