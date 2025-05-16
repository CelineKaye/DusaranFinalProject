using LibrarySystem;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DusaranFinalProject
{
    public partial class Dashboard : Form
    {
        public static string user_type = "";

        public Dashboard()
        {
            InitializeComponent();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PetListingForm petListingForm = new PetListingForm();
            petListingForm.ShowDialog();
        }

        private void barrowsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int petId = 1;   // Replace with the actual selected pet ID
            int userId = 1;  // Replace with the actual logged-in user ID

            AdoptionApplicationForm adoptionApplicationForm = new AdoptionApplicationForm(petId, userId);
            adoptionApplicationForm.ShowDialog();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void masterFileManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Masterfiles filemanager = new Masterfiles();
            this.Hide();
            filemanager.ShowDialog();
        }
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin login = new frmLogin();
            login.ShowDialog();
        }
    }
}
