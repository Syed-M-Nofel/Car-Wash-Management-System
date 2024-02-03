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
    public partial class CashCustomer : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        String title = "Car Wash Management System";
        Cash cash;
        public CashCustomer(Cash cashForm)
        {
            InitializeComponent();
            cash = cashForm;
            loadCustomer();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadCustomer();
        }
        #region method
        public void loadCustomer()
        {
            try
            {
                int i = 0;
                dgvcustomer.Rows.Clear();
                cm = new SqlCommand("SELECT * FROM tbCustomer  WHERE CONCAT (name,phone, address) LIKE '%" + txtSearch.Text + "%'", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvcustomer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString());

                }
                dbcon.close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion method

        private void dgvcustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colName = dgvcustomer.Columns[e.ColumnIndex].Name;
            if (colName == "select")
            {
                cash.customerId = int.Parse(dgvcustomer.Rows[e.RowIndex].Cells[1].Value.ToString());
                cash.vehicleTypeId = int.Parse(dgvcustomer.Rows[e.RowIndex].Cells[2].Value.ToString());
            }
            else return;
            this.Dispose();
            cash.panelcashC.Height = 1;

        }

        private void btncash_Click(object sender, EventArgs e)
        {

        }
    }
}
