using Bakery_Management;
using Guna.UI2.WinForms;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Bakery_Management
{
    public partial class Menu : Form
    {
        int maxCartItems = 2;
        int cartIndex = 0;
        decimal totalPrice = 0m;
        List<Guna2GroupBox> cartItems = new List<Guna2GroupBox>();

        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            // Nothing needed here for now
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            new Account().Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            new Order().Show();
            this.Hide();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new customerLogin().Show();
            this.Hide();
        }

        // Universal method to handle all "Add to Cart" buttons
        private void HandleAddToCart(string productName, decimal unitPrice, Guna2Button senderButton)
        {
            if (cartItems.Count >= maxCartItems)
            {
                MessageBox.Show("Maximum order is only 2.");
                return;
            }

            Control productBox = senderButton.Parent;

            // Get quantity from NumericUpDown in the same product panel
            Guna.UI2.WinForms.Guna2NumericUpDown qtySelector = productBox.Controls
     .OfType<Guna.UI2.WinForms.Guna2NumericUpDown>()
     .FirstOrDefault();


            int quantity = (int)(qtySelector?.Value ?? 0);


            if (quantity <= 0)
            {
                MessageBox.Show("Please select quantity.");
                return;
            }

            decimal itemTotal = unitPrice * quantity;
            totalPrice += itemTotal;

            AddCartItem(productName, unitPrice, quantity, itemTotal);
        }

        private void AddCartItem(string name, decimal unitPrice, int quantity, decimal total)
        {

            var cartBox = new Guna2GroupBox
            {
                Size = new Size(231, 130),
                BorderRadius = 10,
                BorderColor = Color.FromArgb(223, 235, 253),
                BackColor = Color.White,
                BorderThickness = 3,
                ForeColor = Color.FromArgb(254, 205, 224),
                CustomBorderThickness = new Padding(0, 0, 0, 0), // Remove top header thickness
                FillColor = Color.White, // Make sure it's the same as BackColor
              
            };

            Label lblName = new Label
            {
                Name = "lblName",
                Text = name,
                ForeColor = Color.FromArgb(254, 205, 224),
                AutoSize = true,
                Font = new Font("Arial Rounded MT", 10, FontStyle.Bold)

            };

            lblName.Location = new Point(
    (cartBox.Width - lblName.PreferredWidth) / 2,
    12 // Y-position remains near the top
);

            Guna2TextBox txtQty = new Guna2TextBox
            {
                Name = "txtQty",
                Text = $"Quantity: {quantity}",
                Location = new Point(10, 70),
                ForeColor = Color.FromArgb(254, 205, 224),
                Font = new Font("Arial Rounded MT", 10, FontStyle.Bold),
                BorderRadius = 22,
                BorderThickness = 3,
                BorderColor = Color.FromArgb(223, 235, 253),
                BackColor = Color.White,
                FillColor = Color.White,
                Size = new Size (105,45),
                TextAlign = HorizontalAlignment.Center,
                AutoSize = false
            };

            Label lblPrice = new Label
            {
                Name = "lblPrice",
                Text = $"RM {total:F2}",
                Location = new Point(100, 42),
                ForeColor = Color.FromArgb(250, 239, 217),
                Font = new Font("Arial Rounded MT", 11, FontStyle.Bold),
                AutoSize = true
            };

            lblPrice.Location = new Point(
    (cartBox.Width - lblPrice.PreferredWidth) / 2,
    42 // Y-position to your liking
       );

            Guna2Button btnRemove = new Guna2Button
            {
                Text = "Remove",
                Size = new Size(90, 45),
                Location = new Point(128, 74),
                FillColor = Color.FromArgb(254, 205, 224),
                Font = new Font("Arial Rounded MT", 10, FontStyle.Bold),
                ForeColor = Color.White,
                BorderRadius = 23,
                BorderThickness = 2,
                BackColor = Color.White,
                BorderColor = Color.FromArgb(254, 205, 224)
            };

            btnRemove.Click += (s, e) =>
            {
                cartPanel.Controls.Remove(cartBox);
                cartItems.Remove(cartBox);
                totalPrice -= total;
                UpdateTotalLabel();
                cartIndex--;
            };

            cartBox.Controls.Add(lblName);
            cartBox.Controls.Add(txtQty);
            cartBox.Controls.Add(lblPrice);
            cartBox.Controls.Add(btnRemove);

            cartItems.Add(cartBox);
            cartPanel.Controls.Add(cartBox);
            int yOffset = 148;
            cartBox.Location = new Point(19, yOffset + (cartIndex * 160));
            cartIndex++;

            UpdateTotalLabel();
        }

        private void UpdateTotalLabel()
        {
            lblTotal.Text = $"RM {totalPrice:F2}";
        }

        // Event handlers for each button — map them to actual values
        private void btnAddDonut_Click(object sender, EventArgs e)
        {
            HandleAddToCart("Strawberry Donut Cake", 30.00m, sender as Guna2Button);
        }

        private void btnAddFrosting_Click(object sender, EventArgs e)
        {
            HandleAddToCart("Strawberry Frosting Cake", 40.00m, sender as Guna2Button);
        }

        private void btnAddSugar_Click(object sender, EventArgs e)
        {
            HandleAddToCart("Strawberry Sugar Cake", 45.00m, sender as Guna2Button);
        }

        private void btnAddClassic_Click(object sender, EventArgs e)
        {
            HandleAddToCart("Strawberry Classic Cake", 50.00m, sender as Guna2Button);
        }
 
        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
      
            if (cartItems.Count == 0)
            {
                MessageBox.Show("Cart is empty!");
                return;
            }

            // Determine method with proper validation
            string method = "";

            if (chkDineIn.Checked && !chkTakeAway.Checked)
            {
                method = "Dine In";
            }
            else if (chkTakeAway.Checked && !chkDineIn.Checked)
            {
                method = "Take Away";
            }
            else if (chkDineIn.Checked && chkTakeAway.Checked)
            {
                MessageBox.Show("Please select only one order method.");
                return;
            }
            else
            {
                MessageBox.Show("Please select an order method.");
                return;
            }

            string connStr = "server=localhost;user=root;password=;database=userdb";
            using (MySqlConnection conn = new MySqlConnection(connStr))
            {
                conn.Open();

                // 🔢 Generate a new order_id
                int newOrderId = 1;
                string getMaxOrderId = "SELECT MAX(order_id) FROM orders";
                using (MySqlCommand cmd = new MySqlCommand(getMaxOrderId, conn))
                {
                    object result = cmd.ExecuteScalar();
                    if (result != DBNull.Value)
                    {
                        newOrderId = Convert.ToInt32(result) + 1;
                    }
                }

                // 💾 Store globally for use in order.cs
                GlobalState.CurrentOrderId = newOrderId;

                // Step 1: Calculate grand total of all items
                decimal grandTotal = 0;

                foreach (var box in cartItems)
                {
                    string itemTotalRaw = box.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == "lblPrice")?.Text ?? "RM 0.00";
                    decimal itemTotal = decimal.TryParse(itemTotalRaw.Replace("RM", "").Trim(), out decimal totalParsed) ? totalParsed : 0;
                    grandTotal += itemTotal;
                }

                // Step 2: Insert each item (price_each = total for the item)
                foreach (var box in cartItems)
                {
                    string itemName = box.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == "lblName")?.Text ?? "";

                    string itemQtyRaw = box.Controls.OfType<Guna2TextBox>().FirstOrDefault()?.Text ?? "Quantity: 0";
                    int itemQty = int.TryParse(itemQtyRaw.Replace("Quantity:", "").Trim(), out int qtyParsed) ? qtyParsed : 0;

                    string itemTotalRaw = box.Controls.OfType<Label>().FirstOrDefault(lbl => lbl.Name == "lblPrice")?.Text ?? "RM 0.00";
                    decimal itemTotal = decimal.TryParse(itemTotalRaw.Replace("RM", "").Trim(), out decimal totalParsed) ? totalParsed : 0;

                    // No division here, because price_each is total for the product
                    decimal itemPriceEach = itemTotal; // This is the total for that product

                    string sql = "INSERT INTO orders (order_id, product_name, quantity, price_each, total, method) " +
             "VALUES (@orderId, @name, @qty, @priceEach, @total, @method)";


                    try
                    {
                        using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                        {
                            cmd.Parameters.AddWithValue("@name", itemName);
                            cmd.Parameters.AddWithValue("@qty", itemQty);
                            cmd.Parameters.AddWithValue("@priceEach", itemPriceEach); // total for that item
                            cmd.Parameters.AddWithValue("@total", grandTotal);        // total for whole order
                            cmd.Parameters.AddWithValue("@method", method);
                            cmd.Parameters.AddWithValue("@orderId", newOrderId);

                            cmd.ExecuteNonQuery();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error inserting order: " + ex.Message);
                    }
                }



                MessageBox.Show("Order placed successfully!");


                // ✅ Only remove GroupBoxes (not labels, checkboxes, etc.)
                foreach (Control ctrl in cartPanel.Controls.OfType<Guna.UI2.WinForms.Guna2GroupBox>().ToList())
                {
                    cartPanel.Controls.Remove(ctrl);
                    ctrl.Dispose();
                }

                // Reset UI and state

                cartItems.Clear();
                totalPrice = 0;
                cartIndex = 0;
                UpdateTotalLabel();
                chkDineIn.Checked = false;
                chkTakeAway.Checked = false;
            }
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
