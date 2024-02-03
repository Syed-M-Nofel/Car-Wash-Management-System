using Microsoft.IdentityModel.Protocols.OpenIdConnect;
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
    public partial class SettlePayment : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        String title = "Car Wash Management System";
        Cash cash;
        public SettlePayment(Cash cashForm)
        {
            InitializeComponent();
            cash = cashForm;
        }

        private void picclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn8.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn0.Text;
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            txtcash.Text += btnpoint.Text;
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            try
            {
                if (double.Parse(txtchange.Text) < 0 || txtcash.Text.Equals(""))
                {
                    MessageBox.Show("Insufficient amount, Please enter the correct amount", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    for (int i = 0; i < cash.dgvcash.Rows.Count; i++)
                    {
                        dbcon.executeQuery("UPDATE tbCash SET status='Sold', price='" + cash.dgvcash.Rows[i].Cells[9].Value.ToString() + "' WHERE id='" + cash.dgvcash.Rows[i].Cells[1].Value.ToString() + "'");
                        dbcon.executeQuery("UPDATE tbCustomer SET points += " + 1 + " WHERE id='" + cash.customerId + "'");


                    }
                   
                    MessageBox.Show("Payment successfully saved!", "Payment", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cash.loadCash();
                    this.Dispose();
                    cash.btnaddcustomer.Enabled = true;
                    cash.btnaddservice.Enabled = false;
                    cash.getTransno();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn3.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn2.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn1.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn6.Text;
        }

        private void btn00_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn00.Text;
        }

        private void btnclean_Click(object sender, EventArgs e)
        {
            txtcash.Clear();
            txtcash.Focus();
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn9.Text;
        }

        private void SettlePayment_Load(object sender, EventArgs e)
        {
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtcash.Text += btn7.Text;
        }

        private void txtcash_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double charge = double.Parse(txtcash.Text) - double.Parse(txtsale.Text);
                txtchange.Text = charge.ToString("#,###0.00");
            }
            catch (Exception)
            {
                txtchange.Text = "0.00";
            }
        }

        private void txtsale_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtchange_TextChanged(object sender, EventArgs e)
        {
        }

        private void SettlePayment_keyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnenter.PerformClick();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Dispose();
            }
        }
    }
}
