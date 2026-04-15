namespace Classes;

public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }
    public int Year { get; set; }

    public void Drive()
    {
        Console.WriteLine($"My dream car would be a {Make} {Model} {Year}");
    }
}