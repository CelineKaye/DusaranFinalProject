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

    public partial class Report : Form
    {
        private OleDbConnection conn;

        public Report()
        {
            InitializeComponent();
            conn = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\DeLL\Downloads\reilFinalLibrary\LibrarySystem\LibSys.mdb");
            LoadReport();
        }

        private void LoadReport()
        {
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM tblAdoptionApplications", conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvReports.DataSource = dt;
            conn.Close();
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Report_Load(object sender, EventArgs e)
        {

        }
    }
}
