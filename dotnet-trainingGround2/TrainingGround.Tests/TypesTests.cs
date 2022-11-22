
public class TypesTests
{

    [Fact]
    public void reference_types_can_be_changed_via_reference()
    {
      //  arrange
      Person a = new Person("Person A");
      a.LengthInMeters = 1.95;
      Person b = a;

      // act

      b.LengthInMeters = 1.96;

      // assert
      Assert.Equal(1.96, b.LengthInMeters);
      Assert.Equal(1.96, a.LengthInMeters);
    }
  [Fact]
  public void value_types_cannot_be_changed_via_reference()
  {
    // arrange
    double aLengthInMeters = 1.95;
    double bLengthInMeters = aLengthInMeters;
    // act
    bLengthInMeters = 1.96;
    // assert
    Assert.Equal(1.96, bLengthInMeters);
    Assert.Equal(1.95, aLengthInMeters);
  }

}
