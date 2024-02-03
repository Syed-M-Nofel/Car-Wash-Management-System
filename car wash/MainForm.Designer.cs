namespace car_wash
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            panelSlide = new Panel();
            panel2 = new Panel();
            btnlogout = new Button();
            btnsettings = new Button();
            btnreport = new Button();
            btncash = new Button();
            btnservice = new Button();
            btncustomer = new Button();
            btnemployer = new Button();
            btndashboard = new Button();
            panel_logo = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel3 = new Panel();
            panel6 = new Panel();
            lblgrossprofit = new Label();
            label9 = new Label();
            label10 = new Label();
            iconprofit = new PictureBox();
            pictureBox7 = new PictureBox();
            panel5 = new Panel();
            lblcostofgood = new Label();
            label6 = new Label();
            label7 = new Label();
            iconcost = new PictureBox();
            pictureBox5 = new PictureBox();
            panel4 = new Panel();
            lblrevenus = new Label();
            label3 = new Label();
            label2 = new Label();
            iconrevenus = new PictureBox();
            pictureBox2 = new PictureBox();
            panelchild = new Panel();
            panelC = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel_logo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconprofit).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconcost).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)iconrevenus).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panelSlide);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(10, 749);
            panel1.TabIndex = 0;
            // 
            // panelSlide
            // 
            panelSlide.BackColor = Color.FromArgb(15, 205, 219);
            panelSlide.Location = new Point(3, 150);
            panelSlide.Name = "panelSlide";
            panelSlide.Size = new Size(10, 45);
            panelSlide.TabIndex = 3;
            // 
            // panel2
            // 
            panel2.Controls.Add(btnlogout);
            panel2.Controls.Add(btnsettings);
            panel2.Controls.Add(btnreport);
            panel2.Controls.Add(btncash);
            panel2.Controls.Add(btnservice);
            panel2.Controls.Add(btncustomer);
            panel2.Controls.Add(btnemployer);
            panel2.Controls.Add(btndashboard);
            panel2.Controls.Add(panel_logo);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(10, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(190, 749);
            panel2.TabIndex = 1;
            // 
            // btnlogout
            // 
            btnlogout.BackColor = Color.Transparent;
            btnlogout.Dock = DockStyle.Bottom;
            btnlogout.FlatAppearance.BorderSize = 0;
            btnlogout.FlatStyle = FlatStyle.Flat;
            btnlogout.Image = Properties.Resources.logout;
            btnlogout.ImageAlign = ContentAlignment.TopLeft;
            btnlogout.Location = new Point(0, 704);
            btnlogout.Name = "btnlogout";
            btnlogout.Size = new Size(190, 45);
            btnlogout.TabIndex = 10;
            btnlogout.Text = " Log out";
            btnlogout.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnlogout.UseVisualStyleBackColor = false;
            btnlogout.Click += btnlogout_Click;
            // 
            // btnsettings
            // 
            btnsettings.BackColor = Color.Transparent;
            btnsettings.Dock = DockStyle.Top;
            btnsettings.FlatAppearance.BorderSize = 0;
            btnsettings.FlatStyle = FlatStyle.Flat;
            btnsettings.Image = (Image)resources.GetObject("btnsettings.Image");
            btnsettings.ImageAlign = ContentAlignment.TopLeft;
            btnsettings.Location = new Point(0, 420);
            btnsettings.Name = "btnsettings";
            btnsettings.Size = new Size(190, 45);
            btnsettings.TabIndex = 9;
            btnsettings.Text = " Settings";
            btnsettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnsettings.UseVisualStyleBackColor = false;
            btnsettings.Click += btnsettings_Click;
            // 
            // btnreport
            // 
            btnreport.BackColor = Color.Transparent;
            btnreport.Dock = DockStyle.Top;
            btnreport.FlatAppearance.BorderSize = 0;
            btnreport.FlatStyle = FlatStyle.Flat;
            btnreport.Image = (Image)resources.GetObject("btnreport.Image");
            btnreport.ImageAlign = ContentAlignment.TopLeft;
            btnreport.Location = new Point(0, 375);
            btnreport.Name = "btnreport";
            btnreport.Size = new Size(190, 45);
            btnreport.TabIndex = 8;
            btnreport.Text = " Report";
            btnreport.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnreport.UseVisualStyleBackColor = false;
            btnreport.Click += btnreport_Click;
            // 
            // btncash
            // 
            btncash.BackColor = Color.Transparent;
            btncash.Dock = DockStyle.Top;
            btncash.FlatAppearance.BorderSize = 0;
            btncash.FlatStyle = FlatStyle.Flat;
            btncash.Image = (Image)resources.GetObject("btncash.Image");
            btncash.ImageAlign = ContentAlignment.TopLeft;
            btncash.Location = new Point(0, 330);
            btncash.Name = "btncash";
            btncash.Size = new Size(190, 45);
            btncash.TabIndex = 7;
            btncash.Text = " Cash";
            btncash.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncash.UseVisualStyleBackColor = false;
            btncash.Click += btncash_Click;
            // 
            // btnservice
            // 
            btnservice.BackColor = Color.Transparent;
            btnservice.Dock = DockStyle.Top;
            btnservice.FlatAppearance.BorderSize = 0;
            btnservice.FlatStyle = FlatStyle.Flat;
            btnservice.Image = (Image)resources.GetObject("btnservice.Image");
            btnservice.ImageAlign = ContentAlignment.TopLeft;
            btnservice.Location = new Point(0, 285);
            btnservice.Name = "btnservice";
            btnservice.Size = new Size(190, 45);
            btnservice.TabIndex = 6;
            btnservice.Text = " Service";
            btnservice.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnservice.UseVisualStyleBackColor = false;
            btnservice.Click += btnservice_Click;
            // 
            // btncustomer
            // 
            btncustomer.BackColor = Color.Transparent;
            btncustomer.Dock = DockStyle.Top;
            btncustomer.FlatAppearance.BorderSize = 0;
            btncustomer.FlatStyle = FlatStyle.Flat;
            btncustomer.Image = (Image)resources.GetObject("btncustomer.Image");
            btncustomer.ImageAlign = ContentAlignment.TopLeft;
            btncustomer.Location = new Point(0, 240);
            btncustomer.Name = "btncustomer";
            btncustomer.Size = new Size(190, 45);
            btncustomer.TabIndex = 5;
            btncustomer.Text = " Customer";
            btncustomer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btncustomer.UseVisualStyleBackColor = false;
            btncustomer.Click += btncustomer_Click;
            // 
            // btnemployer
            // 
            btnemployer.BackColor = Color.Transparent;
            btnemployer.Dock = DockStyle.Top;
            btnemployer.FlatAppearance.BorderSize = 0;
            btnemployer.FlatStyle = FlatStyle.Flat;
            btnemployer.Image = (Image)resources.GetObject("btnemployer.Image");
            btnemployer.ImageAlign = ContentAlignment.TopLeft;
            btnemployer.Location = new Point(0, 195);
            btnemployer.Name = "btnemployer";
            btnemployer.Size = new Size(190, 45);
            btnemployer.TabIndex = 4;
            btnemployer.Text = " Employer";
            btnemployer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnemployer.UseVisualStyleBackColor = false;
            btnemployer.Click += btnemployer_Click;
            // 
            // btndashboard
            // 
            btndashboard.BackColor = Color.Transparent;
            btndashboard.Dock = DockStyle.Top;
            btndashboard.FlatAppearance.BorderSize = 0;
            btndashboard.FlatStyle = FlatStyle.Flat;
            btndashboard.Image = Properties.Resources.dashboard__1_;
            btndashboard.ImageAlign = ContentAlignment.TopLeft;
            btndashboard.Location = new Point(0, 150);
            btndashboard.Name = "btndashboard";
            btndashboard.Size = new Size(190, 45);
            btndashboard.TabIndex = 3;
            btndashboard.Text = " Dashboard";
            btndashboard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btndashboard.UseVisualStyleBackColor = false;
            btndashboard.Click += btndashboard_Click;
            // 
            // panel_logo
            // 
            panel_logo.Controls.Add(pictureBox1);
            panel_logo.Controls.Add(label1);
            panel_logo.Dock = DockStyle.Top;
            panel_logo.Location = new Point(0, 0);
            panel_logo.Name = "panel_logo";
            panel_logo.Size = new Size(190, 150);
            panel_logo.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.clean;
            pictureBox1.Location = new Point(16, 40);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Century Gothic", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(15, 205, 219);
            label1.Location = new Point(72, 50);
            label1.Name = "label1";
            label1.Size = new Size(46, 40);
            label1.TabIndex = 3;
            label1.Text = "Air";
            label1.UseCompatibleTextRendering = true;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(15, 205, 219);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(panel5);
            panel3.Controls.Add(panel4);
            panel3.Controls.Add(panelchild);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(200, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(1064, 310);
            panel3.TabIndex = 2;
            // 
            // panel6
            // 
            panel6.BackColor = Color.White;
            panel6.Controls.Add(lblgrossprofit);
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(iconprofit);
            panel6.Controls.Add(pictureBox7);
            panel6.Location = new Point(749, 101);
            panel6.Name = "panel6";
            panel6.Size = new Size(200, 100);
            panel6.TabIndex = 6;
            // 
            // lblgrossprofit
            // 
            lblgrossprofit.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblgrossprofit.Location = new Point(3, 30);
            lblgrossprofit.Name = "lblgrossprofit";
            lblgrossprofit.Size = new Size(101, 23);
            lblgrossprofit.TabIndex = 4;
            lblgrossprofit.Text = "0.00";
            lblgrossprofit.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = SystemColors.ControlDark;
            label9.Location = new Point(36, 80);
            label9.Name = "label9";
            label9.Size = new Size(126, 20);
            label9.TabIndex = 3;
            label9.Text = "Since last 7 days";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = SystemColors.ControlDark;
            label10.Location = new Point(0, 0);
            label10.Name = "label10";
            label10.Size = new Size(90, 20);
            label10.TabIndex = 2;
            label10.Text = "Gross Profit";
            // 
            // iconprofit
            // 
            iconprofit.Image = Properties.Resources.up_arrow;
            iconprofit.Location = new Point(0, 70);
            iconprofit.Name = "iconprofit";
            iconprofit.Size = new Size(30, 30);
            iconprofit.TabIndex = 1;
            iconprofit.TabStop = false;
            iconprofit.Click += pictureBox6_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources.cash_in_hand;
            pictureBox7.Location = new Point(147, 3);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(45, 45);
            pictureBox7.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.White;
            panel5.Controls.Add(lblcostofgood);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(iconcost);
            panel5.Controls.Add(pictureBox5);
            panel5.Location = new Point(431, 101);
            panel5.Name = "panel5";
            panel5.Size = new Size(200, 100);
            panel5.TabIndex = 5;
            // 
            // lblcostofgood
            // 
            lblcostofgood.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblcostofgood.Location = new Point(3, 30);
            lblcostofgood.Name = "lblcostofgood";
            lblcostofgood.Size = new Size(92, 23);
            lblcostofgood.TabIndex = 4;
            lblcostofgood.Text = "0.00";
            lblcostofgood.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.ForeColor = SystemColors.ControlDark;
            label6.Location = new Point(36, 80);
            label6.Name = "label6";
            label6.Size = new Size(126, 20);
            label6.TabIndex = 3;
            label6.Text = "Since last 7 days";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.ForeColor = SystemColors.ControlDark;
            label7.Location = new Point(0, 0);
            label7.Name = "label7";
            label7.Size = new Size(142, 20);
            label7.TabIndex = 2;
            label7.Text = "Cost of Good Sold";
            // 
            // iconcost
            // 
            iconcost.Image = Properties.Resources.decrease;
            iconcost.Location = new Point(0, 70);
            iconcost.Name = "iconcost";
            iconcost.Size = new Size(30, 30);
            iconcost.TabIndex = 1;
            iconcost.TabStop = false;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources.withdrawal;
            pictureBox5.Location = new Point(147, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(45, 45);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.White;
            panel4.Controls.Add(lblrevenus);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(iconrevenus);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(105, 101);
            panel4.Name = "panel4";
            panel4.Size = new Size(200, 100);
            panel4.TabIndex = 4;
            // 
            // lblrevenus
            // 
            lblrevenus.Font = new Font("Century Gothic", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblrevenus.Location = new Point(3, 30);
            lblrevenus.Name = "lblrevenus";
            lblrevenus.Size = new Size(96, 23);
            lblrevenus.TabIndex = 4;
            lblrevenus.Text = "0.00";
            lblrevenus.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = SystemColors.ControlDark;
            label3.Location = new Point(36, 80);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 3;
            label3.Text = "Since last 7 days";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = SystemColors.ControlDark;
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(74, 20);
            label2.TabIndex = 2;
            label2.Text = "REVENUS";
            // 
            // iconrevenus
            // 
            iconrevenus.Image = Properties.Resources.up_arrow;
            iconrevenus.Location = new Point(0, 70);
            iconrevenus.Name = "iconrevenus";
            iconrevenus.Size = new Size(30, 30);
            iconrevenus.TabIndex = 1;
            iconrevenus.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.sales;
            pictureBox2.Location = new Point(147, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(45, 45);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panelchild
            // 
            panelchild.BackColor = Color.White;
            panelchild.Location = new Point(47, 316);
            panelchild.Name = "panelchild";
            panelchild.Size = new Size(967, 480);
            panelchild.TabIndex = 3;
            // 
            // panelC
            // 
            panelC.Location = new Point(230, 285);
            panelC.Name = "panelC";
            panelC.Size = new Size(998, 458);
            panelC.TabIndex = 3;
            panelC.Paint += panelC_Paint;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1264, 749);
            Controls.Add(panelC);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Font = new Font("Century Gothic", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "MainForm";
            Text = "Car Wash";
            Load += MainForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel_logo.ResumeLayout(false);
            panel_logo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconprofit).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconcost).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)iconrevenus).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel_logo;
        private Panel panel2;
        private Panel panel3;
        private Button btndashboard;
        private Button btnlogout;
        private Button btnsettings;
        private Button btnreport;
        private Button btncash;
        private Button btnservice;
        private Button btncustomer;
        private Button btnemployer;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panelSlide;
        private Panel panel4;
        private Label label2;
        private PictureBox iconrevenus;
        private PictureBox pictureBox2;
        private Label lblrevenus;
        private Label label3;
        private Panel panel6;
        private Label lblgrossprofit;
        private Label label9;
        private Label label10;
        private PictureBox iconprofit;
        private PictureBox pictureBox7;
        private Panel panel5;
        private Label lblcostofgood;
        private Label label6;
        private Label label7;
        private PictureBox iconcost;
        private PictureBox pictureBox5;
        public Panel panelchild;
        private Panel panelC;
    }
}