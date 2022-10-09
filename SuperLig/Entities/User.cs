using System.ComponentModel.DataAnnotations;

namespace SuperLig.Entities
{
    public class User
    {
        public int Id { get; set; }
        [Display(Name = "Adı"), StringLength(30)]
        public string? Name { get; set; }
        [Display(Name = "Soyadı"), StringLength(30)]
        public string? Surname { get; set; }
        [StringLength(30)]
        public string? Email { get; set; }
        [Display(Name = "Kullanıcı Adı"), StringLength(30), Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        public string Username { get; set; }
        [Display(Name = "Şifre"), StringLength(30), Required(ErrorMessage = "Şifre alanı boş geçilemez!")]
        public string password { get; set; }
        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
        [Display(Name = "Admin")]
        public bool IsAdmin { get; set; }
    }
}
