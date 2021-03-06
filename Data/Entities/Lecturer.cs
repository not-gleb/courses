using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities
{
    public class Lecturer
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public DateTime Birthday { get; set; }
        public string Sex { get; set; }
        public int Degree { get; set; }
    }
}
