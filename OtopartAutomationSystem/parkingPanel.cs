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
    public partial class parkingPanel : Form
    {
        int MyUserId = 0;
        public parkingPanel(int userId)
        {
            MyUserId = userId;
            InitializeComponent();
        }
        SqlConnectionClass scc = new SqlConnectionClass();
        private void parkingPanel_Load(object sender, EventArgs e)
        {

        }
        private void btnSignin_Click(object sender, EventArgs e)
        {
            Signİn si = new Signİn();
            si.Show();
            this.Hide();
        }
    }
}
