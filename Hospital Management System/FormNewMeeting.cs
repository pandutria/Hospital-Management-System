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
                var dtg = db.doctors.Where(x => x.doctor_category.id.ToString().Contains(cbCategory.SelectedValue.ToString()));

                cbName.DataSource = dtg;
                cbName.ValueMember = "id";
                cbName.DisplayMember = "name";
            }
        }

        private void cbName_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbName.SelectedValue != null)
            {
                var doctor = new DataBaseDataContext().doctors.FirstOrDefault(x => x.id.Equals(cbName.SelectedValue));

                DataStorage.doctorId = doctor.id;
                DataStorage.doctorName = doctor.name;
            }
        }

        private void loadId()
        {
            var db = new DataBaseDataContext();
            var id = db.patients.FirstOrDefault(x => x.name.Contains(tbPatientName.Text));

            if (id != null)
            {
                DataStorage.patientId = id.id;
                DataStorage.patientName = id.name;
            }
        }

        private void validateSchedule()
        {
            var db = new DataBaseDataContext();
            var meeting = db.meetings.FirstOrDefault(x => x.doctor_id == Convert.ToInt32(cbName.SelectedValue) && x.date.Equals(dtMeeting.Value.Date));

            if (meeting != null)
            {
                var time = db.meetings.Any(x => x.doctor_id == Convert.ToInt32(cbName.SelectedValue));

                if (time != null)
                {
                    MessageBox.Show("jadwal sudah penuh");
                } else
                {
                    
                }
            }
        }

        private void loadQuene()
        {
            
        }

        private void FormNewMeeting_Load(object sender, EventArgs e)
        {
            loadCbCtg();
        }

        private void linkViewPatientData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormMasterPatient().ShowDialog();
            Hide();
        }


        private void tbPatientName_TextChanged(object sender, EventArgs e)
        {
            loadId();
        }

        private void linkViewDoctorData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormMasterDoctor(null).ShowDialog();
            Hide();
        }


        private void linkViewPatientRecord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormPatientRecord().ShowDialog();
            Hide();
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

        private void dtMeeting_ValueChanged(object sender, EventArgs e)
        {

        }

      



       

        private void cbName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dtpMeeting_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
