using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Windows.Forms;


namespace Bakery_Management
{
    public partial class Account : Form
    {
        private string connectionString = "server=localhost;uid=root;pwd=;database=userdb";
        private string loggedInUsername;

        // ✅ Accept username from login
        public Account()
        {
            InitializeComponent();
            // ✅ Get logged-in username from session
            loggedInUsername = Session.LoggedInUsername;
            // ✅ Load account data
            LoadCustomerDetails();
        }

        private void LoadCustomerDetails()
        {
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                string query = "SELECT username, password FROM customers WHERE username = @username";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@username", loggedInUsername);

                try
                {
                    conn.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        txtUsername.Text = reader["username"].ToString();
                        txtPassword.Text = reader["password"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("❌ User not found.");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            new Menu().Show();
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
    }
}
