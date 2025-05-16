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
    public partial class AdoptionApplicationForm : Form
    {
        private OleDbConnection conn;

        private int petId, userId;
        

        public AdoptionApplicationForm(int petId, int userId)
        {
            InitializeComponent();
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\Downloads\DusaranFinalProject-1\DusaranFinalProject\CatandDogs.mdb");

            this.petId = petId;
            this.userId = userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();

                string query = "INSERT INTO tblAdoptionApplications ([PetID], [UserID], [ApplicationDate], [Status]) " +
                               "VALUES (?, ?, ?, ?)";

                OleDbCommand cmd = new OleDbCommand(query, conn);

                // Make sure petId and userId are integers. If not, convert them.
                cmd.Parameters.Add("?", OleDbType.Integer).Value = petId;
                cmd.Parameters.Add("?", OleDbType.Integer).Value = userId;
                cmd.Parameters.Add("?", OleDbType.Date).Value = DateTime.Now;
                cmd.Parameters.Add("?", OleDbType.VarChar).Value = "Pending";

                cmd.ExecuteNonQuery();

                MessageBox.Show("Application Submitted!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Submit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (conn.State == ConnectionState.Open)
                    conn.Close();
            }
        }

        private void AdoptionApplicationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
