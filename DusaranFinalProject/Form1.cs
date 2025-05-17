using System;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DusaranFinalProject;
using MySql.Data.MySqlClient;

namespace LibrarySystem
{
    public partial class frmLogin : Form    
    {

        static MySqlConnection conn = new MySqlConnection("server = localhost; user = root; database = animaldb; password =");
        MySqlCommand cmd;
        MySqlDataReader reader;
        public frmLogin()
        {
            InitializeComponent();
        }
        private void FrmLogin_Load_1(object sender, EventArgs e)
        {

        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            string user = txtUsername.Text.ToLower();
            string pass = txtPassword.Text;
            string query = "SELECT password FROM users WHERE Username = @username";
            cmd = new MySqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@username", user);
            Dashboard dashboard = new Dashboard();
            PetListingForm petlist = new PetListingForm();
            try
            {
                conn.Open();
                reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string correctPass = reader.GetString("Password");

                    if (user == "admin")
                    {
                        if (correctPass == pass)
                        {
                            MessageBox.Show("Successfully logged in !", "Success");
                            this.Hide();
                            dashboard.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Incorrect Password", "Wrong password");
                        }
                    }
                    else
                    {
                        if (correctPass == pass)
                        {
                            MessageBox.Show("Successfully logged in !", "Success");
                            this.Hide();
                            petlist.ShowDialog();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("No account found !");
                    txtUsername.Text = "";
                    txtPassword.Text = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return;
            }
            finally
            {
                if(reader != null && !reader.IsClosed)
                {
                   reader.Close();
                }
                conn.Close();
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form2 registration = new Form2();
            this.Hide();
            registration.ShowDialog();
        }
    }
}
