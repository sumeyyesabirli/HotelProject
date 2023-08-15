using HotelProject.BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.ViewComponents.Default
{
    public class _DefaultFeatureSection : ViewComponent
    {
      private readonly IRoomService _roomService;
     
      public _DefaultFeatureSection(IRoomService roomService)
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
