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
    public partial class parkingLot : Form
    {
        public parkingLot()
        {
            InitializeComponent();
        }
        SqlConnectionClass scc = new SqlConnectionClass();
        private void parkingLot_Load(object sender, EventArgs e)
        {
            BosParkYerleri();
            fullvehicle();
            SqlCommand command = new SqlCommand("select * from carparkingRegistration", scc.connection());
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["carPark"].ToString())
                        {
                            item.Text = read["numberPlate"].ToString();
                        }

                    }
                }
            }
            scc.connection().Close();
        }

        private void fullvehicle()
        {
            SqlCommand command = new SqlCommand("select * from parkingStatus", scc.connection());
            SqlDataReader read = command.ExecuteReader();
            while (read.Read())
            {
                foreach (Control item in Controls)
                {
                    if (item is Button)
                    {
                        if (item.Text == read["carPark"].ToString() && read["status"].ToString() == "DOLU")
                        {
                            item.BackColor = Color.Red;
                        }

                    }
                }
            }
            scc.connection().Close();
        }

        private void BosParkYerleri()
        {
            int sayac = 1;
            foreach (Control item in Controls)
            {
                if (item is Button)
                {
                    item.Text = "P-" + sayac;
                    item.Name = "P-" + sayac;
                    sayac++;
                }
            }
            scc.connection().Close();
        }
    }
}
