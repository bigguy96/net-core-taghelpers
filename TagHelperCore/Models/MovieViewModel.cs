using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TagHelperCore.Models
{
    public class MovieViewModel
    {
        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "The Title is required.")]
        public string Title { get; set; }

        [Display(Name = "Release Date"), DataType(DataType.Date)]
        [Required(ErrorMessage = "The Release Date is required.")]
        public DateTime ReleaseDate { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$"), StringLength(30)]
        [Required(ErrorMessage = "The Genre is required.")]
        public string Genre { get; set; }

        [Range(1, 100), DataType(DataType.Currency)]
        [Required(ErrorMessage = "The Price is required.")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Price { get; set; }

        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$"), StringLength(5)]
        [Required(ErrorMessage = "The Rating is required.")]
        public string Rating { get; set; }
    }
}