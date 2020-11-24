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
    public partial class ManageProducts : Form
    {
        public ManageProducts()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Omar\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void MCat_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void FillCategory()
        {
            string myQuery = "select * from CategoryTbl";
            SqlCommand cmd = new SqlCommand(myQuery, con);
            SqlDataReader sdr;

            try
            {
                con.Open();
                DataTable dt = new DataTable();
                dt.Columns.Add("CategoryName", typeof(string));
                sdr = cmd.ExecuteReader();
                dt.Load(sdr);
                MP_category.ValueMember = "CategoryName";
                MP_category.DataSource = dt;
                SearchCombo.ValueMember = "CategoryName";
                SearchCombo.DataSource = dt;
                con.Close();
            }

            catch
            {

            }
        }

        void FillSearch()
        {

            try
            {
                con.Open();
                string myQuery = "select * from ProductTbl where ProductCategory = '" + SearchCombo.SelectedValue.ToString() + "'";
                SqlCommand cmd = new SqlCommand(myQuery, con);
                SqlDataAdapter da = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                MP_data.DataSource = ds.Tables[0];
                con.Close();
            }

            catch
            {

            }
        }

        void populate()
        {
            try
            {
                con.Open();
                string myQuery = "select * from ProductTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                MP_data.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        private void ReloadForm()
        {
            this.Refresh();
            MP_id.Text = (Convert.ToInt32(MP_id.Text) + Convert.ToInt32(1)).ToString();
            MP_name.Text = "Product Name";
            MP_quantity.Text = "Product Quantity";
            MP_price.Text = "Product Price";
            MP_description.Text = "Description";

            
            MP_data.Update();

        }



        private void ManageProducts_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(ProductId as int)),0) +1 from ProductTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MP_id.Text = dt.Rows[0][0].ToString();

            FillCategory();
            populate();
        }

        private void MC_addButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("insert into ProductTbl values(" + MP_id.Text + ",'" + MP_name.Text + "'," + MP_quantity.Text + "," + MP_price.Text + ",'" + MP_description.Text + "','" + MP_category.SelectedValue.ToString() + "')", con); cmd.ExecuteNonQuery();
                MessageBox.Show("Product added Successfully!");
                con.Close();
                populate();
                ReloadForm();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Product ID exists");
                    con.Close();
                }
                else throw;
            }
        }

        private void MP_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MP_data.SelectedRows.Count > 0)
            {
                string productID = MP_data.SelectedRows[0].Cells[0].Value + string.Empty;
                string productName = MP_data.SelectedRows[0].Cells[1].Value + string.Empty;
                string productQuantity = MP_data.SelectedRows[0].Cells[2].Value + string.Empty;
                string productPrice = MP_data.SelectedRows[0].Cells[3].Value + string.Empty;
                string productDescription = MP_data.SelectedRows[0].Cells[4].Value + string.Empty;
                string productCategory = MP_data.SelectedRows[0].Cells[5].Value + string.Empty;


                MP_id.Text = productID;
                MP_name.Text = productName;
                MP_quantity.Text = productQuantity;
                MP_price.Text = productPrice;
                MP_description.Text = productDescription;
                MP_category.Text = productCategory;

            }
        }

        private void MC_editButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE ProductTbl set ProductName = '" + MP_name.Text + "', ProductQuantity = '" + MP_quantity.Text + "', ProductPrice = '" + MP_price.Text + "', ProductDescription = '" + MP_description.Text + "', ProductCategory='" + MP_category.SelectedValue.ToString() + "' WHERE ProductId = '" + MP_id.Text + "' ", con);
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

        private void MC_delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this Product ?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM ProductTbl WHERE ProductId = '" + MP_id.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Product Successfully Deleted");
                con.Close();
                ReloadForm();
                populate();
            }
            else
            {
                //Do Nothing
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            FillSearch();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            populate();
        }

        private void MP_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void SearchCombo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MC_Home_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
