namespace TrainingGround.Tests;

public class PersonTests
{

  public void Print(IPrintable printable) {
    var printString = printable.GetPrintString();
    Console.WriteLine(printString);
  }
  [Fact]
  // private Person _p;
  public void create_person_using_parameterless_constructor()
  {
    //act
    var p = new Person("bob");

    // assert
    Assert.NotNull(p);
    Assert.Equal("bob", p.Name);
  }
    [Theory]
  [InlineData(1972, 50)]
  [InlineData(1982, 40)]
  [InlineData(1992, 30)]
  public void Can_find_age_of_a_person(int value1, int expected)
  {
    // arrange
    var p = new Person(value1);

    // act
    var age = p.GetAge(2022);

    // assert
    Assert.Equal(expected, age);
  }

  [Fact]
  public void an_employee_is_a_person()
  {
    // act
    var emp = new Employee();
    emp.LengthInMeters = 1.95;

    // assert
    Assert.IsType(typeof(Employee), emp);
    Assert.Equal(1.95, emp.LengthInMeters);
  }
  [Fact]
  public void an_employee_has_an_employeeId()
  {
    // act
    var emp = new Employee("Marcus", "234-BDAS");

    // assert

    Assert.Equal("Marcus", emp.Name);
    Assert.Equal("234-BDAS", emp.EmployeeId);
  }

  [Fact]
  public void a_person_has_an_adress()
  {
    // arrange
    var p = new Person("Marcus");

    // act
    p.Address = new Address();
    p.Address.Street = "A Street";
    p.Address.StreetNo = 23;
    p.Address.City = "Stockholm";

    // assert
    Assert.NotNull(p.Address);
    Assert.IsType(typeof(Address), p.Address);

    Assert.Equal("A Street", p.Address.Street);
    Assert.Equal(23, p.Address.StreetNo);
    Assert.Equal("Stockholm", p.Address.City);

  }
  [Fact]
  public void an_employee_gets_a_nice_printed_adress()
  {
    // arrange
    var emp = new Employee("Marcus", "234-BDAS");
    emp.Address =new Address();
    emp.Address.Street = "A Street";
    emp.Address.StreetNo = 23;
    emp.Address.City = "Stockholm";

    // act

    var printString = emp.GetPrintString();
    // assert

    Assert.Equal(@"Marcus (234-BDAS)
    A Street 23
    Stockholm"
    , printString);
  }
  [Fact]
  public void a_person_gets_a_nice_printed_description()
  {
    // arrange
    var p = new Person("Marcus", 1992);
    p.LengthInMeters = 192;
    // act
    var printString = p.GetPrintString();
    // assert
    Assert.Equal(@"Marcus
  Born in 1992, 192cm tall", printString);
  }

  [Fact]
  public void can_print_printables()
  {
  // arrange
  var emp = new Employee("Ossian", "234-BDAS");
  emp.Address = new Address();
  emp.Address.Street = "B Street";
  emp.Address.StreetNo = 22;
  emp.Address.City = "Malmö";

  var p = new Person("Marcus", 1993);
  p.Address = new Address();
  p.Address.Street = "A Street";
  p.Address.StreetNo = 23;
  p.Address.City = "Stockholm";

  // act
    // this.Print(p);
    // this.Print(emp);
  }
}
