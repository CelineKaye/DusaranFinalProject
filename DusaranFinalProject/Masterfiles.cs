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
using System.Xml.Linq;

namespace DusaranFinalProject
{
    public partial class Masterfiles : Form
    {
        private OleDbConnection conn;

        public Masterfiles()
        {
            InitializeComponent();
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Downloads\DusaranFinalProject-1\DusaranFinalProject\CatandDogs.mdb");

            LoadPets();

        }
        private void LoadPets()
        {
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM tblPets", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvPets.DataSource = dt;
            conn.Close();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

            conn.Open();
            OleDbCommand cmd = new OleDbCommand("INSERT INTO tblPets (Name, Type, Breed, Age, Status) VALUES (@name, @type, @breed, @age, 'Available')", conn);
            cmd.Parameters.AddWithValue("@name", txtName.Text);
            cmd.Parameters.AddWithValue("@type", cboType.Text);
            cmd.Parameters.AddWithValue("@breed", txtBreed.Text);
            cmd.Parameters.AddWithValue("@age", txtAge.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadPets();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Masterfiles_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
