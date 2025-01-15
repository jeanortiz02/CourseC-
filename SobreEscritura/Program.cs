


class Program
{
    public static void Main()
    {
        B b = new B();
        Console.WriteLine(b.Hi());
    }
}

class A
{
    public virtual string Hi()
    {
        return "Hola soy A";
    }
}

class B : A
{
    public override string Hi()
    {
        return base.Hi() + " Hola Soy B";
    }
}
