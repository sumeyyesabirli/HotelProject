using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.ViewComponents.Default
{
    public class _AboutSection : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
