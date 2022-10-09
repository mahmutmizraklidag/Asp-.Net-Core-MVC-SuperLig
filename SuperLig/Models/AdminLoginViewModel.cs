using System.ComponentModel.DataAnnotations;

namespace SuperLig.Models
{
    public class AdminLoginViewModel
    {
        [Display(Name = "Kullanıcı Adı"), StringLength(30), Required(ErrorMessage = "Kullanıcı adı boş geçilemez!")]
        public string Username { get; set; }
        [Display(Name = "Şifre"), StringLength(30), Required(ErrorMessage = "Şifre alanı boş geçilemez!"), DataType(DataType.Password)]
        public string password { get; set; }
    }
}
