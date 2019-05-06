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
    public partial class SeatManageForm : Form
    {
        string sid;
        bool maintain;
        public SeatManageForm(string sid)
        {
            InitializeComponent();
            this.sid = sid;
            SIDLabel.Text = sid;
            dbsql db = new dbsql();
            string query;
            ListViewTool ListViewTool = new ListViewTool();
            query = "select * from User_Seat WHERE S_ID=" + sid;
            DataTable userTable = db.ExecuteQuery(query);
            ListViewTool.ShowDataInListView(userTable, ReservationList);

            query = "select S_State from Seat WHERE S_ID=" + sid;
            DataTable temp = db.ExecuteQuery(query);
            if (temp.Rows[0][0].ToString() == "4")
            {
                MaintainLabel.Text = "正在维护";
                maintain = true;
            }
            else
            {
                MaintainLabel.Text = "正常使用";
                maintain = false;
            }
        }

        private void MaintainButton_Click(object sender, EventArgs e)
        {
            dbsql db = new dbsql();
            string query;
            if (maintain)
            {
                query = "UPDATE Seat SET S_State = '1' WHERE S_ID=" + sid;
                int right = db.ExecuteUpdate(query);
                if(right==1)
                     MessageBox.Show("座位已经恢复正常，开始投入使用","成功");
            }
            else
            {
                query = "DELETE FROM User_Seat WHERE S_ID=" + sid;
                db.ExecuteUpdate(query);

                query = "UPDATE Seat SET S_State = '4' WHERE S_ID=" + sid;
                db.ExecuteUpdate(query);
                MessageBox.Show("座位已经准备维护，所有已存在的预约已经被强制取消。","警告");
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            dbsql db = new dbsql();
            string query = "DELETE FROM User_Seat WHERE S_ID=" + sid;
            int right = db.ExecuteUpdate(query);
            if(right == 0)
            {
                MessageBox.Show("当前座位下无预约。", "失败");
                return;
            }
            MessageBox.Show("所有预约已经被强制取消。", "成功");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ReservationList.SelectedIndices != null && ReservationList.SelectedIndices.Count > 0)
            {
                ListView.SelectedIndexCollection c = ReservationList.SelectedIndices;
                string uid = ReservationList.Items[c[0]].SubItems[1].Text.ToString();
                ReservationForm ReservationForm = new ReservationForm(uid, sid);
                ReservationForm.Show();
                this.Hide();
            }
        }
    }
}
