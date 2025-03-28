﻿using la_mia_pizzeria_static.Validation;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(50, ErrorMessage = "Il titolo non può essere oltre i 50 caratteri")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [StringLength(255, ErrorMessage = "La descrizione non può essere oltre i 255 caratteri")]
        [AlmenoCinqueParole]
        [Column(TypeName = "text")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        public string Image { get; set; }

        [Required(ErrorMessage = "Il campo è obbligatorio")]
        [Range(1, 99.99, ErrorMessage = "Il prezzo non può essere superiore a 99,99$ o inferiore di 1$")]
        public float Price { get; set; }


        //relazione 1 a n con Category
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        //relazione n a n con Ingredients
        public List<Ingredient>? Ingredients { get; set; }

        //relazione n a n con Comments
        public List<Comment>? Comments { get; set; }
        
        public Pizza()
        {

        }

        public Pizza(int id, string title, string description, string image, float price)
        {
            Id = id;
            Title = title;
            Description = description;
            Image = image;
            Price = price;
        }
    }
}
