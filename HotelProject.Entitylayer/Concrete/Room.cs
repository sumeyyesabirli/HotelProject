using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entitylayer.Concrete
{
    public class Room
    {
        public int RoomId { get; set; }
        public string? RoomTitle { get; set; }
        public int? RoomNumber { get; set; }
        public string? RoomDescription { get; set; }
        public string? RoomType { get; set; }
        public decimal? RoomSqm { get; set; }
        public decimal? Price { get; set; }
        public bool? Breakfeast { get; set; }
        public bool? FreeWifi { get; set; }
        public bool? Shower { get; set; }
        public int? PersonCount { get; set; }
        public string ImageUrl { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string ImageUrl3 { get; set; }
        public string ImageUrl4 { get; set; }
        public string ImageUrl5 { get; set; }

        public List<RoomDetail> RoomDetails { get; set; }
    }
}
