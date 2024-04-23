using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;
public class Student
{   
    [Key]
    public string? StudentID {get; set;}
    public string? FullName {get; set;}
    public string? Address {get; set;}
}