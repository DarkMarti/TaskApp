using System.ComponentModel.DataAnnotations;

namespace TaskApp.Models
{
    public class CategoryDTO
    {
        [Required]
        public string Name { get; set; } = "";

        [Required]
        public string Abbreviation { get; set; } = "";

        [Required]
        public string Color { get; set; } = "";
    }
}
