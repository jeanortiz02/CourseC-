
using System.Collections.Generic;

class Program
{
    static void Main()
    {

        // Lista = Collections
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);

        Console.WriteLine(list.Count);


        // Otra opcion
        var list2 = new List<int>()
        {
            1, 2, 3, 4, 5, 6,
        };

        Console.WriteLine(list2.Count);

        // Elimina elementos
        list2.Clear();
        

       
    }
}
