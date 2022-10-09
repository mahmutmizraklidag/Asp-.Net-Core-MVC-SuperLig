using System.ComponentModel.DataAnnotations;

namespace SuperLig.Entities
{
    public class Slider
    {
        public int Id { get; set; }
        [Display(Name = "Resim"), StringLength(100)]
        public string? Image { get; set; }
        [StringLength(100)]
        public string? Link { get; set; }
    }
}
