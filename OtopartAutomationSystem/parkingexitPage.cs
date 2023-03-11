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
    public partial class parkingexitPage : Form
    {
        public parkingexitPage()
        {
            InitializeComponent();
        }
        SqlConnectionClass scc = new SqlConnectionClass();
        private void parkingexitPage_Load(object sender, EventArgs e)
        {
            FullParking();
            Plate();
            // form açıldığızı zaman zamanlayıcımız aktif olacak.
            timer1.Enabled = true;
        }

        private void Plate()
        {
            SqlCommand command = new SqlCommand("select * from carparkingRegistration", scc.connection());
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                cmbSearchplate.Items.Add(read["numberPlate"].ToString());
            }
            scc.connection().Close();
        }

        private void FullParking()
        {
            SqlCommand command = new SqlCommand("select * from parkingStatus where status='DOLU'", scc.connection());
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                cmbCarpark.Items.Add(read["carPark"].ToString());
            }
            scc.connection().Close();
        }

        private void cmbSearchplate_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from carparkingRegistration where numberPlate='" + cmbSearchplate.SelectedItem + "'", scc.connection());
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtCarpark.Text = read["carpark"].ToString();
            }
            scc.connection().Close();
        }

        private void cmbCarpark_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("select * from carparkingRegistration where carPark='" + cmbCarpark.SelectedItem + "'", scc.connection());
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                txtCarpark2.Text = read["carpark"].ToString();
                txtTc.Text = read["tc"].ToString();
                txtName.Text = read["name"].ToString();
                txtSurname.Text = read["surname"].ToString();
                txtVehicletype.Text = read["vehicleType"].ToString();
                txtColor.Text = read["color"].ToString();
                txtCarpark2.Text = read["carpark"].ToString();
                lblentryDate.Text = read["date"].ToString();
            }
            scc.connection().Close();
            double totalFee = 0;

            int parkingTime = 0;


            DateTime entryDate, Releasedate;
            // yazdığımız kodu tarihe çevireceğimiz için datetime.parse kodunu ekliyoruz
            entryDate = DateTime.Parse(lblentryDate.Text);
            Releasedate = DateTime.Parse(lblReleasedate.Text);
            // aradaki fark için timespan kodunu ekliyoruz
            TimeSpan difference;
            difference = Releasedate - entryDate;
            lblParkingtime.Text = difference.Hours.ToString() + " : " + difference.Minutes.ToString();

            if (txtVehicletype.Text == "MOTOR")
            {
               lblTotalfee.Text = (difference.TotalHours * 7.5).ToString("0.00");
            }
            else if (txtVehicletype.Text == "BİNEK")
            {
                lblTotalfee.Text = (difference.TotalHours * 10).ToString("0.00");
            }
            else if (txtVehicletype.Text == "TİCARİ")
            {
                lblTotalfee.Text = (difference.TotalHours * 20).ToString("0.00");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblReleasedate.Text = DateTime.Now.ToString();
        }
    }
}

//if (parkingTime > 1)
//{
//    for (int i = 1; i <= parkingTime; i++)
//    {
//        if (i == 1)
//        {
//            if (vehicleType == 1) { totalFee = i * 5; }
//            else if (vehicleType == 2) { totalFee = i * 6; }
//            else if (vehicleType == 3) { totalFee = i * 6.5; }
//        }
//        else
//        {
//            parkingTime -= 1;
//            if (vehicleType == 1) { totalFee += parkingTime * 5 * 1.20; }
//            else if (vehicleType == 2) { totalFee += parkingTime * 6 * 1.215; }
//            else if (vehicleType == 3) { totalFee += parkingTime * 6.5 * 1.25; }
//        }
//    }
//}
//else
//{
//    if (vehicleType == 1) { totalFee = parkingTime * 5; }
//    else if (vehicleType == 2) { totalFee = parkingTime * 6; }
//    else if (vehicleType == 3) { totalFee = parkingTime * 6.5; }
//}
