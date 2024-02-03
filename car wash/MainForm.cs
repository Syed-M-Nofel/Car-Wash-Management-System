using System.Data.SqlClient;

namespace car_wash
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
             loadGrossProfit();
        }

        private void btndashboard_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btndashboard.Height;
            panelSlide.Top = btndashboard.Top;
        }

        private void btnemployer_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnemployer.Height;
            panelSlide.Top = btnemployer.Top;
            openChildForm(new Employer());
        }

        private void btncustomer_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btncustomer.Height;
            panelSlide.Top = btncustomer.Top;
            openChildForm(new Company());
        }

        private void btnservice_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnservice.Height;
            panelSlide.Top = btnservice.Top;
            openChildForm(new Service());
        }

        private void btncash_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btncash.Height;
            panelSlide.Top = btncash.Top;
            openChildForm(new Cash());
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnreport.Height;
            panelSlide.Top = btnreport.Top;
            openChildForm(new Report());
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnsettings.Height;
            panelSlide.Top = btnsettings.Top;
            openChildForm(new setting());
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnlogout.Height;
            panelSlide.Top = btnlogout.Top;
            this.Hide();
            Login module = new Login();
            module.ShowDialog();
         


        }
        #region method
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelC.Controls.Add(childForm);
            panelC.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        #endregion method.

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void panelC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        public void loadGrossProfit()
        {
            Report module = new Report();

            DateTime startDate = DateTime.Now.AddDays(-7);

            string revenueQuery = "SELECT ISNULL(SUM(price), 0) AS total FROM tbCash WHERE date > @StartDate";
            lblrevenus.Text = module.extractData(revenueQuery, new SqlParameter("@StartDate", startDate)).ToString("#,##0.00");

            string costOfGoodsQuery = "SELECT ISNULL(SUM(cost), 0) AS Cost FROM tbCostofGoodSold WHERE date > @StartDate";
            lblcostofgood.Text = module.extractData(costOfGoodsQuery, new SqlParameter("@StartDate", startDate)).ToString("#,##0.00");

            double grossProfit = double.Parse(lblrevenus.Text) - double.Parse(lblcostofgood.Text);
            lblgrossprofit.Text = grossProfit.ToString("#,##0.00");
        }

    }
}