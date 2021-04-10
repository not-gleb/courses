using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Course
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public Organisation Organisation { get; set; }
        [Required]
        public Lecturer Lecturer { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string CourseType { get; set; }
        [Required]
        public int LengthDays { get; set; }
        [Required]
        public int Places { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal TaxPrice { get; set; }
    }
}
