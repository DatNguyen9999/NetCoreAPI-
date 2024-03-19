using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models;
public class Employee 
{
    [Key]
    public string? Id {get; set; }
    public string? FullName {get; set; }
    public string? Age {get; set; }
    public string? Luong {get; set; }
}
