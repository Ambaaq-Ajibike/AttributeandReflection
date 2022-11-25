 using CustomeAttribute;
namespace Attribute.ConsoleApp.Models;

public class Student
{
          [Required]
          public int Id{get; set;}
          [StringLength(10)]
          [Required]
          public string FirstName{get; set;}
          [StringLength(10)]
          [Required]
          public string LastName{get; set;}
}
