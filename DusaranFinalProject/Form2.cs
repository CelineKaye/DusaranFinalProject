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
using LibrarySystem;

namespace DusaranFinalProject
{
    public partial class Form2 : Form
    {
        private OleDbConnection conn;

        public Form2()
        {
            InitializeComponent();
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Downloads\DusaranFinalProject-1\DusaranFinalProject\CatandDogs.mdb");

        }

        private string HashPassword(string password)
        {
            using (System.Security.Cryptography.SHA256 sha256 = System.Security.Cryptography.SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
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
                lblError.Text = "Passwords do not match!";
                return;
            }

            string hashedPassword = HashPassword(password);

            try
            {
                conn.Open();

                string checkQuery = "SELECT COUNT(*) FROM [Users] WHERE Username = '" + username + "'";
                OleDbCommand checkCmd = new OleDbCommand(checkQuery, conn);
                int userCount = (int)checkCmd.ExecuteScalar();

                if (userCount > 0)
                {
                    lblError.Text = "Username already exists!";
                    conn.Close();
                    return;
                }

                string query = "INSERT INTO [Users] (Username, [Password], UserType) VALUES ('" + username + "', '" + hashedPassword + "', 'common')";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.ExecuteNonQuery();

                lblError.ForeColor = Color.Green;
                lblError.Text = "Registration successful!";

                this.Hide();
               
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
    }
}
