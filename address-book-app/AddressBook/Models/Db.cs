namespace AddressBook.Models;

public class Db
{
  public Db()
  {
    Addresses = new List<Address>() {
      new Address() {Name = "Home", Id= 0, StreetNo = 1, StreetName= "Strandvägen", City= "Stockholm"},
      new Address() {Name = "Stuga", Id= 1, StreetNo = 2, StreetName= "Strandgatan", City= "Stockholm"}
    };
  }
  public List<Address> Addresses { get; set; }
}
