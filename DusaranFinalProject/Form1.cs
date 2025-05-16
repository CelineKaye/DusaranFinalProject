using System;
using System.Data;
using System.Data.OleDb;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
using DusaranFinalProject;

namespace LibrarySystem
{
    public partial class frmLogin : Form
    {

        private OleDbConnection conn;
        public frmLogin()
        {
            InitializeComponent();
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Downloads\DusaranFinalProject-1\DusaranFinalProject\CatandDogs.mdb");



        }
        public bool VerifyPassword(string enteredPassword, string storedHashedPassword)
        {
            return HashPassword(enteredPassword) == storedHashedPassword;
        }

        public string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder builder = new StringBuilder();
                foreach (byte b in bytes)
                {
                    builder.Append(b.ToString("x2"));
                }
                return builder.ToString();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

    

        private void frmLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void FrmLogin_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            conn.Open();
            string usname = txtUsername.Text;

            string query = "SELECT [Password] FROM [Users] WHERE Username = '" + usname + "'";

            OleDbCommand cmd = new OleDbCommand(query, conn);

            object result = cmd.ExecuteScalar();


            if (result != null)
            {
                string storedHashedPassword = result.ToString();
                string enteredPassword = txtPassword.Text;

                if (VerifyPassword(enteredPassword, storedHashedPassword))
                {
                    this.Hide();
                    string usertype = "SELECT [UserType] FROM [Users] WHERE Username = '" + usname + "'";
                    OleDbCommand cmd2 = new OleDbCommand(usertype, conn);

                    object result2 = cmd2.ExecuteScalar();

                    Dashboard dashboard = new Dashboard(result2.ToString());
                    dashboard.Show();
                    return;
                }
            }

            lblError.Text = "Invalid Username or Password";
            conn.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
        }
    }
}
