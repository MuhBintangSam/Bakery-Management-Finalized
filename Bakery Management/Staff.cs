using Bakery_Management_staff;
using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace Bakery_Management
{
    public partial class staffLogin : Form
    {
        // ✅ Place this inside the class, NOT before it
        string connectionString = "server=localhost;user=root;password=;database=userdb;";

        public staffLogin()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Optional: You can leave this empty or load default data
        }

        private void btnLoginStaff_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT * FROM staff WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        Form5 Form5 = new Form5(); // 'Menu' is the class name from Menu.cs
                        Form5.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show("❌ Invalid staff credentials.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("⚠️ Error: " + ex.Message);
                }
            }
        }

        private void guna2PanelWhite_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
