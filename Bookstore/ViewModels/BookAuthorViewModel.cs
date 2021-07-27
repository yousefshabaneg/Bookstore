using Bookstore.Models;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Bookstore.ViewModels
{
    public class BookAuthorViewModel
    {

        public int BookID { get; set; }

        [Required, MaxLength(100)]
        public string Title { get; set; }

        [Required, StringLength(5, MinimumLength = 1)]
        public string Description { get; set; }

        [Display(Name = "Author")]
        public int AuthorId { get; set; }

        public List<Author> Authors { get; set; }

        public IFormFile File { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
    }
}
