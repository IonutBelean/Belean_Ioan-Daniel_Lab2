using System.ComponentModel.DataAnnotations;

namespace Belean_Ioan_Daniel_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Required]
        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";

        public ICollection<Book>? Books { get; set; } 
    }
}
