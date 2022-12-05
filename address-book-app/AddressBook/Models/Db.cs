namespace AddressBook.Models;

public class Db
{
  public Db()
  {
    Addresses = new List<Address>() {
      new Address() {Name = "Home", Id= 0, StreetNo = 1, StreetName= "Strandvägen", City= "Stockholm"},
      new Address() {Name = "Stuga", Id= 1, StreetNo = 2, StreetName= "Strandgatan", City= "Stockholm"},
      new Address() {Name = "Frankrike", Id= 2, StreetNo = 4 , StreetName= "rue du bosquet", City= "Strasbourg"},
      new Address() {Name = "Gotland Stuga", Id= 3, StreetNo = 5, StreetName= "Sturevagen", City= "Visby"}
    };
  }
  public List<Address> Addresses { get; set; }
}
