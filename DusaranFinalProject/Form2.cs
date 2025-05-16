using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DusaranFinalProject;
using LibrarySystem;
using MySql.Data.MySqlClient;

namespace DusaranFinalProject
{
    public partial class Form2 : Form
    {
        static MySqlConnection conn = new MySqlConnection("server = localhost; user = root; database = animaldb; password =");
        static MySqlCommand cmd;
        static MySqlDataReader reader;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfPass.Text;

            if (password != confirmPassword)
            {
                MessageBox.Show("Password doesn't match, try again", "Password mismatch");
                return;
            }

            try
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM users WHERE Username = '" + username + "'";
                cmd = new MySqlCommand(checkQuery, conn);

                int userCount = (int)cmd.ExecuteNonQuery();

                if (userCount > 0)
                {
                    MessageBox.Show("Username already exists!");
                    return;
                }

                if (username != null || password != null || confirmPassword != null)
                {
                    string query = "INSERT INTO users (Username, Password, confirmPassword) VALUES (@user, @pass, @cpass)";
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@user", username);
                    cmd.Parameters.AddWithValue("@pass", password);
                    cmd.Parameters.AddWithValue("@cpass", confirmPassword);
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Account successfully created !");
                }
                else
                {
                    MessageBox.Show("Please fill up everything.");
                    return;
                }
               
            }
            catch (Exception ex)
            {
                lblError.Text = "Error: " + ex.Message;
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            frmLogin Login = new frmLogin();
            Login.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            this.Hide();
            login.ShowDialog();
        }
    }
}
