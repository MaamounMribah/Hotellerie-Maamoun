using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Hotellerie_Maamoun.Models.HotellerieModel
{
    public class Hotel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "La longueur du Nom doit etre compris entre 3 et 20")]
        public String Nom { get; set; } = null!;
        [Range(1,5,ErrorMessage ="the value of Etoiles must be between 1 and 5")]
        public int Etoiles { get; set; } 
        [Required(ErrorMessage = "Ce champ est obligatoire")]
        public string Ville { get; set; } = null!;
        [Required]
        [DisplayName("Site Web")]
        [Url(ErrorMessage ="ce champ n'accepte que des URLs (http://x.x)")]

        public string SiteWeb { get; set; } = null!;
        public int Tel { get; set; }
        public string Pays { get; set; } = null!;
        public virtual ICollection<Appreciation> Appreciations { get; set; } = new List<Appreciation>();
    }
}
