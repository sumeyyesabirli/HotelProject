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
       
    }
}
