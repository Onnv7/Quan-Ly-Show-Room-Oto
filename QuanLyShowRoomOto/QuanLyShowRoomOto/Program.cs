using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyShowRoomOto
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Globals.SetStrCon(@"Data Source=.;Initial Catalog=QuanLyShowroomOto;Integrated Security=True");
			Application.Run(new LoginForm());
		}
	}
}
