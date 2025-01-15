

class Program
{
    public static void Main()
    {

    }
}

public class Shark : IAnimal, IFish
{
    public string Name { get; set; }

    public int Speed { get; set; }

    public string Swin()
    {
        return $"Hola {Name} nada {Speed } km/h";
    }
}

// Interfaces 
public interface IAnimal
{
    public string Name { get; set; }
}

public interface IFish
{
    // get y set 
    // get = obtenerlo
    // set = modificarlo
    public int Speed { get; set; }
    public string Swin();
}