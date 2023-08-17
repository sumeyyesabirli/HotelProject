using HotelProject.BusinessLayer.Abstract;
using HotelProject.Entitylayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Controllers
{
    public class BookingAdminController : Controller
    {
        private readonly IBookRoomService _bookRoomService;

        public BookingAdminController(IBookRoomService bookRoomService)
        {
            _bookRoomService = bookRoomService;
        }

        public IActionResult Index()
        {
            var values = _bookRoomService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult ApprovedReservatiion(int id)
        {
            _bookRoomService.TBookingStatusChangeApproved2(id);
            return RedirectToAction("Index");
        }

        public IActionResult DeleteBookingAdmin(int id)
        {
            var values = _bookRoomService.TGetByID(id);
            _bookRoomService.TDelete(values);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult WaitReservation(int id)
        {
            _bookRoomService.TBookingWaitAdmin(id);
            return RedirectToAction("Index");

        }
        [HttpGet]

        public IActionResult UpdateBookRoom(int id)
        {
            var value = _bookRoomService.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateBookRoom(BookRoom bookRoom)
        {
            bookRoom.Status = "Onaylama bekliyor";
            _bookRoomService.TUpdate(bookRoom);
            return RedirectToAction("Index");
        }


    }
}
