using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApi.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string Name { get; set; } = "";

        public int ContactNumber { get; set; }

        public int Age { get; set; }

        public int? CourseId { get; set; }
        public Course? Course { get; set; }
    }
}
