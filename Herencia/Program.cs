

class Program
{
    static void Main ()
    {
        Doctor doctor = new Doctor("Jean Carlos", 24, "Software Ingenier");
        Console.WriteLine(doctor.GetData());
    }
}


class People
{
    private string _name;
    private int _age;

    public People(string name, int age)
    {
        _name = name; 
        _age = age;
    }

    public string GetInfo()
    {
        return _name + " " + _age;
    }
}

class Doctor : People
{
    private string _speciality;

    public Doctor(string name, int age, string speciality) : base (name, age)
    {
        _speciality = speciality;
    }

    public string GetData()
    {
        return GetInfo() + " " + _speciality;
    }
}