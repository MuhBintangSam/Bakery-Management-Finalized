using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Windows.Forms;

namespace Bakery_Management
{
    public partial class customerLogin : Form
    {
        string connectionString = "server=localhost;user=root;password=;database=userdb;";

        public customerLogin()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // Optional: Add load logic here
        }

        private void btnLoginCustomer_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM customers WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {

                        // ✅ Store the logged-in username
                        Session.LoggedInUsername = username;

                        Menu menuForm = new Menu(); // 'Menu' is the class name from Menu.cs
                        menuForm.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("❌ Invalid customer credentials.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("⚠️ Error: " + ex.Message);
                }
            }
        }
         private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void guna2ButtonStaff_Click(object sender, EventArgs e)
        {
            new staffLogin().Show(); this.Hide();

        }
        private void guna2PanelWhite_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
