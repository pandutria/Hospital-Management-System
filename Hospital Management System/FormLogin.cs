using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management_System
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
        }

        private string convertSHA512(string text)
        {
            using (var sha = new SHA512CryptoServiceProvider())
            {
                byte[] data = sha.ComputeHash(Encoding.ASCII.GetBytes(text));
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < data.Length; i++)
                {
                    sb.Append(data[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            tbPassword.PasswordChar = '•';
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                tbPassword.PasswordChar = '\0';
            }
            else
            {
                tbPassword.PasswordChar = '•';
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataBaseDataContext data = new DataBaseDataContext();
            var valid = data.users.Where(x => x.username.Equals(tbUsername.Text) && x.password.Equals(convertSHA512(tbPassword.Text))).FirstOrDefault();
            if (valid != null)
            {
                DataStorage.id = valid.id;
                DataStorage.name = valid.username;
                FormMain mainForm = new FormMain();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username/Password salah");
            }
        }
    }
}
