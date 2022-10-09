using System.ComponentModel.DataAnnotations;

namespace SuperLig.Entities
{
    public class Team
    {
        public int Id { get; set; }
        [Display(Name = "Adı"), StringLength(50), Required(ErrorMessage = "Bu Alan Gereklidir!")]
        public string Name { get; set; }
        [Display(Name = "Açıklama")]
        public string? Description { get; set; }
        [Display(Name = "Resim")]
        public string? Image { get; set; }
        [Display(Name = "Kuruluş Tarihi"),Required(ErrorMessage ="Bu alan zorunludur"),DataType(DataType.Date)]
        public DateTime CreateDate { get; set; }
        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }
        [Display(Name = "Kategori")]
        public virtual Category? Category { get; set; }
        [Display(Name = "Lig")]
        public int LeagueId { get; set; }
        [Display(Name = "Lig")]
        public virtual League? League { get; set; }
        public virtual List<Player> Players { get; set; }
        public Team()
        {
            Players = new List<Player>();
        }



    }
}
