using SimplePhotoDiary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePhotoDiary.Data_Access_Layer
{
    class DataBaseAccess
    {
        protected SqlConnection connection;
        protected SqlCommand command;
        public DataBaseAccess()
        {
            try
            {
                this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["SimplePhotoDiarydb"].ConnectionString);
                this.connection.Open();
            }

            catch (Exception) { }

        }


        public SqlDataReader GetData(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteReader();
        }

        public int QueryExecution(string sql)
        {
            this.command = new SqlCommand(sql, connection);
            return this.command.ExecuteNonQuery();
        }

        public int ImageAdditionQueryExecution(string sql, byte[] images)
        {
            this.command = new SqlCommand();
            this.command.Connection = connection;
            this.command.Parameters.Clear();
            this.command.Parameters.AddWithValue("@pictures", images);
            this.command.CommandText = sql;
            return this.command.ExecuteNonQuery();
        }

        
    }
}
