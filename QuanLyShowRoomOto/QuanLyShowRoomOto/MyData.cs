using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyShowRoomOto
{
	class MyData
	{
       // Globals globals;
        // Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=AnT;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        static string strCon =  Globals.strCon;

        SqlConnection con = new SqlConnection(strCon);
        public MyData()
		{
            //   strCon = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = AnT;User ID =NV004; password=123";
            strCon = Globals.strCon;
            con = new SqlConnection(strCon);
        }            
        public SqlConnection getConnection
        {
            get { return con; }
        }
        public void openConnection()
        {
            //   strCon = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = AnT;User ID =" + Globals.loginName + "; password=" + Globals.passWord;
            //   strCon = @"Data Source = (localdb)\MSSQLLocalDB;Initial Catalog = AnT;User ID =NV004; password=123";
            strCon = Globals.strCon;
            con = new SqlConnection(strCon);
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
        public DataTable getData(string sqlStr)
        {
            strCon = Globals.strCon;
            SqlConnection con = new SqlConnection(strCon);
            SqlCommand cmd = new SqlCommand(sqlStr, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable tb = new DataTable();
            adapter.Fill(tb);
            return tb;
        }
    }
}
