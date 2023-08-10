using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {

            return View();
        }
    }
}
