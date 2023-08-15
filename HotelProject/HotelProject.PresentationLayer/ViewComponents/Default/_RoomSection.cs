using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.ViewComponents.Default
{
    public class _RoomSection : ViewComponent
    {
        private readonly IRoomDetailService _roomDetailService;

        public _RoomSection(IRoomDetailService roomDetailService)
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
