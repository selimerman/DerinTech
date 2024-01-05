using System.ComponentModel.DataAnnotations;

namespace Web.Models
{
    public class ContactViewModel
    {
        [Required(ErrorMessage = "Ad ve Soyad alaný zorunludur.")]
        public string Ad { get; set; }

        [Required(ErrorMessage = "E-posta adresi alaný zorunludur.")]
        [EmailAddress(ErrorMessage = "Geçerli bir e-posta adresi giriniz.")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Mesaj alaný zorunludur.")]
        public string Mesaj { get; set; }
    }
}