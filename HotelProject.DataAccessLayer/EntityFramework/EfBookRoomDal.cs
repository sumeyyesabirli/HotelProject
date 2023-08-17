using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.DataAccessLayer.Repositories;
using HotelProject.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.EntityFramework
{
    public class EfBookRoomDal : GenericRepository<BookRoom>, IBookRoomDal
    {

        public void BookingStatusChangeApproved(BookRoom booking)
        {
            using var context = new Context();
            var values = context.BookRooms.Where(x => x.Id == booking.Id).FirstOrDefault();
            values.Status = "onaylandı";
            context.SaveChanges();

        }
        public void BookingStatusChangeApproved2(int id)
        {
            using var context = new Context();
            var values = context.BookRooms.Find(id);
            values.Status = "Onayladı";
            context.SaveChanges();
        }

        public void BookingWaitAdmin(int id)
        {
            using var context = new Context();
            var values = context.BookRooms.Find(id);
            values.Status = "Beklemeye Alındı";
            context.SaveChanges();
        }
    }
}
