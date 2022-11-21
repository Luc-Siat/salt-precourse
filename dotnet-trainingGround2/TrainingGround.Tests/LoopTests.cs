namespace TrainingGround.Tests;

public class LoopTests
{
  [Fact]
  public void while_loop()
  {
  // arrange
  var ints = new int[] { 1, 2, 3, 4, 5};

  // act
  var i = 0;
  while (i < ints.Length)
  {
    var currentValueInTheLoop = ints[i];

    Console.WriteLine($"i is now '{i}'");
    Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");

    // assert
    Assert.Equal(i + 1, currentValueInTheLoop);
    i = i + 1;
  }
  }
  [Fact]
  public void for_loop()
  {
    // arrange
    var ints = new int[] { 1, 2, 3, 4, 5 };

    // act
    for (var i = 0; i < ints.Length; i++)
    {
      var currentValueInTheLoop = ints[i];

      Console.WriteLine($"i is now '{i}'");
      Console.WriteLine($"currentValueInTheLoop is now '{currentValueInTheLoop}'");

    // assert
      Assert.Equal(i + 1, currentValueInTheLoop);
    }
  }
  [Fact]
  public void for_each_loop()
  {
    // arrange
    var ints = new int[] { 1, 2, 3, 4 , 5 };

    // act
    foreach (var currentValueInTheLoop in ints)
    {
      Console.WriteLine($"i is now {ints[currentValueInTheLoop - 1]}");
      Console.WriteLine($"current value is now {currentValueInTheLoop}");
      // assert
      Assert.IsType<int>(currentValueInTheLoop);
    }
  }
  [Fact]
  public void for_each_loop_over_adresses()
  {
    // arrange
    var emp = new Employee("Marcus", "BD4 ERD");
    emp.Addresses.Add(new Address() {Street = "A street", StreetNo = 23, City = "Stockholm"});
    emp.Addresses.Add(new Address(){Street = "A patch", StreetNo = 2, City = "Stockholm"});
    // act
    var foundIt = false;
    foreach (var currentAddress in emp.Addresses)
    {
      if (currentAddress.StreetNo != 2)
      {
        continue;
      }
      Console.WriteLine($"i is now {emp.Addresses.IndexOf(currentAddress)}");
      Console.WriteLine($"current address is now {currentAddress.Street} {currentAddress.StreetNo} {currentAddress.City}");
      foundIt = true;

    }
      Assert.True(foundIt);

  }

  [Fact]
  public void all_numbers_above_15()
  {
    // arrange
    var ints = new int[] {1, 3, 19, 14, 4, 16, 2 ,18 };

    var intsAbove15 = new List<int>();
    // act
    foreach (var currentInt in ints)
    {
      if (currentInt > 15)
      {
        intsAbove15.Add(currentInt);
        Console.WriteLine(currentInt);
      }
    }
    Assert.Equal(3, intsAbove15.Count);
  }
  [Fact]
  public void linq_to_filer_numbers()
  {
    // arrange
    var numbers= new List<int> { 1, 53, 2, 62, 2 , 12, 17, 15, 16 };

    // act
    var numbersLargerThan15 = numbers.FindAll(number => number > 15);

    // Assert
    Assert.Equal(4, numbersLargerThan15.Count);
  }

  [Fact]
  public void linq_all_numbers_are_above_1()
  {
  // arrange
  var numbers = new List<int> { 1, 2, 3, 4, 5};
  // act
  var all_over_1 = numbers.All( number => number >= 1);
  // assert
  Assert.Equal(true, all_over_1);
  }
  [Fact]
  public void people_with_names_above_4_char()
  {
    // arrange
    var people = new List<Person>();
    people.Add( new Person("Aaron"));
    people.Add( new Person("Bea"));
    people.Add( new Person("Ceasar"));
    people.Add( new Person("Dave"));
    // act
    var namesAbove4 = people
      .Where( person => person.Name.Length > 4)
      .ToList();

    Console.WriteLine(namesAbove4.Count);
    // assert
    Assert.Equal(2, namesAbove4.Count);
  }
  [Fact]
  public void filter_people_by_age_only_name()
  {
    // arrange
    var people = new List<Person> {
      new Person("Aaaron"),
      new Person("Bea"),
      new Person("Ceasar"),
      new Person("Dave"),
    };

    // act
    var allWithLongNames = people
      .Where( p => p.Name.Length > 4)
      .Select( p => p.Name)
      .ToList();

    // assert
    Assert.Equal(2, allWithLongNames.Count);
    Assert.Equal("Aaaron", allWithLongNames[0]);
    Assert.Equal("Ceasar", allWithLongNames[1]);

  }
  [Fact]
  public void filter_people_by_age_names_age()
  {
    // arrange
    var a = new Person("Aaaron");
    a.LengthInMeters = 1.96;
    var people = new List<Person> {
      a,
      new Person("Bea"),
      new Person("Ceasar"),
      new Person("Dave"),
    };

    // act
    var namesAndAges = people
    .Where(p => p.Name.Length > 4)
    .Select(p => new { Name = p.Name, Height = p.LengthInMeters})
    .ToList();

    // assert
    Assert.Equal(2, namesAndAges.Count);
    Assert.Equal("Aaaron", namesAndAges[0].Name);
    Assert.Equal(1.96, namesAndAges[0].Height);
  }
  [Fact]
  public void filter_by_ascending()
  {
    // arrange
    var ints = new List<int> {11, 2, 3, 4, 1, 6};

    // act
    var ints_ascending = ints
    .OrderBy(i => i)
    .ToList();
    var result = new int[] {1, 2, 3, 4, 6, 11};
    //
    Console.WriteLine(ints_ascending[0]);
    Assert.Equal(result, ints_ascending);
  }


  [Fact]
  public void filter_people_by_age_names()
  {
    // arrange
    var a = new Person("Aaaron");
    a.LengthInMeters = 1.96;
    var people = new List<Person> {
      a,
      new Person("Bea"),
      new Person("Ceasar"),
      new Person("Dave"),
    };

    // act

    var query =
      from p in people
      where p.Name.Length > 4
      select new { Name = p.Name, Height = p.LengthInMeters};
    var namesAndAges = query.ToList();


    // assert
    Assert.Equal(2, namesAndAges.Count);
    Assert.Equal("Aaaron", namesAndAges[0].Name);
    Assert.Equal(1.96, namesAndAges[0].Height);
  }

}
