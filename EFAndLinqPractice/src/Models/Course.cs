using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EFAndLinqPractice_SchoolAPI.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public List<Student> Students { get; set; }
    }
}