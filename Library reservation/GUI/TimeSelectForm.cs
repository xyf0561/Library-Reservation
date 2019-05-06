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
    public partial class TimeSelectForm : Form
    {
        DateTime start;
        DateTime end;
        bool firstIn;
        string sid;
        string uid;
        public TimeSelectForm(bool firstIn,string sid, string uid)
        {
            InitializeComponent();

            this.firstIn = firstIn;
            this.sid = sid;
            this.uid = uid;
            StartTimeComboBox.Text = "8:00";
            SelectDate.MinDate = DateTime.Now.Date;
            SelectDate.MaxDate = DateTime.Now.Date.AddDays(2);

            start = new DateTime(SelectDate.Value.Year, SelectDate.Value.Month, SelectDate.Value.Day, 8, 0, 0);
            end = start.AddMinutes(30);

            PrintReservationList();

        }

        private void PrintReservationList()
        {
            dbsql db = new dbsql();
            string query;
            ListViewTool ListViewTool = new ListViewTool();
            query = "select * from User_Seat";
            DataTable userTable = db.ExecuteQuery(query);
            ListViewTool.ShowDataInListView(userTable,ReservationList);
        }

        private void StartTimeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int hh = StartTimeComboBox.SelectedIndex / 2 + 8;
            int mm;
            if (StartTimeComboBox.SelectedIndex % 2 == 0)
                mm = 0;
            else
                mm = 30;

            start = new DateTime(SelectDate.Value.Year, SelectDate.Value.Month, SelectDate.Value.Day,hh,mm,0);
            end = start.AddMinutes(30);
            PrintEndTime();
        }

        private void PrintEndTime()
        {
            EndTimeLabel.Text = end.ToShortTimeString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            end = end.AddMinutes(30);
            if (DateTime.Compare(end, (new DateTime(SelectDate.Value.Year,
                SelectDate.Value.Month, SelectDate.Value.Day, 22, 30, 0))) >= 0)
            {
                end = end.AddMinutes(-30);
                PrintEndTime();
                return;
            }
            if (DateTime.Compare(end, (start.AddHours(2))) > 0)
            {
                end = end.AddMinutes(-30);
                PrintEndTime();
                return;
            }
            PrintEndTime();
        }

        private void ReduceButton_Click(object sender, EventArgs e)
        {
            end = end.AddMinutes(-30);
            if (DateTime.Compare(start, end) >= 0)
            {
                end = end.AddMinutes(30);
                PrintEndTime();
                return;
            }
            PrintEndTime();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)   //按时间预定
        {
            if (firstIn)            //用户直接进入该窗口，尚未选择座位
            {
                if (start <= System.DateTime.Now)      //判读时间合法性
                {
                    MessageBox.Show("预约时间早于系统当前时间", "非法操作");
                    return;
                }

                FloorSelectForm FloorSelectForm = new FloorSelectForm(false,uid,start,end,0);       //打开新窗口，由用户选择该时间段空闲座位

                FloorSelectForm.Show();
                this.Hide();
            }
            else            //用户已经选择座位，才进入该窗口
            {
                dbsql sql = new dbsql();
                string que = "select * from User_Seat WHERE Star_Time<='"
               + end.ToString("yyyy-MM-dd hh:mm:ss")
               + "'and  End_Time>=' " + end.ToString("yyyy-MM-dd hh:mm:ss")
               + "'AND S_ID =" + sid;  //查询用户选定的座位在选定时间段内是否空闲
                DataTable dt = new DataTable();
                dt = sql.ExecuteQuery(que);
                if (dt != null && dt.Rows.Count > 0)   //能找到，说明已经存在别人的预约
                {
                    MessageBox.Show("时间存在冲突", "警告");
                    return;

                }
                que = "select * from User_Seat WHERE End_Time>='"
             + start.ToString("yyyy-MM-dd hh:mm:ss")
             + "'and Star_Time<='" + start.ToString("yyyy-MM-dd hh:mm:ss")
             + "'and S_ID =" + sid;  //查询用户选定的座位在选定时间段内是否空闲
                dt = sql.ExecuteQuery(que);
                if (dt != null && dt.Rows.Count > 0)   //能找到，说明已经存在别人的预约
                {
                    MessageBox.Show("时间存在冲突", "警告");
                    return;
                }
                
                que = "insert into User_Seat values('" + sid + "','" + uid + "','" + start.ToString() + "','" + end.ToString() + "')";   //向数据库中插入新的预约数据
                int right = sql.ExecuteUpdate(que);
                if (right == 3)
                    MessageBox.Show("预定成功！", "恭喜");    //告知用户预约成功
                this.Close();
                
            }
        }

        private void CurrentTimer_Tick(object sender, EventArgs e)
        {
            CurrentTimeLabel.Text = System.DateTime.Now.ToString();
        }

        private void TimeSelectForm_Load(object sender, EventArgs e)
        {
            CurrentTimer.Start();
        }

        private void SelectDate_ValueChanged(object sender, EventArgs e)
        {
            int hh = StartTimeComboBox.SelectedIndex / 2 + 8;
            int mm;
            if (StartTimeComboBox.SelectedIndex % 2 == 0)
                mm = 0;
            else
                mm = 30;

            start = new DateTime(SelectDate.Value.Year, SelectDate.Value.Month, SelectDate.Value.Day, hh, mm, 0);
            end = start.AddMinutes(30);
            PrintEndTime();
        }

        private void TimeSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserGUI UserGUI = new UserGUI(uid);
            UserGUI.Show();
        }
    }
}
