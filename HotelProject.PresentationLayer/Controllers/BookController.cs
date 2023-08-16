using HotelProject.BusinessLayer.Abstract;
using HotelProject.Entitylayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRoomService _bookRoomService;

        public BookController(IBookRoomService bookRoomService)
        {
            _bookRoomService = bookRoomService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public PartialViewResult AddBooking()
        {
            return PartialView();
        }
        [HttpPost]
        public IActionResult AddBooking(BookRoom room)
        {
            room.Status = "Onay bekliyor";
            room.Description = string.Empty;
            _bookRoomService.TInsert(room);
            return RedirectToAction("Index");

        }
    }
}
