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
            var values=_bookRoomService.TGetList();
            return View(values);
        }
    
    }
}
