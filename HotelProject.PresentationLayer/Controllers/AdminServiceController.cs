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
            var values = _serviceService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddService(Service service, IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                string dosyaadi = Path.GetFileName(file.FileName);
                string uzanti = Path.GetExtension(file.FileName);
                string yol = Path.Combine("Images", dosyaadi); // Yol düzenlemesi
                string fizikselYol = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", yol);

                using (var stream = new FileStream(fizikselYol, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                service.ServiceImageUrl = yol; // Görsel yolunu sakla
            }
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
        public IActionResult UpdateService(Service service, IFormFile file)
        {
            if (file != null && file.Length > 0)
            {
                string dosyaadi = Path.GetFileName(file.FileName);
                string uzanti = Path.GetExtension(file.FileName);
                string yol = Path.Combine("Images", dosyaadi); // Yol düzenlemesi
                string fizikselYol = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", yol);

                using (var stream = new FileStream(fizikselYol, FileMode.Create))
                {
                    file.CopyTo(stream);
                }

                service.ServiceImageUrl = yol; // Görsel yolunu sakla
            }
            _serviceService.TUpdate(service);
            return RedirectToAction("Index");
        }
    }
}
