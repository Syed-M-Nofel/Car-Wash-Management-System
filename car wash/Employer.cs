using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace car_wash
{
    public partial class Employer : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        SqlDataReader dr;
        String title = "Car Wash Management System";
        public Employer()
        {
            InitializeComponent();
            loadEmployer();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            EmployerModule module = new EmployerModule(this);
            module.btnupdate.Enabled = false;
            module.ShowDialog();
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            loadEmployer();
        }

        private void dgvemployeer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String colName = dgvemployeer.Columns[e.ColumnIndex].Name;
            if (colName == "Edit")
            {
                EmployerModule module = new EmployerModule(this);
                module.lbleid.Text = dgvemployeer.Rows[e.RowIndex].Cells[1].Value.ToString();
                module.txtname.Text = dgvemployeer.Rows[e.RowIndex].Cells[2].Value.ToString();
                module.txtphone.Text = dgvemployeer.Rows[e.RowIndex].Cells[3].Value.ToString();
                module.txtaddress.Text = dgvemployeer.Rows[e.RowIndex].Cells[4].Value.ToString();
                module.dtdob.Text = dgvemployeer.Rows[e.RowIndex].Cells[5].Value.ToString();
                module.rdmale.Checked = dgvemployeer.Rows[e.RowIndex].Cells[6].Value.ToString() == "Male" ? true : false;
                module.cbrole.Text = dgvemployeer.Rows[e.RowIndex].Cells[7].Value.ToString();
                module.txtsalary.Text = dgvemployeer.Rows[e.RowIndex].Cells[8].Value.ToString();
                module.txtpassword.Text = dgvemployeer.Rows[e.RowIndex].Cells[9].Value.ToString();
                module.btnsave.Enabled = false;
                module.ShowDialog();
                loadEmployer();

            }

            else if (colName == "Delete")
            {
                try
                {
                    if (MessageBox.Show("Are you sure you want to delete this record", "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("DELETE From tEmployer WHERE id LIKE '" + dgvemployeer.Rows[e.RowIndex].Cells[1].Value.ToString() + "'", dbcon.connect());
                        dbcon.open();
                        cm.ExecuteNonQuery();
                        dbcon.close();
                        MessageBox.Show("Employer data has been successfully removed!", title, MessageBoxButtons.OK, MessageBoxIcon.Information);

                        loadEmployer();
                    }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, title);
                }
            }
        }

        #region method

        public void loadEmployer()
        {
            try
            {
                int i = 0;
                dgvemployeer.Rows.Clear();
                cm = new SqlCommand("SELECT * FROM tEmployer WHERE CONCAT (name, address ,role) LIKE '%" + txtsearch.Text + "%'", dbcon.connect());
                dbcon.open();
                dr = cm.ExecuteReader();
                while (dr.Read())
                {
                    i++;
                    dgvemployeer.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), DateTime.Parse(dr[4].ToString()).ToShortTimeString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());

                }
                dbcon.close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }
        }
        #endregion method

    }
}
