using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_reservation.GUI;
using System.Windows.Forms;

namespace Library_reservation.GUI
{
    public partial class FloorSelectForm : Form
    {
        int character;
        bool nearWindow = false;
        bool nearSocket = false;

        bool firstIn;
        string sid;
        string uid;

        DateTime start;
        DateTime end;

        public FloorSelectForm(bool firstIn, string uid, DateTime start, DateTime end,int character)   //character=0 学生    character=1 管理员
        {
            InitializeComponent();
            AddFloorComboBoxItem();
            this.character = character;
            this.firstIn = firstIn;
            this.start = start;
            this.end = end;
            this.uid = uid;

            if (character == 1)
            {
                NearWindowsCheck.Visible = false;
                NearSocketCheck.Visible = false;
            }
        }

        private void AddFloorComboBoxItem()
        {
            dbsql db = new dbsql();
            string query;
            for(int floorNumber = 1; floorNumber <= 10; floorNumber++)
            {
                query = "select S_ID from Seat where S_Floor =" + floorNumber + " ";
                if (db.ExecuteQuery(query).Rows.Count>=1)
                {
                    FloorComboBox.Items.Add("" + floorNumber);
                }
            }
        }

        private void FloorComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            AddSeat();
        }

        private void AddSeat()
        {
            MainPanel.Controls.Clear();
            AddSeatA();
            AddSeatB();
            AddSeatC();
            AddSeatD();
        }
        private void AddSeatA()     //动态绘制座位选择界面（以A区为例）
        {
            Label label = new Label();    //添加一个A区的LABEL
            label.Text = "A区";
            label.Location = new Point(30, 5);
            this.MainPanel.Controls.Add(label);         //将LABEL加入MainPanel

            string floor = FloorComboBox.SelectedItem.ToString();

            dbsql db = new dbsql();
            string query = "select * from Seat where S_Location = 1 AND S_Floor = " + floor;    //查找全部的A区座位

            DataTable seatTable = db.ExecuteQuery(query);     //查找结果放入DataTab中le

            for (int i = 0; i < seatTable.Rows.Count; i++)    //循环添加按钮
            {
                Button btn = new Button();
                btn.Parent = MainPanel;
                btn.Location = new Point(i * 110+30,30);           //每次添加新按钮较上次偏移一些位置
                btn.Size = new Size(100, 30);
                btn.Text = seatTable.Rows[i][0].ToString();

                bool thisNearWindow = false;        //默认不靠窗
                bool thisNearSocket = false;        //默认没有插座

                if (firstIn == false&&character == 0)     //如果学生在此之前已经选择了时间段，筛选该时间段空闲座位
                {
                    dbsql sql = new dbsql();
                    string que = "select * from User_Seat WHERE Star_Time<="
                   + end.ToShortDateString().ToString()
                   + "and  End_Time>= "+ end.ToShortDateString().ToString()
                   + "AND S_ID ="+ btn.Text;
                    DataTable dt = new DataTable();
                    


                    dt = db.ExecuteQuery(que);

                    if(dt != null && dt.Rows.Count > 0)
                    {
                        break;
                    }

                    que = "select * from User_Seat WHERE End_Time>="
                 + start.ToShortDateString().ToString()
                 + "and Star_Time<=" + start.ToShortDateString().ToString()
                 + "AND S_ID =" + btn.Text;
                    
                    dt = db.ExecuteQuery(que);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        break;
                    }
                }

                if(seatTable.Rows[i][4].ToString().CompareTo("1")==0)       //判断是否靠窗
                    thisNearWindow = true;

                if (seatTable.Rows[i][5].ToString().CompareTo("1") == 0)       //判断是否有插座
                    thisNearSocket = true;

                if (nearWindow == true && thisNearWindow == false)       //根据用户选择智能显示靠窗座位
                    btn.Visible = false;

                if (nearSocket == true && thisNearSocket == false)       //根据用户选择智能显示有插座座位                    btn.Visible = false;

                    btn.Click += NewBtn_Click;

                this.MainPanel.Controls.Add(btn);   //将按钮加入MainPanel

                btn.BackColor = Color.Transparent;

            }
        }

        private void AddSeatB()
        {
            Label label = new Label();
            label.Text = "B区";
            label.Location = new Point(30, 95);
            this.MainPanel.Controls.Add(label);
            string floor = FloorComboBox.SelectedItem.ToString();
            dbsql db = new dbsql();
            string query = "select * from Seat where S_Location = 2 AND S_Floor = " + floor;

            DataTable seatTable = db.ExecuteQuery(query);

            for (int i = 0; i < seatTable.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Parent = MainPanel;
                btn.Location = new Point(i * 110 + 30, 120);
                btn.Size = new Size(100, 30);
                btn.Text = seatTable.Rows[i][0].ToString();

                bool thisNearWindow = false;
                bool thisNearSocket = false;
                if (firstIn == false && character == 0)
                {
                    dbsql sql = new dbsql();
                    string que = "select * from User_Seat WHERE Star_Time<="
                   + end.ToShortDateString().ToString()
                   + "and  End_Time>= " + end.ToShortDateString().ToString()
                   + "AND S_ID =" + btn.Text;

                    DataTable dt = new DataTable();
                    dt = db.ExecuteQuery(que);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        break;

                    }

                    que = "select * from User_Seat WHERE End_Time>="
                 + start.ToShortDateString().ToString()
                 + "and Star_Time<=" + start.ToShortDateString().ToString()
                 + "and S_ID =" + btn.Text;

                    dt = db.ExecuteQuery(que);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        break;
                    }
                }
                if (seatTable.Rows[i][4].ToString().CompareTo("1") == 0)
                    thisNearWindow = true;

                if (seatTable.Rows[i][5].ToString().CompareTo("1") == 0)
                    thisNearSocket = true;

                if (nearWindow == true && thisNearWindow == false)
                    btn.Visible = false;

                if (nearSocket == true && thisNearSocket == false)
                    btn.Visible = false;

                btn.Click += NewBtn_Click;

                this.MainPanel.Controls.Add(btn);

                btn.BackColor = Color.Transparent;

            }
        }

        private void AddSeatC()
        {
            Label label = new Label();
            label.Text = "C区";
            label.Location = new Point(30, 185);
            this.MainPanel.Controls.Add(label);
            string floor = FloorComboBox.SelectedItem.ToString();
            dbsql db = new dbsql();
            string query = "select * from Seat where S_Location = 3 AND S_Floor = " + floor;

            DataTable seatTable = db.ExecuteQuery(query);

            for (int i = 0; i < seatTable.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Parent = MainPanel;
                btn.Location = new Point(i * 110 + 30, 210);
                btn.Size = new Size(100, 30);
                btn.Text = seatTable.Rows[i][0].ToString();
                bool thisNearWindow = false;
                bool thisNearSocket = false;
                if (firstIn == false && character == 0)
                {
                    dbsql sql = new dbsql();
                    string que = "select * from User_Seat WHERE Star_Time<="
                   + end.ToShortDateString().ToString()
                   + "and  End_Time>= " + end.ToShortDateString().ToString()
                   + "AND S_ID =" + btn.Text;

                    DataTable dt = new DataTable();
                    dt = db.ExecuteQuery(que);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        break;

                    }

                    que = "select * from User_Seat WHERE End_Time>="
                 + start.ToShortDateString().ToString()
                 + "and Star_Time<=" + start.ToShortDateString().ToString()
                 + "and S_ID =" + btn.Text;

                    dt = db.ExecuteQuery(que);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        break;
                    }
                }
                if (seatTable.Rows[i][4].ToString().CompareTo("1") == 0)
                    thisNearWindow = true;

                if (seatTable.Rows[i][5].ToString().CompareTo("1") == 0)
                    thisNearSocket = true;

                if (nearWindow == true && thisNearWindow == false)
                    btn.Visible = false;

                if (nearSocket == true && thisNearSocket == false)
                    btn.Visible = false;

                btn.Click += NewBtn_Click;
                this.MainPanel.Controls.Add(btn);

                btn.BackColor = Color.Transparent;

            }
        }

        private void AddSeatD()
        {
            Label label = new Label();
            label.Text = "D区";
            label.Location = new Point(30, 275);
            this.MainPanel.Controls.Add(label);
            string floor = FloorComboBox.SelectedItem.ToString();
            dbsql db = new dbsql();
            string query = "select * from Seat where S_Location = 4 AND S_Floor = " + floor;

            DataTable seatTable = db.ExecuteQuery(query);

            for (int i = 0; i < seatTable.Rows.Count; i++)
            {
                Button btn = new Button();
                btn.Parent = MainPanel;
                btn.Location = new Point(i * 110 + 30, 300);
                btn.Size = new Size(100, 30);
                btn.Text = seatTable.Rows[i][0].ToString();
                bool thisNearWindow = false;
                bool thisNearSocket = false;
                if (firstIn == false && character == 0)
                {
                    string que = "select * from User_Seat WHERE Star_Time<='"
                   + end.ToString("yyyy-MM-dd hh:mm:ss")
                   + "'and  End_Time>=' " + end.ToString("yyyy-MM-dd hh:mm:ss")
                   + "'AND S_ID =" + btn.Text;

                    DataTable dt = new DataTable();
                    dt = db.ExecuteQuery(que);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        break;

                    }

                    que = "select * from User_Seat WHERE End_Time>='"
                 + start.ToString("yyyy-MM-dd hh:mm:ss")
                 + "'and Star_Time<='" + start.ToString("yyyy-MM-dd hh:mm:ss")
                 + "'and S_ID =" + btn.Text;

                    dt = db.ExecuteQuery(que);
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        break;
                    }
                }
                if (seatTable.Rows[i][4].ToString().CompareTo("1") == 0)
                    thisNearWindow = true;

                if (seatTable.Rows[i][5].ToString().CompareTo("1") == 0)
                    thisNearSocket = true;

                if (nearWindow == true && thisNearWindow == false)
                    btn.Visible = false;

                if (nearSocket == true && thisNearSocket == false)
                    btn.Visible = false;

                btn.Click += NewBtn_Click;
                this.MainPanel.Controls.Add(btn);

                btn.BackColor = Color.Transparent;

            }
        }

        private void NewBtn_Click(object sender, EventArgs e)
        {
            if(firstIn == true && character == 0)
            {
                Button tempBtn = (Button)sender;
                TimeSelectForm TimeSelectForm = new TimeSelectForm(false, tempBtn.Text, uid);
                TimeSelectForm.Show();
                this.Hide();
            }
            else if(firstIn == false && character == 0)
            {
                Button tempBtn = (Button)sender;

                dbsql db = new dbsql();
                string query;
                
                query = "insert into User_Seat values('" + tempBtn.Text + "','" + uid + "','" + start.ToString() + "','" + end.ToString() + "')";
                int right = db.ExecuteUpdate(query);

                if (right== 3)
                    MessageBox.Show("预定成功！", "恭喜");

                this.Close();
            }
            else
            {
                Button tempBtn = (Button)sender;
                SeatManageForm SeatManageForm = new SeatManageForm(tempBtn.Text);
                SeatManageForm.Show();
            }
            
        }

        private void NearWindowsCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (NearWindowsCheck.CheckState == CheckState.Checked)
                nearWindow = true;
            else
                nearWindow = false;
            AddSeat();
        }

        private void NearSocketCheck_CheckedChanged(object sender, EventArgs e)
        {
            if (NearSocketCheck.CheckState == CheckState.Checked)
                nearSocket = true;
            else
                nearSocket = false;
            AddSeat();
        }

        private void FloorSelectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(character == 1)
            {
                ManagerGUI ManagerGUI = new ManagerGUI(uid);
                ManagerGUI.Show();
            }
            if (character == 0)
            {
                UserGUI UserGUI = new UserGUI(uid);
                UserGUI.Show();
            }
            
        }
    }
}
