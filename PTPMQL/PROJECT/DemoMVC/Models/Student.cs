using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DemoMVC.Models
{
    [Table("Student")]
    public class Student
    {
        [Key]
        public string StudentID { get; set; } = default!;
        [Required(ErrorMessage = "FullName is required.")]
        public string FullName { get; set; } = default!; 
        public string Address { get; set; }

    }
}