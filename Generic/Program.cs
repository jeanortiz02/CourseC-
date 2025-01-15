
using System.Text.Json;


class Program
{
    static void Main()
    {
        // uso de genericos
        A<string> person2 = new A<string>();
        person2.getPerson();
    }
}

public class A <t>
{
    public t person;
    private bool isPerson;

    public t getPerson()
    {
         bool isPerson = true;

        if( isPerson )
        {
            Console.WriteLine("Hellou person");
            return person;
        }

        return default(t);
    }
}
