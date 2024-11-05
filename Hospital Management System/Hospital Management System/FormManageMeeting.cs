﻿using System;
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
    public partial class FormManageMeeting : Form
    {
        public FormManageMeeting()
        {
            InitializeComponent();
        }

        private void loadDgv()
        {
            dgvPayment.Rows.Clear();
            var db = new DataBaseDataContext();
            var PatientRecord = db.patient_records;

            foreach (var item in PatientRecord)
            {
                dgvPayment.Rows.Add(item.date, item.meeting.patient.name, item.meeting.doctor.doctor_category.category, item.meeting.doctor.name, item.meeting.queue_number, btnPayment.Text = "Payment");
            }
        }

        private void FormManageMeeting_Load(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void dgvPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void btnAddNewPatient_Click(object sender, EventArgs e)
        {
            new FormPayment().Show();
            Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

    }
}
