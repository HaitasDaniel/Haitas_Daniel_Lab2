using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Haitas_Daniel_Lab2.Models
{
    public class Author
    {
        public int ID { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }

        [NotMapped]
        [Display(Name = "Author")]
        public string FullName => FirstName + " " + LastName;

        [ScaffoldColumn(false)]
        public ICollection<Book>? Books { get; set; } //navigation property
    }
}
