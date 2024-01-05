using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Ad ve Soyad alan� zorunludur.")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "E-posta adresi alan� zorunludur.")]
        [EmailAddress(ErrorMessage = "Ge�erli bir e-posta adresi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mesaj alan� zorunludur.")]
        public string Mesaj { get; set; }
    }
}