using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePhotoDiary.Data_Access_Layer.Entities
{
    class Event
    {
        public int EventId
        {
            set; get;
        }

        public string EventName
        {
            set; get;
        }
        public string Importance
        {
            set; get;
        }
        public string CreationDate
        {
            set; get;
        }

        public int UserId
        {
            set; get;
        }



    }
}
