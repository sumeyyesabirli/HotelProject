using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entitylayer.Concrete
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string ContactEmail { get; set; }
        public string ContactTitle { get; set; }
        public string ContactDescription { get; set; }
        public string Adress { get; set; }
        public int PhoneNumber { get; set; }
        public DateTime OpenCloseHour { get; set; }
        public string HotelEmail { get; set; }
    }
}
