﻿using System;
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
    public partial class ViewOrders : Form
    {
        public ViewOrders()
        {
            InitializeComponent();
        }

        //4;36;28
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Omar\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void VO_close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void VO_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ViewOrders_Load(object sender, EventArgs e)
        {
            populateProducts();
        }

        void populateProducts()
        {
            try
            {
                con.Open();
                string myQuery = "select * from OrderTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                VO_data.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        private void VO_data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            

           
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            System.Drawing.Image img = System.Drawing.Image.FromFile(@"E:\Program Files (x86)\Microsoft Visual Studio\projects\repos\InventoryMS\resources\logo_print.png");
            Point loc = new Point(0, 0);
            e.Graphics.DrawImage(img, loc);
            e.Graphics.DrawString("Order Summary", new Font("Arial",25, FontStyle.Bold | FontStyle.Underline), Brushes.Black, new Point(280,50));
            e.Graphics.DrawString("Order ID:" + VO_data.SelectedRows[0].Cells[0].Value.ToString(), new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(80, 150));
            e.Graphics.DrawString("Customer ID:" + VO_data.SelectedRows[0].Cells[1].Value.ToString(), new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(80, 200));
            e.Graphics.DrawString("Customer Name:" + VO_data.SelectedRows[0].Cells[2].Value.ToString(), new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(80, 250));
            e.Graphics.DrawString("Order Date:" + VO_data.SelectedRows[0].Cells[3].Value.ToString().Substring(0,8), new Font("Arial", 20, FontStyle.Bold), Brushes.Black, new Point(80, 300));
            e.Graphics.DrawString("Order Total: £" + VO_data.SelectedRows[0].Cells[4].Value.ToString(), new Font("Arial", 20, FontStyle.Bold), Brushes.Red, new Point(80, 350));
            e.Graphics.DrawString("Invoice Generated by OIMS", new Font("Arial", 16, FontStyle.Bold), Brushes.Black, new Point(230, 500));
        }

        private void VO_delete_Click(object sender, EventArgs e)
        {

            var confirmResult = MessageBox.Show("Are you sure to delete this Customer ?",
                                    "Confirm Delete",
                                    MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in VO_data.SelectedRows)
                {

                    con.Open();
                    SqlCommand cmd = new SqlCommand("DELETE FROM OrderTbl WHERE OrderId = '" + VO_data.SelectedRows[0].Cells[0].Value.ToString() + "'", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Successfully Deleted");
                    con.Close();
                    VO_data.Rows.RemoveAt(row.Index);
                    populateProducts();
                }
            }
            else
            {
                //Do Nothing
            }
            
        }

        private void VO_print_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                //printDocument1.Print();
            }
        }
    }
}