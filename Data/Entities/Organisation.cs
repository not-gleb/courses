using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Entities
{
    public class Organisation
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string CourseName { get; set; }
        [Required]
        public string Adress { get; set; }
        [Required]
        public string Number { get; set; }
        [Required]
        public string Email { get; set; }

    }
}
