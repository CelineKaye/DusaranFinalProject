using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using MySql.Data.MySqlClient;

namespace DusaranFinalProject
{
    public partial class Report : Form
    {
        static MySqlConnection conn = new MySqlConnection("server=localhost; user=root; database=animaldb; password=");
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        DataTable dt;

        public Report()
        {
            InitializeComponent();
            // Adjust form controls like DataGridView here as needed
            dgvReports.ReadOnly = true;
            dgvReports.AllowUserToDeleteRows = false;
            dgvReports.AllowUserToResizeColumns = false;
            dgvReports.AllowUserToResizeRows = false;
            dgvReports.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReports.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvReports.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReports.AllowUserToAddRows = false;
            dgvReports.RowHeadersVisible = false;
            dgvReports.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
        }

        private void LoadReport()
        {
            try
            {
                conn.Open();
                string query = "SELECT A.ID, U.Username as AdopterName, P.Name as PetName, A.Application, A.Status FROM adoptapplication A JOIN users U ON A.ID = U.userID JOIN pets P ON A.PetID = P.ID;";
                cmd = new MySqlCommand(query, conn);
                adapter = new MySqlDataAdapter(cmd);
                dt = new DataTable();
                adapter.Fill(dt);
                dgvReports.DataSource = dt;
                // Set the column headers
                dgvReports.Columns[0].HeaderText = "Application ID";
                dgvReports.Columns[1].HeaderText = "Adopter Name";
                dgvReports.Columns[2].HeaderText = "Pet Name    ";
                dgvReports.Columns[3].HeaderText = "Application Date";
                dgvReports.Columns[4].HeaderText = "Status";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Load Report Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        // Button click event for generating report
        private void generateBtn_Click(object sender, EventArgs e)
        {
            // Call LoadReport when the "Generate Report" button is clicked
            LoadReport();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
