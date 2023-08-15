using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Controllers
{
    public class MainStaffController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
