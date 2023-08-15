using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entitylayer.Concrete
{
    public class BookRoom
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int? PhoneNumber { get; set; }
        public string? RoomType { get; set; }
        public string? Surname { get; set; }
        public string? Mail { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }
        public string? AdultCount { get; set; }
        public string? ChildCount { get; set; }
        public string? RoomCount { get; set; }
        public string? SpecialRequest { get; set; }
        public string? Description { get; set; }
        public string? Status { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? SpecialNote { get; set; }
    }
}
