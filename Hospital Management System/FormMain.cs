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
           
        }

        private void name()
        {
            var db = new DataBaseDataContext();
            var getId = db.users.FirstOrDefault(x => x.id.Equals(DataStorage.id));

            if (getId != null)
            {
                lblUsername.Text = "Welcome, "  + getId.username;
            }

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            new FormLogin().Show();
            Hide();
        }

        private void btnICD_Click(object sender, EventArgs e)
        {
            new FormMaster_ICD_11().Show();
            Hide();
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            new FormMasterDoctor(null).Show();
            Hide();
        }

        private void btnParent_Click(object sender, EventArgs e)
        {
            new FormMasterPatient().Show();
            Hide();
        }

        private void btnNewMeeting_Click(object sender, EventArgs e)
        {
            new FormNewMeeting().Show();
            Hide();
        }

        private void btnManageMeeting_Click(object sender, EventArgs e)
        {
            new FormManageMeeting().Show();
            Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new FormPayment().Show();
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new FormNewPayment().Show();
            Hide();
        }
    }
}
