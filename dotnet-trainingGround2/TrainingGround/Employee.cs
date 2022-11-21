namespace TrainingGround
{
  public class Employee : Person, IPrintable
  {
    public string? EmployeeId {get; set;}
    public List<Address> Addresses {get; set;}
    public Employee()
    {
      this.Addresses = new List<Address>();
    }
    public Employee(string name, string employeeId) : base(name)
    {
      this.Addresses = new List<Address>();
      this.EmployeeId = employeeId;
    }


    public string GetPrintString()
    {
      return @$"{this.Name} ({this.EmployeeId})
    {this.Address.Street} {this.Address.StreetNo}
    {this.Address.City}";
    }
  }
}
