using System.ComponentModel.DataAnnotations;

namespace TaskApp.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public string Abbreviation { get; set; } = "";

        public string Color { get; set; } = "";

        public List<Task>? Tasks { get; set; } = new List<Task>();
    }
}
