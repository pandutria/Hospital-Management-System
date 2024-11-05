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
    public partial class FormPatientRecord : Form
    {
        public FormPatientRecord()
        {
            InitializeComponent();
        }

        private void loadDgv()
        {
            dgvPateintRecord.Rows.Clear();
            var db = new DataBaseDataContext();
            var PatientRecord = db.patient_records;

            foreach ( var item in PatientRecord )
            {
                dgvPateintRecord.Rows.Add(item.date, item.meeting.doctor.doctor_category.category, item.meeting.doctor.name);
            }
        }

        private void FormPatientRecord_Load(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void dgvPateintRecord_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvPateintRecord_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
