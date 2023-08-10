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
    public class HotelResumeManager : IHotelResumeService
    {
        private readonly IHotelResumeDal _hotelResumeDal;

        public HotelResumeManager(IHotelResumeDal hotelResumeDal)
        {
            _hotelResumeDal = hotelResumeDal;
        }

        public void TDelete(HotelResume t)
        {
           _hotelResumeDal.Delete(t);
        }

        public HotelResume TGetByID(int id)
        {
           return _hotelResumeDal.GetByID(id);
        }

        public List<HotelResume> TGetList()
        {
            return _hotelResumeDal.GetList();
        }

        public void TInsert(HotelResume t)
        {
            _hotelResumeDal.Insert(t);
        }

        public void TUpdate(HotelResume t)
        {
            _hotelResumeDal.Update(t);
        }
    }
}
