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
    public partial class registrationPage : Form
    {
        public registrationPage()
        {
            InitializeComponent();
        }
        SqlConnectionClass scc = new SqlConnectionClass();
        private void registrationPage_Load(object sender, EventArgs e) // ctrl r+m seçtiğiniz satırı metot haline dönüştürür.
        {
            emptyvehicle();
            SqlCommand command = new SqlCommand("select vehicleType from vehicleType",scc.connection());
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                cmbVehicletype.Items.Add(read["vehicleType"]);
            }
            scc.connection().Close();
        }

        private void emptyvehicle()
        {
            SqlCommand comman = new SqlCommand("select * from parkingStatus where status='BOŞ'", scc.connection());
            SqlDataReader read = comman.ExecuteReader();
            while (read.Read())
            {
                cmbCarpark.Items.Add(read["carPark"].ToString());
            }
            scc.connection().Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
                SqlCommand command = new SqlCommand("insert into carparkingRegistration(tc,name,surname,phoneNumber,email,numberPlate,vehicleType,color,carPark,date) values (@tc,@name,@surname,@phoneNumber,@email,@numberPlate,@vehicleType,@color,@carPark,@date)", scc.connection());
            command.Parameters.AddWithValue("@tc",mskTc.Text);
            command.Parameters.AddWithValue("@name", txtName.Text);
            command.Parameters.AddWithValue("@surname", txtSurname.Text);
            command.Parameters.AddWithValue("@phoneNumber", mskPhonenumber.Text);
            command.Parameters.AddWithValue("@email", txtEmail.Text);
            command.Parameters.AddWithValue("@numberPlate", txtNumberplate.Text);
            command.Parameters.AddWithValue("@vehicleType", cmbVehicletype.Text);
            command.Parameters.AddWithValue("@color", txtColor.Text);
            command.Parameters.AddWithValue("@carPark", cmbCarpark.Text);
            command.Parameters.AddWithValue("@date", DateTime.Now.ToString());

            command.ExecuteNonQuery();

            SqlCommand command2 = new SqlCommand("update parkingStatus set status = 'DOLU' where carPark='" + cmbCarpark.SelectedItem + "'", scc.connection());
            command2.ExecuteNonQuery();
            MessageBox.Show("Araç kaydınız Oluşturuldu", "Kayıt");
            cmbCarpark.Items.Clear();
            emptyvehicle();

            // groupbox İçindeki verilerin temizlenmesi için uygulanan bir döngü

            foreach (Control item in grppersonalInformation.Controls)
            {
                if(item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }
            foreach (Control item in grpvehicleInformation.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                else if (item is ComboBox)
                {
                    item.Text = "";
                }
            }
            mskTc.Focus();

            scc.connection().Close();


        }
    }
}
