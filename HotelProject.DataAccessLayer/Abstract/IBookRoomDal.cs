using HotelProject.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.DataAccessLayer.Abstract
{
    public interface IBookRoomDal:IGenericDal<BookRoom>
    {
        void BookingStatusChangeApproved(BookRoom booking);
        void BookingStatusChangeApproved2(int id);
    }
}
