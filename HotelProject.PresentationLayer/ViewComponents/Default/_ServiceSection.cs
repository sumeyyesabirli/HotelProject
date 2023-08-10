using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.ViewComponents.Default
{
    public class _ServiceSection : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
