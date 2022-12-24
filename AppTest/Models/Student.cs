using System.ComponentModel.DataAnnotations;

namespace AppTest.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
