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
using System.Diagnostics;

namespace InventoryMS
{
    public partial class ManageOrders : Form
    {
        public ManageOrders()
        {
            InitializeComponent();

        }


        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Omar\Documents\InventoryDB.mdf;Integrated Security=True;Connect Timeout=30");
        DataTable table = new DataTable();
        int num = 0; //order num
        int qty;
        float price, totalPrice;
        string product;
        int prodID;
        int flag = 0;
        float sum = 0;
        int stock;



        private void MO_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MO_minimise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void ReloadForm()
        {
            MO_OrderID.Text = (Convert.ToInt32(MO_OrderID.Text) + Convert.ToInt32(1)).ToString();
            MO_CustID.Text = "Customer ID";
            MO_name.Text = "Customer Name";


        }


        private void ManageOrders_Load(object sender, EventArgs e)
        {

            SqlDataAdapter sda = new SqlDataAdapter("Select isnull(max(cast(OrderId as int)),0) +1 from OrderTbl", con);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            MO_OrderID.Text = dt.Rows[0][0].ToString();

            populate();
            FillCategory();
            populateProducts();

            table.Columns.Add("Order #", typeof(int));
            table.Columns.Add("Product", typeof(string));
            table.Columns.Add("Product ID", typeof(int));
            table.Columns.Add("Quantity", typeof(int));
            table.Columns.Add("Price (GBP)", typeof(float));
            table.Columns.Add("Total Price (GBP)", typeof(float));

            MO_quantityData.DataSource = table;

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
                MO_customers.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
        }

        void populateProducts()
        {
            try
            {
                con.Open();
                string myQuery = "select * from ProductTbl";
                SqlDataAdapter adapter = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                var ds = new DataSet();
                adapter.Fill(ds);
                MO_CatData.DataSource = ds.Tables[0];
                con.Close();
            }
            catch
            {

            }
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
                MO_SearchCombo.ValueMember = "CategoryName";
                MO_SearchCombo.DataSource = dt;
                con.Close();
            }

            catch
            {

            }
        }

        void updateStock()
        {
            int i = 0;

            foreach (DataGridViewRow row in MO_quantityData.Rows)
            {

                int id = Convert.ToInt32(row.Cells[2].Value);
                int cs = Convert.ToInt32(MO_CatData.Rows[i].Cells[2].Value);
                int os = Convert.ToInt32(row.Cells[3].Value);
                int newStock = cs - os;

                i++;

                if (newStock < 0)
                    MessageBox.Show("Operation failed, stock below 0.");
                else
                {
                    con.Open();
                    string query = "update ProductTbl set ProductQuantity = " + newStock + " where ProductId=" + id + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    populateProducts();
                }
            }
        }

        void clearTable()
        {
            table.Clear();

            gbp.Text = "£";
            sum = 0;

        }

        private void MO_customers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (MO_customers.SelectedRows.Count > 0)
            {
                string custID = MO_customers.SelectedRows[0].Cells[0].Value + string.Empty;
                string custName = MO_customers.SelectedRows[0].Cells[1].Value + string.Empty;


                MO_CustID.Text = custID;
                MO_name.Text = custName;

            }

        }

        private void MO_CatData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (MO_CatData.SelectedRows.Count > 0)
            {
                int prodId = Convert.ToInt32(MO_CatData.SelectedRows[0].Cells[0].Value);
                string productName = MO_CatData.SelectedRows[0].Cells[1].Value + string.Empty;
                int stockQty = Convert.ToInt32(MO_CatData.SelectedRows[0].Cells[2].Value);
                float iprice = (float)Convert.ToDouble(MO_CatData.SelectedRows[0].Cells[3].Value);

                flag = 1;

                prodID = prodId;
                product = productName;
                stock = stockQty;
                price = iprice;

            }

        }

        private int FindRowWithId(int id)
        {
            for (int i = 0; i < MO_quantityData.Rows.Count; i++)
            {
                if (Convert.ToInt32(MO_quantityData.Rows[i].Cells[2].Value) == id)
                {
                    return i;
                }
            }
            return -1; // Not found;
        }

        private void MO_addButton_Click(object sender, EventArgs e)
        {

            if (MO_quantity.Text == "" || MO_quantity.Text == "0")
            {
                MessageBox.Show("Enter the Quantity");
            }
            else if (flag == 0)
            {
                MessageBox.Show("Select the Product");
            }
            else if (Convert.ToInt32(MO_quantity.Text) > stock)
            {
                MessageBox.Show("Not enough stock available.");
            }
            else if (MO_quantityData.Rows.Count == 0)
            {
                
                num = num + 1;

                qty = Convert.ToInt32(MO_quantity.Text);

                float totalprice = qty * price;
                totalPrice = totalprice;

                table.Rows.Add(num, product, prodID, qty, price, totalprice);
                MO_quantityData.DataSource = table;
                MO_CatData.Refresh();

                sum += totalPrice;
                gbp.Text = "£" + sum.ToString();
                
                flag = 0;
                
                
            }
            else
            {
                
                int id = Convert.ToInt32(MO_CatData.SelectedRows[0].Cells[0].Value);
                int foundRow = FindRowWithId(id);
                if (foundRow > -1)
                {
                    qty = Convert.ToInt32(MO_quantity.Text);
                    int newQty = Convert.ToInt32(MO_quantityData.Rows[foundRow].Cells[3].Value) + qty;
                    table.Rows[foundRow][3] = newQty;
                    float totalprice = newQty * price;
                    totalPrice = totalprice;
                  

                    table.Rows[foundRow][5] = totalPrice;
                    MO_quantityData.DataSource = table;
                    MO_CatData.Refresh();

                    sum += (qty*price);
                    Console.WriteLine("SUM"+ sum);
                    Console.WriteLine("TOTAL PRICE"+ totalPrice);


                }
                else
                {
                   
                    num = num + 1;

                    qty = Convert.ToInt32(MO_quantity.Text);

                    float totalprice = qty * price;
                    totalPrice = totalprice;

                    table.Rows.Add(num, product, prodID, qty, price, totalprice);
                    MO_quantityData.DataSource = table;
                    MO_CatData.Refresh();

                    flag = 0;
                    sum += totalPrice;
                    Console.WriteLine("SUM" + sum);
                    Console.WriteLine("TOTAL PRICE" + totalPrice);

                }
                
            }
            gbp.Text = "£" + sum.ToString();

        }

        

        private void MO_SearchCombo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                string myQuery = "select * from ProductTbl where ProductCategory = '" + MO_SearchCombo.SelectedValue.ToString() + "'";
                SqlCommand cmd = new SqlCommand(myQuery, con);
                SqlDataAdapter da = new SqlDataAdapter(myQuery, con);
                SqlCommandBuilder builder = new SqlCommandBuilder(da);
                var ds = new DataSet();
                da.Fill(ds);
                MO_CatData.DataSource = ds.Tables[0];
                con.Close();
            }

            catch
            {

            }
        }

        private void MO_insert_Click(object sender, EventArgs e)
        {
            try
            {

                if (MO_OrderID.Text == "Order ID" || MO_CustID.Text == "Customer ID" || MO_name.Text == "Customer Name" || gbp.Text == "")
                {
                    MessageBox.Show("Please Select the Customer");
                }
                else
                {
                    con.Open();
                    
                    SqlCommand cmd = new SqlCommand("insert into OrderTbl values(" + MO_OrderID.Text + "," + MO_CustID.Text + ",'" + MO_name.Text + "','" + Convert.ToDateTime(MO_date.Value).ToString("yyyy-MM-dd") + "'," + gbp.Text + ")", con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Order Successfully added! ");      
                    con.Close();
                    
                    ReloadForm();
                    updateStock();
                    populateProducts();
                    clearTable();
                    

                }
            }
            catch (SqlException ex)
            {
                if (ex.Number == 2627)
                {
                    MessageBox.Show("Order ID exists");
                    con.Close();
                }
                else throw;
            }
        }

        private void MO_view_Click(object sender, EventArgs e)
        {
            ViewOrders view = new ViewOrders();
            view.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HomeForm home = new HomeForm();
            home.Show();
            this.Hide();
        }

        private void MO_delete_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("Are you sure to delete this Order ?",
                                    "Confirm Delete",
                                    MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in MO_quantityData.SelectedRows)
                {
                    string newValue = gbp.Text.Substring(1);
                    float convertValue = (float)Convert.ToDouble(newValue);

                    convertValue -= (float)Convert.ToDouble(row.Cells[5].Value);
                    sum = convertValue;
                    gbp.Text = "£" + convertValue.ToString();

                    MO_quantityData.Rows.RemoveAt(row.Index); 
                }

            }

            else
            {
                //Close Dialogue
            }
        }

        private void MO_refreshButton_Click(object sender, EventArgs e)
        {
            populateProducts();
        }
    }
}
