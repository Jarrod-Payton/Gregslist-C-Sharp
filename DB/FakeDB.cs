using Tuesday.Models;

namespace Tuesday.DB
{
  public static class FakeDB
  {
    public static List<Car>? Cars { get; set; } = new List<Car>(){
      new Car(1900, "Ford", "Red")
    };
  }
}