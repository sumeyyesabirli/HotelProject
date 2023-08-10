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
    public class RoomDetailManager : IRoomDetailService
    {
        private readonly IRoomDetailDal _roomDetailDal;

        public RoomDetailManager(IRoomDetailDal roomDetailDal)
        {
          _roomDetailDal = roomDetailDal;
        }

        public void TDelete(RoomDetail t)
        {
            _roomDetailDal.Delete(t);
        }

        public RoomDetail TGetByID(int id)
        {
           return _roomDetailDal.GetByID(id);
        }

        public List<RoomDetail> TGetList()
        {
           return _roomDetailDal.GetList();
        }

        public void TInsert(RoomDetail t)
        {
           _roomDetailDal.Insert(t);
        }

        public void TUpdate(RoomDetail t)
        {
            _roomDetailDal.Update(t);
        }
    }
}
