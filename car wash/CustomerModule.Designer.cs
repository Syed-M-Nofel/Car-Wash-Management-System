namespace car_wash
{
    partial class CustomerModule
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
            btnclose = new Button();
            lblcid = new Label();
            btncancel = new Button();
            btnupdate = new Button();
            btnsave = new Button();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            txtphone = new TextBox();
            label4 = new Label();
            txtname = new TextBox();
            label2 = new Label();
            label1 = new Label();
            lblpass = new Label();
            label3 = new Label();
            txtcarno = new TextBox();
            txtcarmodel = new TextBox();
            txtaddress = new TextBox();
            cbcartype = new ComboBox();
            udpoints = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)udpoints).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(193, 0, 55);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(708, 27);
            panel1.TabIndex = 1;
            // 
            // btnclose
            // 
            btnclose.FlatAppearance.BorderSize = 0;
            btnclose.FlatStyle = FlatStyle.Flat;
            btnclose.Image = Properties.Resources.cancel;
            btnclose.Location = new Point(670, 56);
            btnclose.Name = "btnclose";
            btnclose.Size = new Size(20, 20);
            btnclose.TabIndex = 46;
            btnclose.UseVisualStyleBackColor = true;
            btnclose.Click += btnclose_Click;
            // 
            // lblcid
            // 
            lblcid.AutoSize = true;
            lblcid.Location = new Point(31, 445);
            lblcid.Name = "lblcid";
            lblcid.Size = new Size(25, 15);
            lblcid.TabIndex = 45;
            lblcid.Text = "Cid";
            // 
            // btncancel
            // 
            btncancel.BackColor = Color.DarkTurquoise;
            btncancel.FlatAppearance.BorderSize = 0;
            btncancel.FlatStyle = FlatStyle.Flat;
            btncancel.Location = new Point(535, 438);
            btncancel.Name = "btncancel";
            btncancel.Size = new Size(137, 34);
            btncancel.TabIndex = 44;
            btncancel.Text = "Cancel";
            btncancel.UseVisualStyleBackColor = false;
            btncancel.Click += btncancel_Click;
            // 
            // btnupdate
            // 
            btnupdate.BackColor = Color.Goldenrod;
            btnupdate.FlatAppearance.BorderSize = 0;
            btnupdate.FlatStyle = FlatStyle.Flat;
            btnupdate.Location = new Point(353, 438);
            btnupdate.Name = "btnupdate";
            btnupdate.Size = new Size(137, 34);
            btnupdate.TabIndex = 43;
            btnupdate.Text = "Update";
            btnupdate.UseVisualStyleBackColor = false;
            btnupdate.Click += btnupdate_Click;
            // 
            // btnsave
            // 
            btnsave.BackColor = Color.DodgerBlue;
            btnsave.FlatAppearance.BorderSize = 0;
            btnsave.FlatStyle = FlatStyle.Flat;
            btnsave.Location = new Point(169, 438);
            btnsave.Name = "btnsave";
            btnsave.Size = new Size(137, 34);
            btnsave.TabIndex = 42;
            btnsave.Text = "Save";
            btnsave.UseVisualStyleBackColor = false;
            btnsave.Click += btnsave_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(32, 280);
            label7.Name = "label7";
            label7.Size = new Size(58, 15);
            label7.TabIndex = 35;
            label7.Text = "Car Type :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 245);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 33;
            label6.Text = "Car Model:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(31, 206);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 31;
            label5.Text = "Car no:";
            // 
            // txtphone
            // 
            txtphone.Location = new Point(170, 158);
            txtphone.Name = "txtphone";
            txtphone.Size = new Size(520, 23);
            txtphone.TabIndex = 30;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(32, 161);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 29;
            label4.Text = "Phone :";
            // 
            // txtname
            // 
            txtname.Location = new Point(170, 108);
            txtname.Name = "txtname";
            txtname.Size = new Size(520, 23);
            txtname.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 108);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 25;
            label2.Text = "Full Name : ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Century Gothic", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(193, 0, 55);
            label1.Location = new Point(18, 57);
            label1.Name = "label1";
            label1.Size = new Size(174, 19);
            label1.TabIndex = 24;
            label1.Text = "Customer Registration";
            // 
            // lblpass
            // 
            lblpass.AutoSize = true;
            lblpass.Location = new Point(30, 319);
            lblpass.Name = "lblpass";
            lblpass.Size = new Size(55, 15);
            lblpass.TabIndex = 40;
            lblpass.Text = "Address :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 399);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 47;
            label3.Text = "Points :";
            // 
            // txtcarno
            // 
            txtcarno.Location = new Point(170, 198);
            txtcarno.Name = "txtcarno";
            txtcarno.Size = new Size(520, 23);
            txtcarno.TabIndex = 48;
            // 
            // txtcarmodel
            // 
            txtcarmodel.Location = new Point(170, 242);
            txtcarmodel.Name = "txtcarmodel";
            txtcarmodel.Size = new Size(520, 23);
            txtcarmodel.TabIndex = 49;
            // 
            // txtaddress
            // 
            txtaddress.Location = new Point(169, 319);
            txtaddress.Multiline = true;
            txtaddress.Name = "txtaddress";
            txtaddress.Size = new Size(520, 55);
            txtaddress.TabIndex = 50;
            txtaddress.UseSystemPasswordChar = true;
            // 
            // cbcartype
            // 
            cbcartype.FormattingEnabled = true;
            cbcartype.Location = new Point(170, 280);
            cbcartype.Name = "cbcartype";
            cbcartype.Size = new Size(520, 23);
            cbcartype.TabIndex = 51;
            // 
            // udpoints
            // 
            udpoints.Enabled = false;
            udpoints.Location = new Point(170, 398);
            udpoints.Name = "udpoints";
            udpoints.Size = new Size(520, 23);
            udpoints.TabIndex = 52;
            // 
            // CustomerModule
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(708, 511);
            Controls.Add(udpoints);
            Controls.Add(cbcartype);
            Controls.Add(txtaddress);
            Controls.Add(txtcarmodel);
            Controls.Add(txtcarno);
            Controls.Add(label3);
            Controls.Add(btnclose);
            Controls.Add(lblcid);
            Controls.Add(btncancel);
            Controls.Add(btnupdate);
            Controls.Add(btnsave);
            Controls.Add(lblpass);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txtphone);
            Controls.Add(label4);
            Controls.Add(txtname);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "CustomerModule";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CustomerModule";
            Load += CustomerModule_Load;
            ((System.ComponentModel.ISupportInitialize)udpoints).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button btnclose;
        public Label lblcid;
        public Button btncancel;
        public Button btnupdate;
        public Button btnsave;
        private Label label7;
        private Label label6;
        private Label label5;
        public TextBox txtphone;
        private Label label4;
        public TextBox txtname;
        private Label label2;
        private Label label1;
        private Label lblpass;
        private Label label3;
        public TextBox txtcarno;
        public TextBox txtcarmodel;
        public TextBox txtaddress;
        public ComboBox cbcartype;
        public NumericUpDown udpoints;
    }
}