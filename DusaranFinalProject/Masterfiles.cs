using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DusaranFinalProject
{
    public partial class Masterfiles : Form
    {
        static MySqlConnection conn = new MySqlConnection("server = localhost; user = root; database = animaldb; password =");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        MySqlDataReader reader;
        int selectedPet = -1;
        public Masterfiles()
        {
            InitializeComponent();
            refreshGrid();
            dgvPets.ReadOnly = true;
            dgvPets.AllowUserToDeleteRows = false;
            dgvPets.AllowUserToResizeColumns = false;
            dgvPets.AllowUserToResizeRows = false;
            dgvPets.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPets.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPets.AllowUserToAddRows = false;
            dgvPets.RowHeadersVisible = false;
            dgvPets.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            txtID.ReadOnly = true;
        }

        private void refreshGrid()
        {
            string query = "select ID, Name, Type, Breed, Status from pets;";
            try
            {
                conn.Open();
                adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvPets.DataSource = null;
                dgvPets.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
        private void LoadPets()
        {
            try
            {
                string query = "select ID, Name, Type, Breed, Status from pets;";
                adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvPets.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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


        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Masterfiles_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Dashboard admin = new Dashboard();
            this.Hide();
            admin.ShowDialog();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string type = txtType.Text;
            string status = txtStatus.Text;
            string breed = txtBreed.Text;



            try
            {
                conn.Open();
                string query = "INSERT INTO pets (Name, Type, Breed, Status) VALUES (@name, @type, @breed, @status);";
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@type", type);
                cmd.Parameters.AddWithValue("@breed", breed);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Pet successfully added.");
                LoadPets();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvPets_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvPets.Rows[e.RowIndex];
                selectedPet = Convert.ToInt32(row.Cells["ID"].Value);

                txtID.Text = row.Cells["ID"].Value.ToString();
                txtName.Text = row.Cells["Name"].Value.ToString();
                txtType.Text = row.Cells["Type"].Value.ToString();
                txtBreed.Text = row.Cells["Breed"].Value.ToString();
                txtStatus.Text = row.Cells["Status"].Value.ToString();
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            if (selectedPet == -1)
            {
                MessageBox.Show("Please select a pet to update.", "No pet found");
                return;
            }

            string query = "UPDATE pets SET Name = @name, Type = @type, Status = @status, Breed = @breed WHERE ID = @id";

            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@id", txtID.Text);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@type", txtType.Text);
                cmd.Parameters.AddWithValue("@status", txtStatus.Text);
                cmd.Parameters.AddWithValue("@breed", txtBreed.Text);

                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Pet successfully updated.");
                    LoadPets();
                    txtID.Text = "";
                    txtName.Text = "";
                    txtType.Text = "";
                    txtStatus.Text = "";
                    txtBreed.Text = "";
                }
                else
                {
                    MessageBox.Show("Error updating pet.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (selectedPet == -1)
            {
                MessageBox.Show("Please select a pet to update.", "No pet found");
                return;
            }

            DialogResult result = MessageBox.Show("Are you sure you want to delete this information?", "Remove Pet Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM pets WHERE ID = @id";
                try
                {
                    conn.Open();
                    cmd = new MySqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@id", txtID.Text);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Pet successfully deleted.");
                        LoadPets();
                        txtID.Text = "";
                        txtName.Text = "";
                        txtType.Text = "";
                        txtStatus.Text = "";
                        txtBreed.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Error deleting pet.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}

