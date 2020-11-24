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
    public partial class ManageCategories : Form
    {
        public ManageCategories()
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
                string myQuery = "select * from CategoryTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                MCat_data.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        private void ReloadForm()
        {
            MCat_id.Text = (Convert.ToInt32(MCat_id.Text) + Convert.ToInt32(1)).ToString();
            MCat_name.Text = "Category Name";
            MCat_data.Update();

        }

        private void postDelete()
        {
            MCat_id.Refresh();
            MCat_name.Text = "Category Name";
            MCat_data.Update();

        }

        private void MCat_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MCat_data.SelectedRows.Count > 0)
            {
                string categoryId = MCat_data.SelectedRows[0].Cells[0].Value + string.Empty;
                string categoryName = MCat_data.SelectedRows[0].Cells[1].Value + string.Empty;


                MCat_id.Text = categoryId;
                MCat_name.Text = categoryName;

            }
        }

        private void MC_addButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT into CategoryTbl values('" + MCat_id.Text + "', '" + MCat_name.Text + "')", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category added Successfully!");
                con.Close();
                populate();
                ReloadForm();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Category ID already exists");
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
                SqlCommand cmd = new SqlCommand("UPDATE CategoryTbl set CategoryName = '" + MCat_name.Text + "' WHERE CategoryId = '" + MCat_id.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Updated Successfully!");
                con.Close();
                populate();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Cannot Modify Category ID; Changes Cancelled.");
                    con.Close();
                }

                else throw;
            }
        }

        private void MC_delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this Category ?",
                                     "Confirm Delete",
                                     MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM CategoryTbl WHERE CategoryId = '" + MCat_id.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Category Successfully Deleted");
                con.Close();
                postDelete();
                populate();
            }
            else
            {
                //Do Nothing
            }
        }

        private void ManageCategories_Load(object sender, EventArgs e)
        {
            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(CategoryId as int)),0) +1 from CategoryTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MCat_id.Text = dt.Rows[0][0].ToString();
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
