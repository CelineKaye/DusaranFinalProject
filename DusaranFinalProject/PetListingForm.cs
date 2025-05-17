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
using MySql.Data.MySqlClient;

namespace DusaranFinalProject
{
    public partial class PetListingForm : Form
    {
        static MySqlConnection conn = new MySqlConnection("server = localhost; user = root; database = animaldb; password =");
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;

        int currentUserID;

        public PetListingForm()
        {
            InitializeComponent();
            dgvPetList.ReadOnly = true;
            dgvPetList.AllowUserToDeleteRows = false;
            dgvPetList.AllowUserToResizeColumns = false;
            dgvPetList.AllowUserToResizeRows = false;
            dgvPetList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPetList.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvPetList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPetList.AllowUserToAddRows = false;
            dgvPetList.RowHeadersVisible = false;
            dgvPetList.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            //txtID.ReadOnly = true;
        }
        private void LoadPets()
        {
            try
            {
                conn.Open();

                string query = "SELECT * FROM Pets WHERE Status = 'Available';";
                adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dgvPetList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pet data: " + ex.Message, "LoadPets Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }


        private void PetListingForm_Load(object sender, EventArgs e)
        {
            LoadPets();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvPetList.SelectedRows.Count == 0) return;
            int petId = Convert.ToInt32(dgvPetList.SelectedRows[0].Cells["ID"].Value);
            new AdoptionApplicationForm(petId, currentUserID).ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ApplicationStatus status = new ApplicationStatus();
            status.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin form = new frmLogin();
            form.ShowDialog();
        }
    }
}
