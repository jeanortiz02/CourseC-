


class Aplication
{
    static void Main()
    {
        Sale sale = new Sale(89, DateTime.Now);
        //sale.Show();
        string var = sale.GetInfo();
        //Console.WriteLine(var);

        Console.WriteLine(sale.Total);
    }
}



class Sale
{
    // Propiedad por defecto privada
    int total;
    DateTime date;

    // Propiedad
    public int Total
    {
        get 
        { 
            return total; 
        }
        set
        {
            if(value < 0) 
                value = 0;
            total = value;
        }
    }

    // Constructor
    public Sale(int total, DateTime date)
    {
        this.total = total;
        this.date = date;
    }

    public string GetInfo()
    {
        return total + " " + date.ToLongDateString();
    }
}
