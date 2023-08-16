using HotelProject.BusinessLayer.Abstract;
using HotelProject.Entitylayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Controllers
{
    public class AdminServiceController : Controller
    {
        private readonly IServiceService _serviceService;

        public AdminServiceController(IServiceService serviceService)
        {
            _serviceService = serviceService;
        }

        public IActionResult Index()
        {
            var values=_serviceService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service)
        {
            _serviceService.TInsert(service);
            return RedirectToAction("Index");
        }
        public IActionResult DeleteService(int id)
        {
            var value = _serviceService.TGetByID(id);
            _serviceService.TDelete(value);
            return RedirectToAction("Index");
        }

        [HttpGet]

        public IActionResult UpdateService(int id)
        {
            var value = _serviceService.TGetByID(id);
            return View(value);
        }

        [HttpPost]
        public IActionResult UpdateService(Service service)
        {
            _serviceService.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
