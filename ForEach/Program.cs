using System.Collections.Generic;

class Program
{
    static void Main()
    {

        //var numbers = new List<int>
        //{
        //    1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        //};

        //foreach (var number in numbers)
        //{
        //    Console.WriteLine(number);
        //}

        var students = new List<People>
        {
            new People { Name = "Juan", Country = "Dominicana" },
            new People { Name = "Pedro", Country = "Colombia" },
            new People { Name = "Maria", Country = "Salvador" },
            new People { Name = "Jose", Country = "Estados Unidos" }
        };
        Show(students);

        Console.WriteLine("------ Remove first student ------");
        students.RemoveAt(0);

        Show(students);
    }

    public static void Show(List<People> students)
    {
        Console.WriteLine("------ List of students ------");
        foreach (var student in students)
        {
            Console.WriteLine($"{student.Name} From {student.Country}");
        }
    }

}

    class People
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }