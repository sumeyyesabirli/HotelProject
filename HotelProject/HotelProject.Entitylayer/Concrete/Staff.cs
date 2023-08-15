using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entitylayer.Concrete
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string? StaffName { get; set; }
        public string? StaffSurname { get; set; }
        public string? StaffEmail { get;set; }
        public string? StaffTitle { get; set; }
        public int? StaffNubmer { get; set; }
        public string?  ImageUrl { get; set; }
    }
}
