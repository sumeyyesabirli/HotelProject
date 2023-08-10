using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.ViewComponents.Default
{
    public class _FooterSection : ViewComponent
    {

        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
