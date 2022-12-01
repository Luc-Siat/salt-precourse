using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models;

public class UpdateAddressRequest
{
  [Required]
  public string? Name { get; set; }
  [Required]
  public int Id { get; set; }
  [Required]
  public int StreetNo { get; set;}
  [Required]
  public string? StreetName { get; set;}
  [Required]
  public string? City { get; set; }
}
