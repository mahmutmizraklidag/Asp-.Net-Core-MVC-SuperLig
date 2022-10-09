using System.ComponentModel.DataAnnotations;

namespace SuperLig.Entities
{
    public class Player
    {
        public int Id { get; set; }
        [Display(Name ="Adı"),StringLength(50),Required(ErrorMessage ="Bu alan Zorunludur")]
        public string Name { get; set; }
        [Display(Name = "Soyadı"), StringLength(50), Required(ErrorMessage = "Bu alan Zorunludur")]
        public string Surname { get; set; }
        [Display(Name = "Doğum Tarihi"), Required(ErrorMessage = "Bu alan Zorunludur"),DataType(DataType.Date)]
        public DateTime Birth { get; set; }
        [Display(Name = "Boyu"), StringLength(5), Required(ErrorMessage = "Bu alan Zorunludur")]
        public string Size { get; set; }
        [Display(Name = "Kullandığı Ayak"), StringLength(15), Required(ErrorMessage = "Bu alan Zorunludur")]
        public string Foot { get; set; }
        [Display(Name = "Resim"), StringLength(100)]
        public string? Image { get; set; }
        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
        [Display(Name = "Takım")]
        public int TeamId { get; set; }
        [Display(Name = "Takım")]
        public Team? Team { get; set; }


    }
}
