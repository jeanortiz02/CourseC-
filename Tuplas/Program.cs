

class Program
{
    static void Main()
    {
        // Tupla
        (int id, string name) products = (5, "Memoria RAM");

        Console.WriteLine($"{products.name} : {products.id}");

        products.name = "Estabilizador";


        // Otra forma 
        var person = (4, "Jean Carlos");
        Console.WriteLine(person.Item1);

        // Arreglo de tuplas 
        var people = new[]
        {
            (1, "Juan"),
            (2, "Pedro")
        };

        foreach(var p in people)
        {
            Console.WriteLine(p.Item2);
        }

        (int id, string name)[] persons = new[]
        {
            (1, "Juan"),
            (2, "Pedro")
        };
        foreach (var p in persons)
        {
            Console.WriteLine(p.name);
        }
    }
}
