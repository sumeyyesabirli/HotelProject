using HotelProject.BusinessLayer.Abstract;
using HotelProject.Entitylayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Controllers
{
    public class StaffController : Controller
    {
        private readonly IStaffService _staffService;

        public StaffController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        public IActionResult Index()
        {

            var values=_staffService.TGetList();
            return View(values);
        }
      

    }
}
