using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.Entitylayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.BusinessLayer.Concrete
{
    public class BookRoomManager : IBookRoomService
    {
        private readonly IBookRoomDal _bookRoomDal;

        public BookRoomManager(IBookRoomDal bookRoomDal)
        {
            _bookRoomDal = bookRoomDal;
        }

        public void TBookingStatusChangeApproved(BookRoom bookRoom)
        {
            _bookRoomDal.BookingStatusChangeApproved(bookRoom);
        }

        public void TBookingStatusChangeApproved2(int id)
        {
            _bookRoomDal.BookingStatusChangeApproved2(id);
        }

        public void TBookingWaitAdmin(int id)
        {
            _bookRoomDal.BookingWaitAdmin(id);
        }

        public void TDelete(BookRoom t)
        {
            _bookRoomDal.Delete(t);
        }

        public BookRoom TGetByID(int id)
        {
            return _bookRoomDal.GetByID(id);
        }

        public List<BookRoom> TGetList()
        {
            return _bookRoomDal.GetList();
        }

        public void TInsert(BookRoom t)
        {
            _bookRoomDal.Insert(t);
        }

        public void TUpdate(BookRoom t)
        {
            _bookRoomDal.Update(t);
        }
    }
}
