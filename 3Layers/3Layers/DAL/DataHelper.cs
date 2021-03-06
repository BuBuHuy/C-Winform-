﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;

namespace _3Layers.DAL
{
    public class DataHelper
    {
        public SqlConnection cnn { get; set; }
        public DataHelper(string stringConnect)
        {
            this.cnn = new SqlConnection(stringConnect);

        }

        public DataTable GetTable(string query)
        {
            DataTable dtb = new DataTable();
            this.cnn.Open();
            SqlDataAdapter adapter = new SqlDataAdapter(query, this.cnn);
            adapter.Fill(dtb);
            this.cnn.Close();
            return dtb;
        }
        public void excuteMainQuery(string mainQuery)
        {
            SqlCommand cmd = new SqlCommand(mainQuery, cnn);
            this.cnn.Open();
            cmd.ExecuteNonQuery();
            this.cnn.Close();
        }
    }
}
