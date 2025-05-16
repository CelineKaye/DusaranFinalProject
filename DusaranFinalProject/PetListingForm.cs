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

namespace DusaranFinalProject
{
    public partial class PetListingForm : Form
    {
        private OleDbConnection conn;

        int currentUserID;

        public PetListingForm()
        {
            InitializeComponent();
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Downloads\DusaranFinalProject-1\DusaranFinalProject\CatandDogs.mdb");

        }
        private void LoadPets()
        {
            try
            {
                conn.Open();

                string query = "SELECT * FROM Pets WHERE Status = 'Available'";
                OleDbDataAdapter da = new OleDbDataAdapter(query, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                dgvPetList.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading pet data: " + ex.Message, "LoadPets Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
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
            int petId = Convert.ToInt32(dgvPetList.SelectedRows[0].Cells["PetID"].Value);
            new AdoptionApplicationForm(petId, currentUserID).Show();
        }
    }
}
