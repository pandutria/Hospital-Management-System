using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class FormMain : Form
    {
       
        public FormMain()
        {
            InitializeComponent();
            
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            lblUsername.Text = "Welcome, " + DataStorage.name;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            Hide();
        }

        private void btnICD_Click(object sender, EventArgs e)
        {
            new FormMaster_ICD_11().Show();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            new FormMasterDoctor(null).Show();
        }

        private void btnParent_Click(object sender, EventArgs e)
        {
            new FormMasterPatient().Show();
        }

        private void btnNewMeeting_Click(object sender, EventArgs e)
        {
            new FormNewMeeting().Show();
        }

        private void btnManageMeeting_Click(object sender, EventArgs e)
        {
            new FormManageMeeting().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormPayment().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormNewPayment().Show();
        }
    }
}
