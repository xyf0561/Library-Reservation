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

namespace Library_reservation.GUI
{
    public partial class AllUserSelectForm : Form
    {
        string mid;
        ListViewTool ListViewTool = new ListViewTool();
        public AllUserSelectForm(string mid)
        {
            InitializeComponent();
            this.mid = mid;
        }

        private void AllUserSelectForm_Load(object sender, EventArgs e)
        {
            dbsql db = new dbsql();
            string query = "select * from D_User ";
            DataTable userTable = db.ExecuteQuery(query);
            ListViewTool.ShowDataInListView(userTable,UserListView);
        }


        private void StartButton_Click(object sender, EventArgs e)
        {
            dbsql db = new dbsql();
            DataTable userTable;
            InputLegality check = new InputLegality();

            if (!check.legality(IDtextBox.Text, -1))
            {
                MessageBox.Show("仅可输入纯数字。", "警告");
                IDtextBox.Text = "";
                return;
            }

            if (IDtextBox.Text == "")
            {
                string query = "select * from D_User ";
                userTable = db.ExecuteQuery(query);
                ListViewTool.ShowDataInListView(userTable, UserListView);
            }
            else
            {
                string query = "select * from D_User WHERE U_ID LIKE '%"+ IDtextBox.Text+"%'";
                userTable = db.ExecuteQuery(query);
                ListViewTool.ShowDataInListView(userTable, UserListView);
            }
        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (UserListView.SelectedIndices != null && UserListView.SelectedIndices.Count > 0)
            {
                ListView.SelectedIndexCollection c = UserListView.SelectedIndices;
                string UserID = UserListView.Items[c[0]].SubItems[0].Text.ToString();
                UserInformationForm UserInformationForm = new UserInformationForm(UserID);
                UserInformationForm.Show();
            }
            
        }

        private void AllUserSelectForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ManagerGUI ManagerGUI = new ManagerGUI(mid);
            ManagerGUI.Show();
        }
    }
}
