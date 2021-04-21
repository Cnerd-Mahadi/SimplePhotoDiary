using SimplePhotoDiary.Data_Access_Layer;
using SimplePhotoDiary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SimplePhotoDiary.Service_Layer
{
    class UserDataService
    {
        UserDataAccess userDataAccess;

        public UserDataService ()
        {
            this.userDataAccess = new UserDataAccess();
        }

        public int AddUser(string userName, string password)
        {
            User user = new User() { UserName = userName, Password = password};
            return this.userDataAccess.AddAnUser(user);
        }

        public int UserAuthentication(string userName, string password)
        {
            User user = new User() { UserName = userName, Password = password };
            return this.userDataAccess.UserProfileAuthentication(user);
        }

        public int GetUserId (string userName, string password)
        {
            User user = new User() { UserName = userName, Password = password };
            
            return this.userDataAccess.GetUserIdData(user);

        }
    }
}
