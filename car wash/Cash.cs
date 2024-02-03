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
    public partial class Cash : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        String title = "Car Wash Management System";
        public int customerId = 0, vehicleTypeId = 0;
        public Cash()
        {
            InitializeComponent();
            getTransno();
            loadCash();
        }



        private void label3_Click(object sender, EventArgs e)
        {

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
            panelcashC.Height = 200;
            panelcashC.Controls.Add(childForm);
            panelcashC.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public void getTransno()
        {
            try
            {
                string sdate = DateTime.Now.ToString("yyyyMMdd");
                int count;
                string transno;

                dbcon.open();
                cm = new SqlCommand("SELECT TOP 1 transno FROM tbCash WHERE transno LIKE '" + sdate + "%' ORDER BY id DESC", dbcon.connect());
                dr = cm.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    transno = dr[0].ToString();
                    count = int.Parse(transno.Substring(8, 4));
                    lbltransno.Text = sdate + (count + 1);

                }
                else
                {
                    transno = sdate + "1001";
                    lbltransno.Text = transno;
                }
                dbcon.close();
                dr.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        #endregion method




        public void loadCash()
        {
            int i = 0;
            double total = 0;
            double price = 0;
            dgvcash.Rows.Clear();
            cm = new SqlCommand("SELECT ca.id, ca.transno,cu.name, cu.carno, cu.carmodel,v.name,v.class, s.name, ca.price,ca.date FROM tbCash AS Ca " +
                "LEFT JOIN tbCustomer AS Cu ON CA.cid=Cu.id LEFT JOIN tbService AS s ON CA.sid=s.id LEFT JOIN tbVehicleType AS v ON Ca.vid=v.id WHERE status LIKE 'Pending' AND Ca.transno='" + lbltransno.Text + "'", dbcon.connect());
            dbcon.open();
            dr = cm.ExecuteReader();
            while (dr.Read())
            {
                i++;
                 price = double.Parse(dr[6].ToString()) * double.Parse(dr[8].ToString());
                dgvcash.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), price, dr[9].ToString());
                total += price;

            }
            dr.Close();
            dbcon.close();
            lbltotal.Text = total.ToString("#,##0.00 ");

        }

        private void btnaddcustomer_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CashCustomer(this));
            btnaddservice.Enabled = true;
        }

        private void btnaddservice_Click_1(object sender, EventArgs e)
        {
            openChildForm(new CashService(this));
            btnaddcustomer.Enabled = false;
        }

        private void btncash_Click(object sender, EventArgs e)
        {
            SettlePayment module = new SettlePayment(this);
            module.txtsale.Text = lbltotal.Text;
            module.ShowDialog();
        }

        private void dgvcash_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string colName = dgvcash.Columns[e.ColumnIndex].Name;
            if (colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to cancel this record", "Cancel Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("DELETE From tbCash WHERE id LIKE '" + dgvcash.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", dbcon.connect());
                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("Service has been successfully cancelled!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);


                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
            }
            loadCash();
        }
    }
}

