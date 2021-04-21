using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePhotoDiary.Data_Access_Layer.Entities
{
    class User
    {
        public int UserId
        {
            set ; get;
        }

        public string UserName
        {
            set; get;
        }

        public string Password
        {
            set; get;
        }

    }
}
