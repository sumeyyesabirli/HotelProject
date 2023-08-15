using HotelProject.BusinessLayer.Abstract;
using HotelProject.Entitylayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Controllers
{
    public class GuestController : Controller
    {
        private readonly IGuestService _guestService;

        public GuestController(IGuestService guestService)
        {
            _guestService = guestService;
        }

        public IActionResult Index()
        {
            var values=_guestService.TGetList();
            return View(values);
        }

        [HttpGet]
        public IActionResult AddGuest()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddGuest(Guest guest)
        {
            _guestService.TInsert(guest);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteGuest(int id)
        {
            var value = _guestService.TGetByID(id);
            _guestService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult UpdateGuest(int id)
        {
            var value = _guestService.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateGuest(Guest guest)
        {
            _guestService.TUpdate(guest);
            return RedirectToAction("Index");
        }
    }
}
