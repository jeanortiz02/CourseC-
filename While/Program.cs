


// Arreglos
string[] friends = new string[5]
{
    "Jean",
    "Pablo",
    "Pedro",
    "Jesus",
     null
};

int index = 0;

while (index < friends.Length)
{
    Console.WriteLine( friends[index] );
    index++;
}

bool run = false;
do
{
    Console.WriteLine("Entro una sola vez");
} while (run);
 