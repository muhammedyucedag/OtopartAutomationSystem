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
    public partial class homePage : Form
    {
        public homePage()
        {
            InitializeComponent();
        }

        private void btnregistrationPage_Click(object sender, EventArgs e)
        {
            registrationPage rp = new registrationPage();
            rp.Show();
            this.Hide();
        }

        private void btnparkingLot_Click(object sender, EventArgs e)
        {
            parkingLot pl = new parkingLot();
            pl.Show();
            this.Hide();
        }

        private void btnparkingexitPage_Click(object sender, EventArgs e)
        {
            parkingexitPage pep = new parkingexitPage();
            pep.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
