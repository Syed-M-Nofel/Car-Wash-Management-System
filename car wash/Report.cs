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
    public partial class Report : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        String title = "Car Wash Management System";
        public Report()
        {
            InitializeComponent();
            loadTopSelling();
            loadRevenus();
            loadCOG();
            loadGrossProfit();
        }

        private void dgvtopselling_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }
        #region TopSelling

        private void dtfromtopselling_ValueChanged(object sender, EventArgs e)
        {
            loadTopSelling();
        }

        private void dttotopselling_ValueChanged(object sender, EventArgs e)
        {
            loadTopSelling();
        }

        public void loadTopSelling()
        {
            try
            {
                int i = 0;
                dgvtopselling.Rows.Clear();
                cm = new SqlCommand("SELECT TOP 10 se.name, count(ca.sid) AS qty, ISNULL(SUM(ca.price),0) AS total FROM tbCash AS ca JOIN tbService AS se ON ca.sid=se.id WHERE ca.date BETWEEN '" + dtfromtopselling.Value.ToString() + "' AND '" + dttotopselling.Value.ToString() + "' AND status LIKE 'Sold' " +
                   " GROUP BY  se.name ORDER BY qty DESC ", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvtopselling.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
                }
                dr.Close();
                dbcon.close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        #endregion TopSelling

        #region Revenus



        private void dtfromrevenus_ValueChanged(object sender, EventArgs e)

        {
            loadRevenus();

        }

        private void dttorevenus_ValueChanged(object sender, EventArgs e)
        {
            loadRevenus();
        }
        public void loadRevenus()
        {
            try
            {
                int i = 0;
                dgvrevenus.Rows.Clear();
                double total = 0;
                cm = new SqlCommand("SELECT date,ISNULL(SUM(price),0) AS total FROM tbCash WHERE date BETWEEN '" + dtfromrevenus.Value.ToString() + "'" +
                    " AND '" + dttorevenus.Value.ToString() + "' AND status LIKE 'Sold' GROUP BY date", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvrevenus.Rows.Add(i, DateTime.Parse(dr[0].ToString()).ToShortDateString(), dr[1].ToString());
                    total += double.Parse(dr[1].ToString());
                }
                lblrevenus.Text = total.ToString("#,##0.00");
                dr.Close();
                dbcon.close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }


        #endregion Revenus

        #region COG

        private void dtfromcost_ValueChanged(object sender, EventArgs e)
        {
            loadCOG();
        }

        private void dttocost_ValueChanged(object sender, EventArgs e)
        {
            loadCOG();
        }
        public void loadCOG()
        {
            try
            {
                int i = 0;
                dgvcost.Rows.Clear();
                double total = 0;
                cm = new SqlCommand("SELECT costname,cost,date FROM tbCostofGoodSold WHERE date BETWEEN '" + dtfromcost.Value.ToString() + "' AND '" + dttocost.Value.ToString() + "'", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvcost.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), DateTime.Parse(dr[2].ToString()).ToShortDateString());
                    total += double.Parse(dr[1].ToString());


                }
                lblcost.Text = total.ToString("#,##0.00");
                dr.Close();
                dbcon.close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }


        #endregion COG

        #region GrossProfit


        

        private void dtfromgross_ValueChanged(object sender, EventArgs e)
        {
            loadGrossProfit();
        }

        private void dttogross_ValueChanged(object sender, EventArgs e)
        {
            loadGrossProfit();
        }

        public void loadGrossProfit()
        {
            txtrevenus.Text = extractData("SELECT ISNULL(SUM(price),0) AS total FROM tbCash WHERE date BETWEEN '" + dtfromgross.Value.ToString() + "' AND '" + dttogross.Value.ToString() + "'").ToString("#,##0.00");
            txtcog.Text= extractData("SELECT ISNULL(SUM(cost),0) AS Cost FROM tbCostofGoodSold WHERE date BETWEEN '" + dtfromgross.Value.ToString() + "' AND '" + dttogross.Value.ToString() + "'").ToString("#,##0.00");
            txtgrossprofit.Text = (double.Parse(txtrevenus.Text)-double.Parse(txtcog.Text)).ToString("#,##0.00");
            if (double.Parse(txtgrossprofit.Text) < 0)
            {
                txtgrossprofit.ForeColor = Color.Red;
            }
            else
            {
                txtgrossprofit.ForeColor = Color.Green;
            }
        }
        public double extractData(string sql, params SqlParameter[] parameters)
        {
            dbcon.open();

            cm = new SqlCommand(sql, dbcon.connect());

            
            if (parameters != null && parameters.Length > 0)
            {
                cm.Parameters.AddRange(parameters);
            }

            double data = 0.0;

            try
            {
                object result = cm.ExecuteScalar();
                if (result != null)
                {
                    data = Convert.ToDouble(result);
                }
            }
            catch (Exception ex)
            {
               
                Console.WriteLine("Error in extractData: " + ex.Message);
            }
            finally
            {
                dbcon.close();
            }

            return data;
        }

        #endregion GrossProfit


    }
}
