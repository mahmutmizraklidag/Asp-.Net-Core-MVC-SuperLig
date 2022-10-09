using System.ComponentModel.DataAnnotations;

namespace SuperLig.Entities
{
    public class League
    {
        public int Id { get; set; }
        [Display(Name = "Adı"), StringLength(50), Required(ErrorMessage = "Bu Alan Gereklidir!")]
        public string Name { get; set; }
        [Display(Name = "Resim")]
        public string? Image { get; set; }
        [Display(Name = "Durum")]
        public bool IsActive { get; set; }
        [Display(Name = "Eklenme Tarihi"), ScaffoldColumn(false)]
        public DateTime? CreateDate { get; set; } = DateTime.Now;
        [Display(Name = "Kategori")]
        public int? CategoryId { get; set; }
        [Display(Name = "Kategori")]
        public virtual Category? Category { get; set; }
        public virtual List<Team> Teams { get; set; }
        public League()
        {
            Teams = new List<Team>();
        }

    }
}
