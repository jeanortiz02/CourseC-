

class Program
{
    static void Main()
    {
        // Objeto anonimo
        var objetoAnonimo = new
        {
            nombre = "Jean"
        };


        var people = new[]
        {
            new { name = "Jean", Last = "Pereyra" },
            new { name = "Dolly", Last = "Pereyra"}
        };
    }
}