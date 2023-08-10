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
    public class SlideManager : ISlideService
    {
        private readonly ISlideDal _slideDal;

        public SlideManager(ISlideDal slideDal)
        {
            _slideDal = slideDal;
        }

        public void TDelete(Slide t)
        {
            _slideDal.Delete(t);
        }

        public Slide TGetByID(int id)
        {
            return _slideDal.GetByID(id);   
        }

        public List<Slide> TGetList()
        {
            return _slideDal.GetList();
        }

        public void TInsert(Slide t)
        {
            _slideDal.Insert(t);
        }

        public void TUpdate(Slide t)
        {
           _slideDal.Update(t);
        }
    }
}
