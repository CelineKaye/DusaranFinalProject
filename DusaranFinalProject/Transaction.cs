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
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DusaranFinalProject
{
    public partial class Transaction : Form
    {
        static MySqlConnection conn = new MySqlConnection("server = localhost; user = root; database = animaldb; password =");
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        int applicationID = -1;
        public Transaction()
        {
            InitializeComponent();
            LoadApplications();
            dgvTransactions.ReadOnly = true;
            dgvTransactions.AllowUserToDeleteRows = false;
            dgvTransactions.AllowUserToResizeColumns = false;
            dgvTransactions.AllowUserToResizeRows = false;
            dgvTransactions.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTransactions.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvTransactions.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTransactions.AllowUserToAddRows = false;
            dgvTransactions.RowHeadersVisible = false;
            dgvTransactions.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }
        private void LoadApplications()
        {
            try
            {
                string query = "SELECT A.ID, U.Username as AdopterName, P.Name as PetName, A.Application, A.Status FROM adoptapplication A JOIN users U ON A.ID = U.userID JOIN pets P ON A.PetID = P.ID;";
                adapter = new MySqlDataAdapter(query, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvTransactions.DataSource = dt;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Transaction_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count == 0) return;
            int appId = Convert.ToInt32(dgvTransactions.SelectedRows[0].Cells["ID"].Value);

            DialogResult result = MessageBox.Show("Are you sure you want to approve this?", "Approve Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if(result == DialogResult.Yes)
            {
                UpdateStatus(appId, "Approved");
                MessageBox.Show("Approved successfully.");
                LoadApplications();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count == 0) return;
            int appId = Convert.ToInt32(dgvTransactions.SelectedRows[0].Cells["ID"].Value);
            DialogResult result = MessageBox.Show("Are you sure you want to reject this?", "Reject Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                UpdateStatus(appId, "Rejected");
                MessageBox.Show("Rejected successfully.");
                LoadApplications();
            }
        }
        private void UpdateStatus(int appId, string status)
        {
            string query = "UPDATE adoptapplication SET Status = @status WHERE ID = @id;";
            try
            {
                conn.Open();
                cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@id", appId);
                cmd.ExecuteNonQuery();

                LoadApplications();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void dgvTransactions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvTransactions.Rows[e.RowIndex];
                applicationID = Convert.ToInt32(row.Cells["ID"].Value);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
