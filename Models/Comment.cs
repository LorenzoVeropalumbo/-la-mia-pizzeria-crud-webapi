using la_mia_pizzeria_static.Validation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Comment
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(50, ErrorMessage = "Il titolo non può essere oltre i 50 caratteri")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(255, ErrorMessage = "La descrizione non può essere oltre i 255 caratteri")]
        [AlmenoCinqueParole]
        [Column(TypeName = "text")]
        public string Description { get; set; }

        public int PizzaId { get; set; }
        public Pizza? Pizza { get; set; }
    }
}
