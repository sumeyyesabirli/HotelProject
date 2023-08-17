using HotelProject.BusinessLayer.Abstract;
using HotelProject.DataAccessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.ViewComponents.Default
{
    public class _RoomsListImage:ViewComponent
    {
        private readonly IRoomService _roomService;
        Context context = new Context();

        public _RoomsListImage(IRoomService roomService, Context context)
        {
            _roomService = roomService;
            this.context = context;
        }

        public IViewComponentResult Invoke()
        {
           var values = _roomService.TGetList();
            return View(values);
        }
    }
}
