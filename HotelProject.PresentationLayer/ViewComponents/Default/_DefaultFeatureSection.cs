using HotelProject.BusinessLayer.Abstract;
using HotelProject.Entitylayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.ViewComponents.Default
{
    public class _DefaultFeatureSection : ViewComponent
    {
        private readonly IPrivilegesServices _privilegesServices;

        public _DefaultFeatureSection(IPrivilegesServices privilegesServices)
        {
            _privilegesServices = privilegesServices;
        }

        public IViewComponentResult Invoke()
      {
          var values = _privilegesServices.TGetList();
          return View(values);
      }
    }
}
