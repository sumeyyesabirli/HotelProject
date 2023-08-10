using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.ViewComponents.Default
{
    public class _HotelAboutPartial:ViewComponent
    {
        private readonly IHotelResumeService _hotelResumeService;

        public _HotelAboutPartial(IHotelResumeService hotelResumeService)
        {
            _hotelResumeService = hotelResumeService;
        }

        public IViewComponentResult Invoke()
        {
            var values=_hotelResumeService.TGetList();
            return View(values);
        }

    }
}
