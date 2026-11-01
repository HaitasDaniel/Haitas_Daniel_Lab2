using System.ComponentModel.DataAnnotations;

namespace Haitas_Daniel_Lab2.Models
{
    public class Publisher
    {
        public int ID { get; set; }

        [Display(Name = "Publisher Name")]
        public string PublisherName { get; set; }

        [ScaffoldColumn(false)]
        public ICollection<Book>? Books { get; set; } //navigation property
    }
}
