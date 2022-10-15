using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShowRoomOto
{
	class Position
	{
		MyData myData = new MyData();
		public bool insertPos(string posCode, string posName)
		{
			myData.openConnection();
			SqlCommand cmd = new SqlCommand("exec procedure_them_chucvu @posCode, @posName", myData.getConnection);
			cmd.Parameters.Add("@posCode", SqlDbType.Char).Value = posCode;
			cmd.Parameters.Add("@posName", SqlDbType.NVarChar).Value = posName;

			try
			{
				if (cmd.ExecuteNonQuery() == 1)
				{
					myData.closeConnection();
					return true;
				}
			}
			catch (Exception)
			{
			}
			myData.closeConnection();
			return false;
		}
		public bool deletePos(string posCode)
		{
			myData.openConnection();
			SqlCommand cmd = new SqlCommand("exec procedure_xoa_chuc_vu @posCode", myData.getConnection);
			cmd.Parameters.Add("@posCode", SqlDbType.Char).Value = posCode;
			try
			{
				if (cmd.ExecuteNonQuery() == 1)
				{
					myData.closeConnection();
					return true;
				}
			}
			catch (Exception)
			{

			}
			myData.closeConnection();
			return false;
		}
		public bool updatePos(string posCode, string posName)
		{
			myData.openConnection();
			SqlCommand cmd = new SqlCommand("exec procedure_sua_chuc_vu @posCode, @posName", myData.getConnection);
			cmd.Parameters.Add("@posCode", SqlDbType.Char).Value = posCode;
			cmd.Parameters.Add("@posName", SqlDbType.NVarChar).Value = posName;
			try
			{
				if (cmd.ExecuteNonQuery() == 1)
				{
					myData.closeConnection();
					return true;
				}
			}
			catch (Exception)
			{

			}
			myData.closeConnection();
			return false;
		}
	}
}
