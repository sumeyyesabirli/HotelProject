using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entitylayer.Concrete
{
    public class Service
    {
        public int ServiceId { get; set; }
        public string? ServiceTitle { get; set; }
        public string? ServiceDescription { get; set; }
        public string? ServiceImageUrl { get; set; }
        public string? Icon { get; set; }
    }
}
