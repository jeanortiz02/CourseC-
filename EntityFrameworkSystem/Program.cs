

using BD;
using Microsoft.EntityFrameworkCore;
using System.Linq;

class Program
{
    static void Main()
    {

        DbContextOptionsBuilder<CsharpDbContext> optionsBuilder = 
            new DbContextOptionsBuilder<CsharpDbContext>();
        optionsBuilder.UseMySql("Server=127.0.0.1; Database=CsharpDB; Uid=user1; Pwd=abcd123456;",
            ServerVersion.AutoDetect("Server=127.0.0.1; Database=CsharpDB; Uid=user1; Pwd=abcd123456;"));

        using (CsharpDbContext context = new CsharpDbContext(optionsBuilder.Options))
        {

            var beers = context.Beers.ToList();

            foreach (var beer in beers)
            {
                Console.WriteLine(beer.Name);

            }
        }
         
    }
}
