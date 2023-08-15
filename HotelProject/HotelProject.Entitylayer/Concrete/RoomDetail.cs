using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entitylayer.Concrete
{
    public class RoomDetail
    {
        [Key]
        public int RoomDetailsId { get; set; }
        public string? RoomDetailsTitle { get; set; }
        public string? RoomDetailsDescription { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageUrl2 { get; set; }
        public string? ImageUrl3 { get; set; }
        public string? ImageUrl4 { get; set; }
        public string? ImageUrl5 { get; set; }
        public List<Testimonial> Testimonials { get; set; }
        public int RoomId { get; set; }
        public Room Rooms{ get; set; }

    }
}
