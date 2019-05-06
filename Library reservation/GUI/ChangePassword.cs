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
    public partial class ChangePassword : Form
    {
        string uid;
        public ChangePassword(string uid)
        {
            InitializeComponent();
            this.uid = uid;
        }

        private void ChangePassWordButton_Click(object sender, EventArgs e)
        {
            InputLegality check = new InputLegality();

            if (!(check.legality(textBox1.Text, 6) && check.legality(textBox1.Text, 6)))
            {
                MessageBox.Show("请确保密码长度正确且为纯数字。", "请重试");
                return;
            }

            if(textBox1.Text.CompareTo(textBox2.Text)!= 0)
            {
                MessageBox.Show("请确保两次密码输入一致", "请重试");
                return;
            }
            dbsql db = new dbsql();
            string query = "UPDATE D_User SET Password ="+ textBox1.Text+ "WHERE U_ID=" + uid;
            int right = 0;
            right = db.ExecuteUpdate(query);
            if (right == 1)
                MessageBox.Show("新密码是"+ textBox1.Text+"\n请牢记新密码", "修改成功");

            this.Close();
        }
    }
}
