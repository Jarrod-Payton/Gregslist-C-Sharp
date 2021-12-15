namespace Tuesday.Models
{
  public class Car
  {
    public string? Id { get; set; }
    public string? Make { get; set; }
    public int Year { get; set; }
    public string? Color { get; set; }
    public Car(int year, string make, string color)
    {
      Id = Guid.NewGuid().ToString();
      Make = make;
      Color = color;
      Year = year;
    }
  }
}