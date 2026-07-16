namespace PlanetClasses;

public class Planet
{
    public string Name = "";
    public int Diameter;
    public void PrintPlanetInfo()
    {
        System.Console.WriteLine($"name: {Name}, Diameter: {Diameter}km");
    }
}
