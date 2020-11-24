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
    public partial class ManageUsers : Form
    {
        public ManageUsers()
        {
            InitializeComponent();


        }

        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Omar\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void MU_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        void populate()
        {
            try
            {
                con.Open();
                string myQuery = "select * from UserTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                MU_data.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }
        private void MU_data_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (MU_data.SelectedRows.Count > 0)
            {
                string userName = MU_data.SelectedRows[0].Cells[0].Value + string.Empty;
                string fullName = MU_data.SelectedRows[0].Cells[1].Value + string.Empty;
                string pass = MU_data.SelectedRows[0].Cells[2].Value + string.Empty;
                string phone = MU_data.SelectedRows[0].Cells[3].Value + string.Empty;

                MU_username.Text = userName;
                MU_fullName.Text = fullName;
                MU_Password.Text = pass;
                MU_telephone.Text = phone;
            }
        }

        private void MU_addButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("INSERT into UserTbl values('" + MU_username.Text + "', '" + MU_fullName.Text + "', '" + MU_Password.Text + "', '" + MU_telephone.Text + "' )", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User added Successfully!");
                con.Close();
                populate();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Username already exists");
                    con.Close();
                }
                else throw;
            }
        }


        private void ManageUsers_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void MU_delete_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure to delete this User ?",
                                    "Confirm Delete",
                                    MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM UserTbl WHERE username = '" + MU_username.Text + "'", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Successfully Deleted");
                con.Close();
                populate();
            }

            else
            {
                //Close Dialogue
            }
        }

        private void MU_editButton_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("UPDATE UserTbl set fullname = '" + MU_fullName.Text + "', password = '" + MU_Password.Text + "', telephone = '" + MU_telephone.Text + "' WHERE username = '" + MU_username.Text + "' ", con);
                cmd.ExecuteNonQuery();
                MessageBox.Show("User Updated Successfully!");
                con.Close();
                populate();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Cannot Modify Username; Changes Cancelled.");
                    con.Close();
                }

                else throw;
            }
        }

        private void MP_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void MU_Home_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }
    }
}
