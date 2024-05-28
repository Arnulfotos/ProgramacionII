//string[] movieRepository = new string[10];
string[] movieRepository = { "El Padrino", "ET", "Toy Story", "Arrival", "El Conjuro", "Scary Movie", "Hereditary", "Monsters Inc"};
string busqueda = "";
ConsoleKeyInfo cki;
/*for(int i = 0; i < movieRepository.Length; i++)
{
    Console.WriteLine("Ingrese el nombre de una pelicula");
    movieRepository[i] = Console.ReadLine()!;
    Console.WriteLine();

}*/


do
{
    Console.WriteLine("Ingrese la pelicula que deseas buscar");
    busqueda = Console.ReadLine();

    for (int i = 0; i < movieRepository.Length; i++)
    {
        if (movieRepository[i].ToLower() == busqueda!.ToLower())
        {
            Console.WriteLine($"La pelicula {movieRepository[i]} esta disponible");
            break;
        }
     
            Console.WriteLine("No encontramos la pelicula que deseas");
            
       
    }
    Console.WriteLine("Si deas salir persiona ESC...");

    Console.WriteLine("Si deas continuar persiona ENTER...");
    cki = Console.ReadKey();



} while (cki.Key != ConsoleKey.Escape);