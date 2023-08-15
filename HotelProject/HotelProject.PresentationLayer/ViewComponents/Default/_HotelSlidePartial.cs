using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.ViewComponents.Default
{
    public class _HotelSlidePartial : ViewComponent
    {
        private readonly ISlideService _service;

        public _HotelSlidePartial(ISlideService service)
        {
            _service = service;
        }

        public IViewComponentResult Invoke()
        {
            var values = _service.TGetList();
            return View(values);
        }
    }
}
