

class Program
{
    static void Main()
    {
        Show();
        Sum(5, 63);
    }
    static void Show()
    {
        Console.WriteLine("Desde funciones");
    }

    static int Mult(int num1,  int num2)
    {
        return num1 * num2;
    }


    static void Sum(int num1, int num2)
    {
        int num3 = num1 + num2;
        Console.WriteLine(num3);
    }

 }


