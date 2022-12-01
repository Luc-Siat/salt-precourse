using System.ComponentModel.DataAnnotations;

namespace AddressBook.Models;

public class CreateAddressRequest
{
  public string? Name { get; set; }
  public int StreetNo { get; set; }
  public string? StreetName { get; set; }
  public string? City { get; set; }
}
