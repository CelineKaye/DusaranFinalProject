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
    public partial class Transaction : Form
    {
        private OleDbConnection conn;

        public Transaction()
        {
            InitializeComponent();
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Downloads\DusaranFinalProject-1\DusaranFinalProject\CatandDogs.mdb");
            LoadApplications();

        }
        private void LoadApplications()
        {
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT A.ApplicationID, U.FullName AS Adopter, P.Name AS PetName, A.ApplicationDate, A.Status FROM tblAdoptionApplications A JOIN tblUsers U ON A.UserID = U.UserID JOIN tblPets P ON A.PetID = P.PetID", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvTransactions.DataSource = dt;
            conn.Close();
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
            int appId = Convert.ToInt32(dgvTransactions.SelectedRows[0].Cells["ApplicationID"].Value);
            UpdateStatus(appId, "Approved");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dgvTransactions.SelectedRows.Count == 0) return;
            int appId = Convert.ToInt32(dgvTransactions.SelectedRows[0].Cells["ApplicationID"].Value);
            UpdateStatus(appId, "Rejected");
        }
        private void UpdateStatus(int appId, string status)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand("UPDATE tblAdoptionApplications SET Status=@status WHERE ApplicationID=@id", conn);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", appId);
            cmd.ExecuteNonQuery();
            conn.Close();
            LoadApplications();
        }
    }
}
