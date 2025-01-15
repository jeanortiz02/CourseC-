

class Aplication
{
    static void Main()
    {
        Sale sale = new Sale(89, DateTime.Now);
        //sale.Show();
        string var = sale.GetInfo();
        Console.WriteLine(var);
    }
}



class Sale
{
    int total;
    DateTime date;

    // Constructor
    public Sale (int total, DateTime date)
    {
        this.total = total;
        this.date = date;
    }

    public string GetInfo()
    {
        return total + " " + date.ToLongDateString();
    }



    // Methods
    public void Show()
    {
        Console.WriteLine("From a Methods under Class");
    }
}


