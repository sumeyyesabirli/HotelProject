using HotelProject.BusinessLayer.Abstract;
using HotelProject.Entitylayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Controllers
{
    public class AdminRoomController : Controller
    {
        private readonly IRoomService _roomService;

        public AdminRoomController(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public IActionResult Index()
        {
            var values=_roomService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddRoom()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddRoom(Room room)
        {
            _roomService.TInsert(room);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteRoom(int id)
        {
            var value = _roomService.TGetByID(id);
            _roomService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult UpdateRoom(int id)
        {
            var value = _roomService.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateRoom(Room room)
        {
            _roomService.TUpdate(room);
            return RedirectToAction("Index");
        }
    }
}
