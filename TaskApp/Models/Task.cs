using System.ComponentModel.DataAnnotations;

namespace TaskApp.Models
{ 
    public class Task
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = "";

        public DateTime? StartDate { get; set; } = DateTime.Now;

        public DateTime? EndDate { get; set; } = DateTime.Now.AddDays(7);

        public string? Description { get; set; } = "";


        public Category Category { get; set; } = new Category();
        //public Person Person { get; set; }

    }
}
