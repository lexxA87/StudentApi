using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApi.Models
{
    public class Course
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string CourseName { get; set; } = "";
        [Column(TypeName = "nvarchar(250)")]
        public string CourseDescription { get; set; } = string.Empty;

        public List<Student> Students { get; set; } = new();
    }
}
