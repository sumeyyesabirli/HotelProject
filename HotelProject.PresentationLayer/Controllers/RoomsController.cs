using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Controllers
{
    public class RoomsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
