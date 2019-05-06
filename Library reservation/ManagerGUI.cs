using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Library_reservation.GUI;

namespace Library_reservation
{
    public partial class ManagerGUI : Form
    {
        string mid;
        public ManagerGUI(string mid)
        {
            InitializeComponent();
            this.mid = mid;
        }

        private void ManagerGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
        }

        private void SeatManage_Click(object sender, EventArgs e)
        {
            FloorSelectForm FloorSelectForm = new FloorSelectForm(true,"", System.DateTime.Now, System.DateTime.Now,1);
            FloorSelectForm.Show();
            this.Hide();
        }

        private void ExitManage_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UserManage_Click(object sender, EventArgs e)
        {
            AllUserSelectForm AllUserSelectForm = new AllUserSelectForm(mid);
            AllUserSelectForm.Show();
            this.Hide();
        }
    }
}
