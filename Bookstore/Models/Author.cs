using System.ComponentModel.DataAnnotations;

namespace Bookstore.Models
{
    public class Author
    {
        public int Id { get; set; }
        [Display(Name = "Author Name")]
        [Required, StringLength(100, MinimumLength = 10, ErrorMessage = "Please type a valid Name.")]
        public string FullName { get; set; }
    }
}
