﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyShowRoomOto
{
    class Car
    {
        MyData myDB = new MyData();
        public DataTable getDataXe(SqlCommand command)
        {
            command.Connection = myDB.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
    }
}
