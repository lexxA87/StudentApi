using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentApi.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [Column(TypeName = "nvarchar(250)")]
        public string CourseName { get; set; } = "";
        public string CourseDescription { get; set; } = string.Empty;
    }
}
