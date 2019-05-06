using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_reservation.GUI
{
    public partial class UserInformationForm : Form
    {
        string UserID;
        ListViewTool ListViewTool = new ListViewTool();
        public UserInformationForm(string UserID)
        {
            InitializeComponent();
            this.UserID = UserID;
            IDlabel.Text = UserID;

            dbsql db = new dbsql();
            string query = "select U_Name from D_User WHERE U_ID="+ UserID;
            DataTable userTable = db.ExecuteQuery(query);
            NameLabel.Text = userTable.Rows[0][0].ToString();

            query = "select Credit from D_User WHERE U_ID=" + UserID;
            userTable = db.ExecuteQuery(query);
            CreditLabel.Text = userTable.Rows[0][0].ToString();

            query = "select * from User_Seat WHERE U_ID=" + UserID;
            userTable = db.ExecuteQuery(query);
            ListViewTool.ShowDataInListView(userTable, ReservationListView);
        }

        private void ResetPasswordButton_Click(object sender, EventArgs e)
        {
            dbsql db = new dbsql();
            string query = "UPDATE D_User SET Password = '123456' WHERE U_ID=" + UserID;
            int right = 0;
            right = db.ExecuteUpdate(query);
            if (right == 1)
                MessageBox.Show("重置密码为123456！","修改成功");
        }

        private void ReservationManagerButton_Click(object sender, EventArgs e)
        {
            if (ReservationListView.SelectedIndices != null && ReservationListView.SelectedIndices.Count > 0)
            {
                ListView.SelectedIndexCollection c = ReservationListView.SelectedIndices;
                string sid = ReservationListView.Items[c[0]].SubItems[0].Text.ToString();
                ReservationForm ReservationForm = new ReservationForm(UserID,sid);
                ReservationForm.Show();
            }
           
        }
    }
}
