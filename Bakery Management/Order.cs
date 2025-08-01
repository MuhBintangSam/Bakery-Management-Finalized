using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery_Management
{
    public partial class Order : Form
    {
        string connStr = "server=localhost;user=root;password=;database=userdb;";
        public Order()
        {
            InitializeComponent();
          
        }

        private void Order_Load(object sender, EventArgs e)
        {
     
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // Get the latest shared order_id (not individual row ID)
                string getLatestOrderId = "SELECT MAX(order_id) FROM orders";
                int latestOrderId = 0;

                using (MySqlCommand cmd = new MySqlCommand(getLatestOrderId, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != null && int.TryParse(result.ToString(), out int orderId))
                    {
                        latestOrderId = orderId;
                    }
                    else
                    {
                        MessageBox.Show("No orders found.");
                        return;
                    }
                }

                // Retrieve all items with the same order_id
                string query = "SELECT * FROM orders WHERE order_id = @orderId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@orderId", latestOrderId);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        int index = 1;
                        decimal totalSum = 0;
                        string method = "";

                        while (reader.Read())
                        {
                            string name = reader["product_name"].ToString();
                            int qty = Convert.ToInt32(reader["quantity"]);
                            decimal priceEach = Convert.ToDecimal(reader["price_each"]);
                            decimal itemTotal = Convert.ToDecimal(reader["price_each"]); // price_each = total for that product
                            method = reader["method"].ToString();
                            totalSum += itemTotal;

                            // Display in appropriate UI labels
                            if (index == 1)
                            {
                                lblName1.Text = name;
                                txtQuantity1.Text = $"Quantity : {qty}";
                                lblPrice1.Text = $"RM {priceEach}";
                            }
                            else if (index == 2)
                            {
                                lblName2.Text = name;
                                txtQuantity2.Text = $"Quantity : {qty}";
                                lblPrice2.Text = $"RM {priceEach}";
                            }

                            index++;
                        }

                        // Display order info
                        txtOrder.Text = $"Order #{latestOrderId}";
                        txtMethod.Text = $"Method : {method}";
                        txtTotal.Text = $"Total : RM{totalSum}";
                    }
                }
            }
        

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            new customerLogin
                ().Show(); this.Hide();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {

        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
            this.Hide();
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            new Account().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new customerLogin().Show();
            this.Hide();
        }
    }
}
