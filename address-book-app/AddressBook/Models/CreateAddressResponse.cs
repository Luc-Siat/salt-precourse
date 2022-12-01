namespace AddressBook.Models;

public class CreateAddressResponse
{
  public int Id { get; set; }

  public string? Name { get; set; }
  public int StreetNo { get; set; }
  public string? StreetName { get; set; }
  public string? City { get; set; }
}
