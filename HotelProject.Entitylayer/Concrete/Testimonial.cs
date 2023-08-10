using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.Entitylayer.Concrete
{
    public class Testimonial
    {
        public int TestimonialId { get; set; }
        public string TestimonialTitle { get; set; }
        public string TestimonialTitle2 { get; set; }
        public string TestimonialDescription { get; set; }
        public string TestimonialImageUrl { get; set; }
        public string TestimonialUserName { get; set; }
        public string TestimonialUserImage { get; set; }
        public int RoomDetailId { get; set; }
        public RoomDetail RoomDetails { get; set; }
        
    }
}
