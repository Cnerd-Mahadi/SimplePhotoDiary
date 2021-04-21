using SimplePhotoDiary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePhotoDiary.Data_Access_Layer
{
    class UserDataAccess : DataBaseAccess
    {
        public int AddAnUser(User receive)
        {
            string sql = "INSERT INTO Users (UserName, Password) VALUES ('" + receive.UserName + "', '" + receive.Password + "')";
            return this.QueryExecution(sql);
            
        }

        public int UserProfileAuthentication (User receive)
        {
            string sql = "SELECT * FROM Users WHERE UserName = '" + receive.UserName + "' AND Password = '" + receive.Password + "'";
            SqlDataReader reader = this.GetData(sql);
            if(reader.Read())
            {
                reader.Close();
                return 1;

            }
            else
            {
                reader.Close();
                return -1;
               
            }
        }

        public int GetUserIdData (User receive)
        {
            string sql = "SELECT * FROM Users WHERE UserName = '" + receive.UserName + "' AND Password = '" + receive.Password + "'";
            SqlDataReader reader = this.GetData(sql);
            reader.Read();
            return Convert.ToInt32(reader["UserId"]);
            
        }

    }
}
