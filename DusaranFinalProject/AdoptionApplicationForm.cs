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

namespace DusaranFinalProject
{
    public partial class AdoptionApplicationForm : Form
    {
        static MySqlConnection conn = new MySqlConnection("server = localhost; user = root; database = animaldb; password =");
        MySqlCommand cmd;
        MySqlDataReader reader;
        private int petId, userId;
        

        public AdoptionApplicationForm(int petId, int userId)
        {
            InitializeComponent();

            this.petId = petId;
            this.userId = userId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string query = "INSERT INTO adoptapplication(PetID, UserID, Application, Status) VALUES(@petid, @userid, @application, @status)";
                cmd = new MySqlCommand(query, conn);
                
                cmd.Parameters.AddWithValue("@petid", petId);
                cmd.Parameters.AddWithValue("@userid", userId);
                cmd.Parameters.AddWithValue("@application", DateTime.Now);
                cmd.Parameters.AddWithValue("@status", "Pending");  
               
                cmd.ExecuteNonQuery();

                MessageBox.Show("Application Submitted!");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Submit Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void AdoptionApplicationForm_Load(object sender, EventArgs e)
        {

        }
    }
}
