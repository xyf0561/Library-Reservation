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
    public partial class ReservationForm : Form
    {
        string sid;
        string uid;
        public ReservationForm(string uid, string sid)
        {
            InitializeComponent();
            this.sid = sid;
            this.uid = uid;
            SidLabel.Text = sid;
            UidLabel.Text = uid;

            dbsql db = new dbsql();
            string query = "select Star_Time from User_Seat WHERE U_ID=" + uid+"AND S_ID="+sid;
            DataTable userTable = db.ExecuteQuery(query);
            StartLabel.Text = userTable.Rows[0][0].ToString();
            
            query = "select End_Time from User_Seat WHERE U_ID=" + uid + "AND S_ID=" + sid;
            userTable = db.ExecuteQuery(query);
            EndLabel.Text = userTable.Rows[0][0].ToString();
        }

        private void SignOffButton_Click(object sender, EventArgs e) //删除预约函数
        {
            dbsql db = new dbsql();
            string query = "DELETE FROM User_Seat WHERE U_ID =" + uid;
            int right = db.ExecuteUpdate(query);
            if (right == 3)
                MessageBox.Show("强制删除预约成功", "成功");
            this.Close();
        }
    }
}
