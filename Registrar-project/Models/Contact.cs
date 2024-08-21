using System.ComponentModel.DataAnnotations;

namespace Registrar;

public class Contact

{
    [Required(ErrorMessage = "Please provide a First Name")]
    public string? FirstName {get; set;}

    [Required(ErrorMessage = "Please provide a Last Name")]
     public string? LastName {get; set;}
    
    [Required(ErrorMessage = "Please provide a Type")]
    public string? Type {get; set;}
     public int Id {get; set;}

    
}