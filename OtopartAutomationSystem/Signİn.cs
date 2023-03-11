using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace OtopartAutomationSystem
{
    public partial class Signİn : Form
    {
        int MyUserId = 0;
        public Signİn()
        {

            InitializeComponent();
        }
        SqlConnectionClass scc = new SqlConnectionClass();
        private void chkPasswordsee_CheckedChanged(object sender, EventArgs e)
        {
            // Girmiş olduğumuz şifreyi gösterme işlemi
            if (chkPasswordsee.CheckState == CheckState.Checked)
            {
                txtPassword.UseSystemPasswordChar = true;
            }
            else if (chkPasswordsee.CheckState == CheckState.Unchecked)
            {
                txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void lnkSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp su = new SignUp();
            su.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand($"select * from parkingRegistration WHERE CAST(username as binary) = CAST ('{txtUsername.Text}' as binary ) and password = '{txtPassword.Text}'",scc.connection());

            // ExecuteReader: Birden fazla satır sonucu döndüren sorgular için kullanılmaktadır.
            if (command.ExecuteScalar() == null)
            {
                MessageBox.Show("Hatalı Kullanıcı Adı & Şifre Girişi Yapıldı");
                return;
            }
            else
            {
                MyUserId = (int)command.ExecuteScalar();
            }

            SqlDataReader dr = command.ExecuteReader();
            if (dr.Read())
            {
                parkingPanel pp = new parkingPanel(MyUserId);
                pp.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı Adı & Şifre Girişi Yapıldı");
            }
            scc.connection().Close();
        }

        private void Signİn_Load(object sender, EventArgs e)
        {

        }
    }
}
