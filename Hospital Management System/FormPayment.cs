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
    public partial class FormPayment : Form
    {
        int currentSelectedRow = -1;
        public FormPayment()
        {
            InitializeComponent();
        }

        private void loadDgv()
        {
            dgvPayment.Rows.Clear();
            var db = new DataBaseDataContext();
            var PaymentDetail = db.payment_details;

            foreach(var item in PaymentDetail)
            {
                dgvPayment.Rows.Add(item.item, item.nominal, item.notes, btnDelete.Text = "Delete" ,item.payment.card_holder_name, item.payment.primary_account_number, item.payment.expiration_date, item.payment.service_code, item.payment.total_payment, item.payment.meeting_id);
               
            }
        }

        private void dgvPayment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 & e.RowIndex < dgvPayment.Rows.Count)
            {
               
                    currentSelectedRow = e.RowIndex;
                    tbCardHolder.Text = dgvPayment.Rows[e.RowIndex].Cells[4].Value?.ToString();
                    tbPrimaryAccount.Text = dgvPayment.Rows[e.RowIndex].Cells[5].Value?.ToString();
                    dtDate.Text = dgvPayment.Rows[e.RowIndex].Cells[6].Value?.ToString();
                    tbServiceCode.Text = dgvPayment.Rows[e.RowIndex].Cells[7].Value?.ToString();
                    tbTotalPayment.Text = dgvPayment.Rows[e.RowIndex].Cells[8].Value?.ToString();

                
            }
            
            
      
        }

        private void FormPayment_Load(object sender, EventArgs e)
        {
            loadDgv();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var db = new DataBaseDataContext();
           
        }

        private void dgvPayment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
