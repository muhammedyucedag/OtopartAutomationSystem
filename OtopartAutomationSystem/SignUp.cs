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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }
        SqlConnectionClass scc = new SqlConnectionClass();
        private void btnHome_Click(object sender, EventArgs e)
        {
            Signİn si = new Signİn();
            si.Show();
            this.Close();
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            // aynı kullanıcı adını bir daha almamak üzere yazılmış olan bir kod satırı.
            // count kodu kullanıcıların sayısını hesaplar
            SqlCommand countUserCommand = new SqlCommand("select count(*) as sonuc from parkingRegistration where username=LOWER(@username)",scc.connection());
            countUserCommand.Parameters.AddWithValue("@username", txtUsername.Text);
            // kullanıcıları saymak için aşşağıdaki kodu yazıyoruz.
            int countUser = 0;
            SqlDataReader dr = countUserCommand.ExecuteReader();
            while (dr.Read())
            {
                countUser = Convert.ToInt32(dr["sonuc"]);
            }
            if (countUser == 0)
            {
                SqlCommand command = new SqlCommand("insert into parkingRegistration (username,password,carparkName,parkingArea) values (@username,@password,@carparkName,@parkingArea)", scc.connection());
                command.Parameters.AddWithValue("@username",txtUsername.Text);
                command.Parameters.AddWithValue("@password", txtPassword.Text);
                command.Parameters.AddWithValue("@carparkName", txtCarparkname.Text);
                command.Parameters.AddWithValue("@parkingArea", txtParkingarea.Text);
                command.ExecuteNonQuery();
                scc.connection().Close();

                MessageBox.Show("Kaydınız Gerçekleşmiştir Şifreniz" + txtPassword.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Signİn signİn = new Signİn();
                signİn.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Girmiş Olduğunuz Kullanıcı Adı Daha Önceden Alınmıştır.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
