using Bookstore.Models;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.ViewModels
{
    public class BookAuthorViewModel
    {

        [Display(Name = "Book ID")]
        public int BookID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        [Display(Name = "Author")]
        public int AuthorId { get; set; }

        public List<Author> Authors { get; set; }
    }
}
