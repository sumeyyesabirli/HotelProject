using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.ViewComponents.Default
{
    public class _RoomRoomsSection : ViewComponent
    {
        private readonly IRoomDetailService _roomDetailService;

        public _RoomRoomsSection(IRoomDetailService roomDetailService)
        {
            _roomDetailService = roomDetailService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _roomDetailService.TGetList();
            return View(values);
        }
    }
    
}
