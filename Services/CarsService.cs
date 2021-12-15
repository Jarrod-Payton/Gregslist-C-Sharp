using Tuesday.DB;
using Tuesday.Models;

namespace Tuesday.Services
{
  public class CarsService
  {
    internal List<Car> Get()
    {
      return FakeDB.Cars;
    }
    internal Car Get(string id)
    {
      Car found = FakeDB.Cars.Find(c => c.Id == id);
      if (found == null)
      {
        throw new Exception("Invalid Id");
      }
      return found;
    }
  }
}