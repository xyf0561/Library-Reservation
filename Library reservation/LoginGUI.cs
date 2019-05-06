using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Library_reservation
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        
        private void IDTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            IDTextBox.Text = "";
        }

        private void PasswordTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            
            PasswordTextBox.Text = "";
            
        }

        private void IDTextBox_Leave(object sender, EventArgs e)
        {
            if(IDTextBox.Text == "")
                IDTextBox.Text = "用户ID";
        }

        private void PasswordTextBox_Leave(object sender, EventArgs e)
        {
            if (PasswordTextBox.Text == "")
            {
                PasswordTextBox.UseSystemPasswordChar = false;
                PasswordTextBox.Text = "密码";
            }
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            InputLegality check = new InputLegality();

            if ((!(check.legality(IDTextBox.Text, 10) && check.legality(PasswordTextBox.Text, 6)))&&((SelectUser.Checked)))
            {
                MessageBox.Show("请检查输入符号类型及长度，然后重试。\n如多次失败，请联系管理员。", "用户名或密码非法");
                return;
            }
            

            if (!VerifyID())
            {
                MessageBox.Show("输入错误，请核对信息", "警告");
            }
            else if (SelectUser.Checked)
            {
                UserGUI UserGUI = new UserGUI(IDTextBox.Text);
                UserGUI.Show();
                this.Hide();
            }
            else
            {
                ManagerGUI ManagerGUI = new ManagerGUI(IDTextBox.Text);
                ManagerGUI.Show();
                this.Hide();
            }
        }

        private bool VerifyID()     //用于在登陆界面校验密码是否正确
        {
            String str1 = IDTextBox.Text;       //获取用户输入的ID
            String str2 = PasswordTextBox.Text;       //获取用户输入的密码
            String str3;
            if (SelectUser.Checked)       //如果以学生身份
            {
                str3 = "select U_ID,Password FROM D_User WHERE U_ID='" + str1 + "'AND Password='" + str2 + "'";
                dbsql res = new dbsql();  
                DataTable dt = new DataTable();   
                dt = res.ExecuteQuery(str3);     
                if (dt != null && dt.Rows.Count > 0)        //判断是否能找的匹配的数据
                {
                    return true;       //身份校验成功
                }
            }

            if (SelectManager.Checked)       //如果以管理员身份
            {
                str3 = "select M_ID,M_Password FROM D_Manager WHERE M_ID='" + str1 + "'AND M_Password='" + str2 + "'";
                dbsql res = new dbsql();  
                DataTable dt = new DataTable(); 
                dt = res.ExecuteQuery(str3);      
                if (dt != null && dt.Rows.Count > 0)            //判断是否能找的匹配的数据
                {
                    return true;       //身份校验成功
                }
            }

            return false;       //身份校验失败

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
