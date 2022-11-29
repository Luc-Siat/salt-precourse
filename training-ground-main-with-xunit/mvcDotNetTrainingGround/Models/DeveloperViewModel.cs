using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace mvcDotNetTrainingGround.Models;

public class DeveloperViewModel
{
  [Required]
  public int Id { get; set; }
  [DisplayName("Developer Name")]
  [Required]
  public string? Name { get; set; }
  [DisplayName("Adress Email")]
  [Required]
  public string? Email { get; set; }
}
