using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_reservation
{
    class dbsql  //数据库连接类
    {
        private string MySqlCon = "Data Source=ASUS;Initial Catalog = library; User ID = sa; Password=123456";//根据实际情况可以更改
        public DataTable ExecuteQuery(string sqlStr)      //用于查询的函数
        {
            SqlConnection con = new SqlConnection(@MySqlCon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr;
            DataTable dt = new DataTable();
            SqlDataAdapter msda;
            msda = new SqlDataAdapter(cmd);
            msda.Fill(dt);
            con.Close();     //关闭数据库
            return dt;          //返回DataTable类型的数据
        }

        public int ExecuteUpdate(string sqlStr)      //用于增删改的函数
        {
            SqlConnection con = new SqlConnection(@MySqlCon);
            con.Open();
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = sqlStr;
            int iud = 0;
            iud = cmd.ExecuteNonQuery();
            con.Close();    //关闭数据库
            return iud;     //返回受影响的行数
        }

    }
}
