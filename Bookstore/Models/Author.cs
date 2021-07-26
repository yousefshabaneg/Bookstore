using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Display(Name = "Author Name")]
        public string FullName { get; set; }
    }
}
