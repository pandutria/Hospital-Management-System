using Hospital_Management_System.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
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
                DataStorage.meetingRoom = doctor.assigned_room;
                DataStorage.doctorId = doctor.id;
            }
        }

        private void loadId()
        {
            var db = new DataBaseDataContext();
            var id = db.patients.FirstOrDefault(x => x.name.Contains(tbPatientName.Text));

            if (id != null)
            {
                DataStorage.patientID = id.id;
            }
        }

        private void FormNewMeeting_Load(object sender, EventArgs e)
        {
            loadCbCtg();
            Console.WriteLine(DataStorage.patientID);
            Console.Write(DataStorage.meetingRoom);
        }

        private void linkViewPatientData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataBaseDataContext data = new DataBaseDataContext();
            var dataPatient = data.patients.Where(x => x.name.Equals(tbPatientName.Text)).FirstOrDefault();
            if (dataPatient != null)
            {
                DataStorage.patientID = dataPatient.id;
                new FormMasterPatient(dataPatient.name).ShowDialog();
            }
            else
            {
                MessageBox.Show("User " + tbPatientName.Text + " tidak ada");
            }
        }


        private void tbPatientName_TextChanged(object sender, EventArgs e)
        {
            loadId();
        }

        private void linkViewDoctorData_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormMasterDoctor(cbName.Text).ShowDialog();
        }


        private void linkViewPatientRecord_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DataBaseDataContext data = new DataBaseDataContext();
            var dataPatient = data.patients.Where(x=> x.name.Equals(tbPatientName.Text)).FirstOrDefault();
            if(dataPatient!= null)
            {
                DataStorage.patientID = dataPatient.id;
                new FormPatientRecord(dataPatient.name).ShowDialog();
            }
            else
            {
                MessageBox.Show("User "+ tbPatientName.Text + " tidak ada");
            }
           
        }

        private void btnSumbit_Click(object sender, EventArgs e)
        {
            var db = new DataBaseDataContext();
            var meeting = new meeting();
            meeting.patient_id = DataStorage.patientID;
            meeting.doctor_id = DataStorage.doctorId;
            meeting.room = DataStorage.meetingRoom;
            meeting.date = dtMeeting.Value;
            meeting.queue_number = Convert.ToInt32(lblQueue.Text);
            meeting.created_at = DateTime.Now;
            db.meetings.InsertOnSubmit(meeting);
            db.SubmitChanges();
            MessageBox.Show("success");
            this.Close();
        }

        private void dtMeeting_ValueChanged(object sender, EventArgs e)
        {
            DataBaseDataContext data = new DataBaseDataContext();
            var reschedule = data.meetings.Where(x => x.date.Equals(dtMeeting.Value) & x.patient_id.Equals(DataStorage.patientID)).FirstOrDefault();
            var newSchedule = data.meetings.Where(x => x.date.Equals(dtMeeting.Value) && x.patient_id != DataStorage.patientID && x.room.Equals(DataStorage.meetingRoom)).FirstOrDefault();
            if (reschedule != null)
            {
                MessageBox.Show("Pasien sudah memiliki jadwal silahkan reschedule");
            }else if(newSchedule!= null){
                lblQueue.Text = (newSchedule.queue_number+1).ToString();
                Console.WriteLine(newSchedule.date);
                Console.WriteLine(dtMeeting.Value.Date);
            }
            else
            {
                lblQueue.Text = "1";
            }
        }
    }
}
