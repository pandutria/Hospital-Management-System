using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hospital_Management_System
{
    public partial class FormNewMeeting : Form
    {
        public FormNewMeeting()
        {
            InitializeComponent();
        }

        private void loadTbPatName()
        {
            var db = new DataBaseDataContext();
            var patient = db.patients.FirstOrDefault(x => x.name.Equals(tbPatientName.Text));

            if (patient != null)
            {
                tbPatientName.Text = patient.name;
            }
        }

        private void loadCbCtg()
        {
            cbCategory.DataSource = new DataBaseDataContext().doctor_categories;
            cbCategory.ValueMember = "id";
            cbCategory.DisplayMember = "category";
        }

        private void cbCategory_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbCategory.SelectedValue != null)
            {
                var db = new DataBaseDataContext();
                var dtg = db.doctors.Where(x => x.doctor_category.id.Equals(cbCategory.SelectedValue));

                cbName.DataSource = dtg;
                cbName.ValueMember = "id";
                cbName.DisplayMember = "name";
            }
        }

        private void linkViewPatientData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormMasterPatient().ShowDialog();
            Hide();
        }

        private void linkViewDoctorData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void linkViewPatientRecord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormPatientRecord().ShowDialog();
            Hide();
        }

        private void FormNewMeeting_Load(object sender, EventArgs e)
        {
            loadTbPatName();
            loadCbCtg();
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            var db = new DataBaseDataContext();
            meeting Meeting;

            Meeting = new meeting();
            db.meetings.InsertOnSubmit(Meeting);

            if (Meeting != null)
            {
                Meeting.patient.name = tbPatientName.Text;
                Meeting.doctor.name = cbName.Text;
                Meeting.date = dtMeeting.MaxDate;
                Meeting.room = null;
                Meeting.queue_number = Convert.ToInt32(null);
                Meeting.deleted_at = null;


            }

            db.SubmitChanges();
            MessageBox.Show("suscses");

        }

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
