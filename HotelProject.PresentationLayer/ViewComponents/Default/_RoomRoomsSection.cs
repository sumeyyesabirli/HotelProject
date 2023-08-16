using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.ViewComponents.Default
{
    public class _RoomRoomsSection : ViewComponent
    {
        private readonly IRoomService _roomService;

        public _RoomRoomsSection(IRoomService roomService)
        {
            _roomService = roomService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _roomService.TGetList();
            return View(values);
        }
    }
    
}
