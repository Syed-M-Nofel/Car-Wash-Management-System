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
    public partial class CustomerModule : Form
    {
        SqlCommand cm = new SqlCommand();
        dbConnect dbcon = new dbConnect();
        bool check = false;
        public int vid = 0;
        String title = "Car Wash Management System";
        Company company;
        public CustomerModule(Company com)
        {
            InitializeComponent();
            company = com;
        }

        private void cbrole_SelectedIndexChanged(object sender, EventArgs e)
        {
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
                    if (MessageBox.Show("Are you sure you want to register this customer?", "Customer Registration", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("Insert into tbCustomer(vid,name,phone,carno,carmodel,address,points) Values(@vid,@name,@phone,@carno,@carmodel,@address,@points)", dbcon.connect());
                        cm.Parameters.AddWithValue("@vid", cbcartype.SelectedValue);
                        cm.Parameters.AddWithValue("@name", txtname.Text);
                        cm.Parameters.AddWithValue("@phone", txtphone.Text);
                        cm.Parameters.AddWithValue("@carno", txtcarno.Text);
                        cm.Parameters.AddWithValue("@carmodel", txtcarmodel.Text);
                        
                        cm.Parameters.AddWithValue("@address", txtaddress.Text);
                        cm.Parameters.AddWithValue("@points", udpoints.Text);

                        dbcon.open();
                        cm.ExecuteNonQuery();

                        dbcon.close();
                        MessageBox.Show("Customer has been successfully registered!", title);
                        check = false;
                        Clear();

                        company.loadCustomer();

                    }
                }
                company.loadCustomer();

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
                    if (MessageBox.Show("Are you sure you want to Edit this customer?", "Customer Editing", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        cm = new SqlCommand("Update tbCustomer SET vid=@vid,name=@name,phone=@phone,carno=@carno,carmodel=@carmodel,address=@address,points= @points WHERE id=@id", dbcon.connect());
                        cm.Parameters.AddWithValue("@id", lblcid.Text);
                        cm.Parameters.AddWithValue("@vid", cbcartype.SelectedValue);
                        cm.Parameters.AddWithValue("@name", txtname.Text);
                        cm.Parameters.AddWithValue("@phone", txtphone.Text);
                        cm.Parameters.AddWithValue("@carno", txtcarno.Text);
                        cm.Parameters.AddWithValue("@carmodel", txtcarmodel.Text);
                        cm.Parameters.AddWithValue("@address", txtaddress.Text);
                        cm.Parameters.AddWithValue("@points", udpoints.Text);

                        dbcon.open();
                        cm.ExecuteNonQuery();

                        dbcon.close();
                        MessageBox.Show("Customer has been successfully Edited!", title);
                        Clear();
                        this.Dispose();
                         

                       
                    }
                }
                company.loadCustomer();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, title);
            }  
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            Clear();
        }
        #region method
     
        public DataTable vehicleType()
        {
            cm = new SqlCommand("SELECT * FROM tbVehicleType", dbcon.connect());
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dataTable = new DataTable();
            adapter.SelectCommand = cm;
            adapter.Fill(dataTable);
            return dataTable;
        }
        public void Clear()
        {
            txtcarmodel.Clear();
            txtname.Clear();
            txtphone.Clear();
            txtcarno.Clear();
            txtaddress.Clear();
            cbcartype.SelectedIndex = 0;
            udpoints.Value = 0;
            btnsave.Enabled = true;
            btnupdate.Enabled = false;

        }
        public void checkField()
        {
            if (txtaddress.Text == "" || txtname.Text == "" || txtphone.Text == "" || txtcarno.Text == "" || txtcarmodel.Text=="")
            {
                MessageBox.Show("Required data field!", "Warning");
                return;
            }
            
            check = true;
        }
        #endregion method

        private void CustomerModule_Load(object sender, EventArgs e)
        {
            cbcartype.DataSource = vehicleType();
            cbcartype.DisplayMember = "name";
            cbcartype.ValueMember = "id";
            if (vid > 0)
            {
                cbcartype.SelectedValue=vid;
            }
        }
    }
}
