using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.ViewComponents.Default
{
    public class _AboutSection : ViewComponent
    {
      private readonly IHotelResumeService _hotelResumeService;

        public _AboutSection(IHotelResumeService hotelResumeService)
        {
            _hotelResumeService = hotelResumeService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _hotelResumeService.TGetList();
            return View(values);
        }
    }
}
