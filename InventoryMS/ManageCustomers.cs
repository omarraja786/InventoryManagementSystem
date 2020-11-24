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

namespace InventoryMS
{
    public partial class ManageCustomers : Form
    {
        public ManageCustomers()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Omar\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void MU_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                con.Open();
                string myQuery = "select * from CustomerTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                MC_data.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        private void ReloadForm()
        {
            MC_id.Text = (Convert.ToInt32(MC_id.Text) + Convert.ToInt32(1)).ToString();
            MC_name.Text = "Customer Name";
            MC_telephone.Text = "Telephone Number";
            MC_data.Update();
 
        }


        private void MC_addButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT into CustomerTbl values('" + MC_id.Text + "', '" + MC_name.Text + "', '" + MC_telephone.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer added Successfully!");
                con.Close();
                populate();
                ReloadForm();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Customer ID exists");
                    con.Close();
                }
                else throw;
            }
        }

        private void MC_editButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE CustomerTbl set CustName = '" + MC_name.Text + "', CustTelephone = '" + MC_telephone.Text + "' WHERE CustId = '" + MC_id.Text + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Updated Successfully!");
                con.Close();
                populate();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Cannot Modify Customer ID; Changes Cancelled.");
                    con.Close();
                }

                else throw;
            }

        }

        private void MC_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MC_data.SelectedRows.Count > 0)
            {
                string custID = MC_data.SelectedRows[0].Cells[0].Value + string.Empty;
                string custName = MC_data.SelectedRows[0].Cells[1].Value + string.Empty;
                string custTelephone = MC_data.SelectedRows[0].Cells[2].Value + string.Empty;


                MC_id.Text = custID;
                MC_name.Text = custName;
                MC_telephone.Text = custTelephone;

                con.Open();
                SqlDataAdapter sda = new SqlDataAdapter("select Count(*) from OrderTbl where CustId = " + MC_id.Text + "", con);
                DataTable dt = new DataTable();
                sda.Fill(dt);
                OC_Orders.Text = dt.Rows[0][0].ToString();

                SqlDataAdapter sda2 = new SqlDataAdapter("select Sum(TotalAmt) from OrderTbl where CustId = " + MC_id.Text + "", con);
                DataTable dt1 = new DataTable();
                sda2.Fill(dt1);
                OA_Amount.Text = "£" + dt1.Rows[0][0].ToString();

                SqlDataAdapter sda3 = new SqlDataAdapter("select Max(OrderDate) from OrderTbl where CustId = " + MC_id.Text + "", con);
                DataTable dt2 = new DataTable();
                sda3.Fill(dt2);
                LOD_Date.Text = dt2.Rows[0][0].ToString().Substring(0,8);

                con.Close();

            }
        }

        private void MC_delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this Customer ?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM CustomerTbl WHERE Custid = '" + MC_id.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Customer Successfully Deleted");
                con.Close();
                populate();
            }
            else
            {
                //Do Nothing
            }

            
        }

        private void ManageCustomers_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(CustId as int)),0) +1 from CustomerTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MC_id.Text = dt.Rows[0][0].ToString();
            populate();
        }

        private void MP_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MC_Home_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
