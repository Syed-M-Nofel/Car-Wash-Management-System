namespace car_wash
{
    partial class EmployerModule
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
            panel1 = new Panel();
            label1 = new Label();
            label2 = new Label();
            txtname = new TextBox();
            label3 = new Label();
            dtdob = new DateTimePicker();
            label4 = new Label();
            txtphone = new TextBox();
            label5 = new Label();
            txtaddress = new TextBox();
            label6 = new Label();
            cbrole = new ComboBox();
            label7 = new Label();
            txtsalary = new TextBox();
            label8 = new Label();
            rdmale = new RadioButton();
            rdfemale = new RadioButton();
            lblpass = new Label();
            txtpassword = new TextBox();
            btnsave = new Button();
            btnupdate = new Button();
            btncancel = new Button();
            lbleid = new Label();
            btnclose = new Button();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(193, 0, 55);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 27);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(193, 0, 55);
            label1.Location = new Point(12, 44);
            label1.Name = "label1";
            label1.Size = new Size(174, 19);
            label1.TabIndex = 1;
            label1.Text = "Employer Registration";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 95);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 2;
            label2.Text = "Full Name : ";
            // 
            // txtname
            // 
            txtname.Location = new Point(164, 95);
            txtname.Name = "txtname";
            txtname.Size = new Size(520, 26);
            txtname.TabIndex = 3;
            txtname.TextChanged += txtname_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 152);
            label3.Name = "label3";
            label3.Size = new Size(107, 20);
            label3.TabIndex = 4;
            label3.Text = "Date of Birth :";
            // 
            // dtdob
            // 
            dtdob.CustomFormat = "dd/mm/yyyy";
            dtdob.Format = DateTimePickerFormat.Custom;
            dtdob.Location = new Point(164, 146);
            dtdob.Name = "dtdob";
            dtdob.Size = new Size(183, 26);
            dtdob.TabIndex = 5;
            dtdob.Value = new DateTime(2023, 11, 8, 0, 0, 0, 0);
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(366, 151);
            label4.Name = "label4";
            label4.Size = new Size(64, 20);
            label4.TabIndex = 6;
            label4.Text = "Phone :";
            // 
            // txtphone
            // 
            txtphone.Location = new Point(436, 148);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(248, 26);
            txtphone.TabIndex = 7;
            txtphone.TextChanged += txtphone_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 198);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 8;
            label5.Text = "Address :";
            label5.Click += label5_Click;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(164, 195);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(520, 58);
            txtaddress.TabIndex = 9;
            txtaddress.TextChanged += txtaddress_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(26, 271);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 10;
            label6.Text = "Role :";
            // 
            // cbrole
            // 
            cbrole.DropDownStyle = ComboBoxStyle.DropDownList;
            cbrole.FlatStyle = FlatStyle.Popup;
            cbrole.FormattingEnabled = true;
            cbrole.Items.AddRange(new object[] { "Manager", "Supervisor", "Cashier", "Worker" });
            cbrole.Location = new Point(164, 271);
            cbrole.Name = "cbrole";
            cbrole.Size = new Size(520, 28);
            cbrole.TabIndex = 11;
            cbrole.SelectedIndexChanged += cbrole_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 314);
            label7.Name = "label7";
            label7.Size = new Size(60, 20);
            label7.TabIndex = 12;
            label7.Text = "Salary :";
            // 
            // txtsalary
            // 
            txtsalary.Location = new Point(164, 311);
            txtsalary.Name = "txtsalary";
            txtsalary.Size = new Size(211, 26);
            txtsalary.TabIndex = 13;
            txtsalary.TextChanged += txtsalary_TextChanged;
            txtsalary.KeyPress += txtsalary_KeyPress;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(391, 318);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 14;
            label8.Text = "Gender :";
            // 
            // rdmale
            // 
            rdmale.AutoSize = true;
            rdmale.Location = new Point(494, 314);
            rdmale.Name = "rdmale";
            rdmale.Size = new Size(65, 24);
            rdmale.TabIndex = 15;
            rdmale.Text = "Male";
            rdmale.UseVisualStyleBackColor = true;
            rdmale.CheckedChanged += rdmale_CheckedChanged;
            // 
            // rdfemale
            // 
            rdfemale.AutoSize = true;
            rdfemale.Location = new Point(604, 314);
            rdfemale.Name = "rdfemale";
            rdfemale.Size = new Size(80, 24);
            rdfemale.TabIndex = 16;
            rdfemale.Text = "Female";
            rdfemale.UseVisualStyleBackColor = true;
            rdfemale.CheckedChanged += rdfemale_CheckedChanged;
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Location = new Point(26, 356);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(87, 20);
            lblpass.TabIndex = 17;
            lblpass.Text = "Password :";
            // 
            // txtpassword
            // 
            txtpassword.Location = new Point(164, 350);
            txtpassword.Name = "txtpassword";
            txtpassword.Size = new Size(520, 26);
            txtpassword.TabIndex = 18;
            txtpassword.UseSystemPasswordChar = true;
            txtpassword.TextChanged += txtpassword_TextChanged;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.DodgerBlue;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Location = new Point(164, 407);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(137, 34);
            btnsave.TabIndex = 19;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.Goldenrod;
            btnupdate.FlatAppearance.BorderSize = 0;
            btnupdate.FlatStyle = FlatStyle.Flat;
            btnupdate.Location = new Point(348, 407);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(137, 34);
            btnupdate.TabIndex = 20;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += button2_Click;
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.DarkTurquoise;
            btncancel.FlatAppearance.BorderSize = 0;
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.Location = new Point(530, 407);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(137, 34);
            btncancel.TabIndex = 21;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // lbleid
            // 
            lbleid.AutoSize = true;
            lbleid.Location = new Point(26, 414);
            lbleid.Name = "lbleid";
            lbleid.Size = new Size(30, 20);
            lbleid.TabIndex = 22;
            lbleid.Text = "Eid";
            lbleid.Click += lbleid_Click;
            // 
            // btnclose
            // 
            btnclose.FlatAppearance.BorderSize = 0;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.Image = Properties.Resources.cancel;
            btnclose.Location = new Point(664, 43);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(20, 20);
            btnclose.TabIndex = 23;
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // EmployerModule
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(708, 453);
            Controls.Add(btnclose);
            Controls.Add(lbleid);
            Controls.Add(btncancel);
            Controls.Add(btnupdate);
            Controls.Add(btnsave);
            Controls.Add(txtpassword);
            Controls.Add(lblpass);
            Controls.Add(rdfemale);
            Controls.Add(rdmale);
            Controls.Add(label8);
            Controls.Add(txtsalary);
            Controls.Add(label7);
            Controls.Add(cbrole);
            Controls.Add(label6);
            Controls.Add(txtaddress);
            Controls.Add(label5);
            Controls.Add(txtphone);
            Controls.Add(label4);
            Controls.Add(dtdob);
            Controls.Add(label3);
            Controls.Add(txtname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.None;
            Name = "EmployerModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EmployerModule";
            Load += EmployerModule_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label lblpass;
        public Label lbleid;
        private Button btnclose;
        public TextBox txtname;
        public TextBox txtphone;
        public TextBox txtaddress;
        public ComboBox cbrole;
        public TextBox txtsalary;
        public RadioButton rdmale;
        public RadioButton rdfemale;
        public TextBox txtpassword;
        public Button btnsave;
        public Button btnupdate;
        public Button btncancel;
        public DateTimePicker dtdob;
    }
}