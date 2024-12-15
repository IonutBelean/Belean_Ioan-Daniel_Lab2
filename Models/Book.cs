using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Policy;

namespace Belean_Ioan_Daniel_Lab2.Models
{
    public class Book
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "Book Title")]
        public string Title { get; set; }

        //[Required]
        //public string Author { get; set; }

        [Column(TypeName = "decimal(6, 2)")]
        public decimal Price { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Publishing Date")]
        public DateTime PublishingDate { get; set; }

        public int? PublisherID { get; set; }
        public Publisher? Publisher { get; set; } 

        public int? AuthorID { get; set; }
        public Author? Author { get; set; } 
    }
}
