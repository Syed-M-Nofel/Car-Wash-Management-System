using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace car_wash
{
    public partial class ManageCostGoodSold : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        String title = "Car Wash Management System";
        setting setting;
        bool check = false;
        public ManageCostGoodSold(setting sett)
        {
            InitializeComponent();
            setting = sett;
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

            try
            {
                checkField();
                if (check)
                {

                    if (MessageBox.Show("Are you sure you want to register this cost of good sold?", "Cost of Good Sold Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("Insert into tbCostofGoodSold(costname,cost,date) Values(@costname,@cost,@date)", dbcon.connect());
                        cm.Parameters.AddWithValue("@costname", txtcostname.Text);
                        cm.Parameters.AddWithValue("@cost", txtcost.Text);
                        cm.Parameters.AddWithValue("@date", dtcost.Value);
                        dbcon.open();
                        cm.ExecuteNonQuery();

                        dbcon.close();
                        MessageBox.Show("Cost has been successfully registered!", title);
                        clear();
                        setting.loadCostofGood();


                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            try
            {
                checkField();
                if (check)
                {

                    if (MessageBox.Show("Are you sure you want to edit this cost of good sold?", "Cost of Good Sold Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("Update tbCostofGoodSold SET costname=@costname,cost=@cost,date=@date Where id=@id" , dbcon.connect());
                        cm.Parameters.AddWithValue("@id", lblCid.Text);
                        cm.Parameters.AddWithValue("@costname", txtcostname.Text);
                        cm.Parameters.AddWithValue("@cost", txtcost.Text);
                        cm.Parameters.AddWithValue("@date", dtcost.Value);
                        dbcon.open();
                        cm.ExecuteNonQuery();

                        dbcon.close();
                        MessageBox.Show("Data of good sold has been successfully updated!", title);
                        clear();
                        this.Dispose();


                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            clear();
        }
        #region method

        public void checkField()
        {
            if (txtcostname.Text == "" || txtcost.Text == "")
            {
                MessageBox.Show("Required  data field!", "Warning");
                return;
            }
            check = true;
        }
        public void clear()
        {
            txtcostname.Clear();
            txtcost.Clear();
            dtcost.Value = DateTime.Now;
            btnsave.Enabled = true;
            btnupdate.Enabled = false;

        }
        #endregion method
    }
}
