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
    public partial class FormNewPayment : Form
    {
        public FormNewPayment()
        {
            InitializeComponent();
        }

        private void FormNewPayment_Load(object sender, EventArgs e)
        {

        }

        private void clearField()
        {
            tbItem.Text = tbNominal.Text = tbNotes.Text = "";
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var db = new DataBaseDataContext();
            var Payment = new payment_detail();

            db.payment_details.InsertOnSubmit(Payment);

            if ( Payment != null)
            {
                Payment.item = tbItem.Text;
                Payment.nominal = Convert.ToDecimal(tbNominal.Text);
                Payment.notes = tbNotes.Text;
                Payment.created_at = DateTime.Now;
                Payment.deleted_at = null;  
                Payment.last_updated_at = null;

                Payment.payment.card_holder_name = null;
                Payment.payment.primary_account_number = null;
                Payment.payment.expiration_date = Convert.ToDateTime(null);
                Payment.payment.service_code = Convert.ToInt32(null);
                Payment.payment.total_payment = Convert.ToDecimal(null);
                db.SubmitChanges();


            }

            clearField();
            
        }
    }
}

