using System.ComponentModel.DataAnnotations;

namespace SuperLig.Entities
{
    public class Contact
    {
        public int Id { get; set; }
        [Display(Name = "İsim"), StringLength(50), Required(ErrorMessage = "Bu alan Gereklidir.")]
        public string Name { get; set; }
        [Display(Name = "Soyisim"), StringLength(50), Required(ErrorMessage = "Bu alan Gereklidir.")]
        public string Surname { get; set; }
        [DataType(DataType.EmailAddress), Required(ErrorMessage = "Bu alan Gereklidir.")]
        public string Email { get; set; }
        [Display(Name = "Telefon No"), Required(ErrorMessage = "Bu alan Gereklidir."), DataType(DataType.PhoneNumber)]
        public string? PhoneNumber { get; set; }
        [Display(Name = "Mesaj"), StringLength(500), Required(ErrorMessage = "Bu alan Gereklidir.")]
        public string Message { get; set; }
    }
}
