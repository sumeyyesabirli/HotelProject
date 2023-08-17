using HotelProject.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Abstract
{
    public interface IBookRoomService : IGenericService<BookRoom>
    {
        void TBookingStatusChangeApproved(BookRoom bookRoom);
        void TBookingStatusChangeApproved2(int id);
        void TBookingWaitAdmin(int id);
    }
}
