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
    public partial class UserGUI : Form
    {
        string uid;
        public UserGUI(string uid)      //
        {
            InitializeComponent();
            this.uid = uid;
            bool HaveReservation = false;

            dbsql db = new dbsql();
            string query = "select * from User_Seat where U_ID =" + uid
                + "AND Star_Time>" + System.DateTime.Now.ToShortDateString().ToString();

            DataTable selectTable = db.ExecuteQuery(query);
            if (selectTable != null && selectTable.Rows.Count > 0)
            {
                HaveReservation = true;
            }

            if (HaveReservation)
            {
                FloorBookBtn.Visible = false;
                TimeBookBtn.Visible = false;
                query = "select Star_Time from User_Seat WHERE U_ID=" + uid;
                DataTable userTable = db.ExecuteQuery(query);
                StartTimeLabel.Text = userTable.Rows[0][0].ToString();

                query = "select End_Time from User_Seat WHERE U_ID=" + uid;
                userTable = db.ExecuteQuery(query);
                EndTimeLabel.Text = userTable.Rows[0][0].ToString();

            }
            else
            {
                CancelPanel.Visible = false;
            }
        }
        
        private void UserGUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
        }

        private void FloorBookBtn_Click(object sender, EventArgs e)
        {
            FloorSelectForm FloorSelectForm = new FloorSelectForm(true,uid, System.DateTime.Now, System.DateTime.Now,0);
            FloorSelectForm.Show();
            this.Hide();
        }

        private void ExitBookBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TimeBookBtn_Click(object sender, EventArgs e)
        {
            TimeSelectForm TimeSelectForm = new TimeSelectForm(true,"",uid);
            TimeSelectForm.Show();
            this.Hide();
        }

        private void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            ChangePassword ChangePassword = new ChangePassword(uid);
            ChangePassword.Show();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            dbsql db = new dbsql();
            string query = "DELETE FROM User_Seat WHERE U_ID =" + uid;
            int right = db.ExecuteUpdate(query);
            if (right == 3)
                MessageBox.Show("删除预约成功", "成功");
            this.Close();
        }
    }
}
