using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.ViewComponents.Default
{
    public class _HotelAboutPartial:ViewComponent
    {
        private readonly IHotelResumeService _hotelResumeService;
        Context context = new Context();

        public _HotelAboutPartial(IHotelResumeService hotelResumeService)
        {
            _hotelResumeService = hotelResumeService;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.description = context.HotelResumes.Select(x=>x.HotelDescription).FirstOrDefault();
            return View();
        }

    }
}
