using BaseDeDatos;
using Mysqlx.Crud;

class Program
{
    static void Main ()
    {
        try
        {
            BeerDB beerDB = new BeerDB("127.0.0.1", "CsharpDB", "user1", "abcd123456");

            // Insert
            bool again = true;
            int op = 0;


            do
            {
                ShowMenu();
                Console.WriteLine("Elige una opcion: ");
                op = int.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Show(beerDB);
                        break;

                    case 2:
                        Add(beerDB);
                        break;
                    case 3:
                        Edit(beerDB);
                        break;

                    case 4:
                        Delete(beerDB);
                        break;
                    case 5:
                        again = false;
                        break;
                }
            }
            while (again);





        } catch(Exception ex)
        {
                Console.WriteLine($"Error al conectar: {ex.Message}");
        }
    }

    public static void Show(BeerDB beerDb)

    {
        Console.Clear();
        Console.WriteLine("Desde la base de datos");
        List<Beer> beers = beerDb.GetAll();

        foreach (var beer in beers)
        {
            Console.WriteLine($"Id: {beer.Id} Name: {beer.Name}");
        }

    }

    public static void ShowMenu()
    {
        Console.WriteLine("1. Todos los datos de la base de datos");
        Console.WriteLine("2. Para agregar una cerveza");
        Console.WriteLine("3. Para editar una cerveza");
        Console.WriteLine("4. Para elminiar una cerveza");
    }

    public static void Add(BeerDB beerDb)
    {
        Console.Clear();
        Console.WriteLine("Agregar nueva cerveza");
        Console.WriteLine("Escribe el nombre:");
        string name = Console.ReadLine();
        Console.WriteLine("Escribe el Id de la marca");
        int branId = int.Parse(Console.ReadLine());


        Beer beer = new Beer(name, branId);

        beerDb.Add(beer);
    }

    public static void Edit(BeerDB beerDb )
    {
        Console.Clear();

        Show(beerDb);
        Console.WriteLine("Editar cerveza");
        Console.WriteLine("Escribe el Id de tu cerveza");
        int id = int.Parse(Console.ReadLine());

        Beer beer = beerDb.GetById(id);

        if(beer != null)
        {
            Console.WriteLine("Escribe el nombre");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el id de la marca");
            int brandId = int.Parse(Console.ReadLine());



            beer.Name = name;
            beer.BrandId = brandId;
            beerDb.Edit(beer);
        } else
        {
            Console.WriteLine("Error en editar");
        }

    }

    public static void Delete(BeerDB beerDb)
    {
        Console.Clear();
        Show(beerDb);

        Console.WriteLine("Digite el ID de la cerveza a eliminar");
        int id = int.Parse(Console.ReadLine());

        Beer beer = beerDb.GetById(id);

        if (beer != null) 
        {
            beerDb.Delete(beer);
        } else
        {
            Console.WriteLine("Cerveza no existe");
        }

    }


}