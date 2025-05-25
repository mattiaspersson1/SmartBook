
using System.ComponentModel.DataAnnotations;

namespace EntityApp.ViewModels
{
    public class BookViewModel
    {
        [Required]
        public string Title { get; set; }

        [Required]
        public string Author { get; set; }

        [Range(1000, 2100)]
        public int Year { get; set; }
    }
}
