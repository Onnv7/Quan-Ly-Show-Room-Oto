using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShowRoomOto
{
	class Employee
	{
        MyData myData = new MyData();
        private string empCode;
        private string lName;
        private string fName;
        private string sex;
        private string idNb;
        private DateTime? bDate;
        private string phone;
        private string email;
        private string salary;
        private DateTime? workDay;
        private string pos;
        public string EmpCode { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string Sex { get; set; }
        public string IdNb { get; set; }
        public DateTime BDate { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Salary { get; set; }
        public DateTime WorkDay { get; set; }
        public string Pos { get; set; }

        public Employee(string empCode, string lName, string fName, string sex, string idNb, DateTime bDate, string phone, string email, string salary, DateTime workDay, string pos)
        {
            this.empCode = empCode;
            this.lName = lName;
            this.fName = fName;
            this.sex = sex;
            this.idNb = idNb;
            this.bDate = bDate;
            this.phone = phone;
            this.email = email;
            this.salary = salary;
            this.workDay = workDay;
            this.pos = pos;
        }

        public Employee()
        {
            this.empCode = "";
            this.lName = "";
            this.fName = "";
            this.sex = "";
            this.idNb = "";
            this.bDate = null;
            this.phone = "";
            this.email = "";
            this.salary = "";
            this.workDay = null;
            this.pos = "";
        }
        public int countEmp(string MaCV)
        {
            int rs = 0;
            myData.openConnection();
            SqlCommand cmd = new SqlCommand("select dbo.function_so_luong_nhan_vien(@MaCV)", myData.getConnection);
            cmd.Parameters.Add("@MaCV", SqlDbType.Char).Value = MaCV;
            try
            {
                rs = Convert.ToInt32(cmd.ExecuteScalar());
            }
            catch (Exception ex)
            {

            }
            return rs;
        }
    }
}
