using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShowRoomOto
{
	class Globals
	{
		public static string loginName { get; private set; }

		public static void SetLoginName(string ln)
		{
			loginName = ln;
		}
		public static string passWord { get; private set; }

		public static void SetPassword(string pw)
		{
			passWord = pw;
		}

		public static string strCon { get; private set; }

		public static void SetStrCon(string str)
		{
			strCon = str;
		}

	}
}
