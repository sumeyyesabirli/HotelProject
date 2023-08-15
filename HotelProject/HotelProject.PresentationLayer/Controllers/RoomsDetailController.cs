using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using HotelProject.Entitylayer.Concrete;
using HotelProject.PresentationLayer.Models;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Controllers
{
    public class RoomsDetailController : Controller
    {
        private readonly IRoomService _roomService;
       
        Context context = new Context();

        public RoomsDetailController(IRoomService roomService, Context context)
        {
            _roomService = roomService;
            this.context = context;
        }

        public IActionResult Index(int id)
        {
            
            var value = context.Rooms.Find(id);
            return View(value);
        }

        public  IActionResult GetDetail(int id)         
        {
            var values = _roomService.TGetByID(id);
            //var value = context.Rooms.Find(id);
            return View(values);
        }
        public ActionResult RoomList(int page = 1, int pageSize = 10)
        {
            var allRooms = _roomService.TGetList(); 

            int totalRooms = allRooms.Count;
            int totalPages = (int)Math.Ceiling((double)totalRooms / pageSize);

            var roomsOnPage = allRooms.Skip((page - 1) * pageSize).Take(pageSize).ToList();

            var viewModel = new RoomViewList
            {
                Rooms = roomsOnPage,
                TotalPages = totalPages,
                CurrentPage = page
            };

            return View(viewModel);
        }
    }
}
