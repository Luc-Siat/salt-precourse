// namespace webapiDotNetTrainingGround.Models;
using System.ComponentModel.DataAnnotations;
public class CreateDeveloperRequest
{
  [Required]
  [MinLength(10, ErrorMessage = "Too short, have a longer name and come back")]
  public string? Name { get; set; }
  [Required(ErrorMessage = "The 'Email' needs to be supplied right NOW!")]
  [EmailAddress(ErrorMessage = "Not valid email but well tried")]
  public string? Email { get; set; }
}
