using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimplePhotoDiary.Data_Access_Layer.Entities
{
    class Images
    {
        public int ImageId
        {
            set; get;
        }

        public byte[] Pictures
        {
            get; set; 
        }

        public string Story
        {
            set; get;
        }
        
        public string ModificationDate
        {
            set; get;
        }


        public int EventId
        {
            set; get;
        }

    }
}
