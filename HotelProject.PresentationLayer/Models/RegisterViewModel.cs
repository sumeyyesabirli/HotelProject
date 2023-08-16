using System.ComponentModel.DataAnnotations;

namespace HotelProject.PresentationLayer.Models
{
    public class RegisterViewModel
    {

        [Required(ErrorMessage = "Ad alanı boş geçilemez")]
        public string Name { get; set; }
        public string Surname { get; set; }
        [Required(ErrorMessage = "Email alanı boş geçilemez")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Şifre Alanı Gereklidir")]
        public string Username { get; set; }
        public string Password { get; set; }
    }
}
