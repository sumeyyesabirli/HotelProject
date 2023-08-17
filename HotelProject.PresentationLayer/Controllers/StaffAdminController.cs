using HotelProject.BusinessLayer.Abstract;
using HotelProject.Entitylayer.Concrete;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.PresentationLayer.Controllers
{
    
    public class StaffAdminController : Controller
    {
        private readonly IStaffService _staffService;

        public StaffAdminController(IStaffService staffService)
        {
            _staffService = staffService;
        }

        public IActionResult Index()
        {

            var values = _staffService.TGetList();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddStaff()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddStaff(Staff staff, IFormFile file)
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

                staff.ImageUrl = yol; // Görsel yolunu sakla
            }

            _staffService.TInsert(staff);
            return RedirectToAction("Index");

        }
        public IActionResult DeleteStaff(int id)
        {
            var value = _staffService.TGetByID(id);
            _staffService.TDelete(value);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult UpdateStaff(int id)
        {

            var value = _staffService.TGetByID(id);
            return View(value);
        }
        [HttpPost]
        public IActionResult UpdateStaff(Staff staff, IFormFile file)
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

                staff.ImageUrl = yol; // Görsel yolunu sakla
            }


            _staffService.TUpdate(staff);
            return RedirectToAction("Index");

        }

        public PartialViewResult PartialStaff()
        {

            return PartialView();
        }
    }
}

