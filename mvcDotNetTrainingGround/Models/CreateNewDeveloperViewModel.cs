using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mvcDotNetTrainingGround.Models;

public class CreateNewDeveloperViewModel
{
   [DisplayName("Developer name")]
  [Required]
  public string? Name { get; set; }

  [DisplayName("Email adress")]
  [Required]
  [EmailAddress]
  public string? Email { get; set; }
}
