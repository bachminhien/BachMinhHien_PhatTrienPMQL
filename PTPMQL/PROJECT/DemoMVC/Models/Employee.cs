using DemoMVC.Models;

namespace MvcMovie.Models
{
    public class Employee : Student
    {
        public string EmployeeId { get; set; }
        public int Agg { get; set; } 
    }
}