/*string[] listaPeliculas = { "El padrino", "Batman", "Tiempos violentos", "Forrest Gump", "El origen", "Batman 2", "Superman", "El padrino II", "La conversacion" };
string[] Directores = { "Francis Ford Coppola", "Tim Burton", "Quentin Tarantino", "Robert Zemeckis", "Tim Burton", "Zack Snyder", "Francis Ford Coppola", "Francis Ford Coppola" };
string valoresEncontrados = "";

ConsoleKeyInfo cki;

bool encontrada = false;
do
{
    Console.WriteLine("Que pelicula quieres ver?");
    string peliculaBuscada = Console.ReadLine();

    for (int i = 0; i < listaPeliculas.Length; i++)
    {



        if (listaPeliculas[i].ToLower().Contains(peliculaBuscada.ToLower()))
        {
            valoresEncontrados += $"\n{listaPeliculas[i]}\n ";
        }

       


        if (listaPeliculas[i].ToLower() == peliculaBuscada.ToLower())
         {
             Console.WriteLine("Si, es la pelicula #" + (i + 1));
             encontrada = true;
             break;
         } 
    }
    if (string.IsNullOrEmpty(valoresEncontrados))
    {
        valoresEncontrados += "Busquda sin resultados\n";
    }
    Console.WriteLine($"Resultados: \n{valoresEncontrados}");
    Console.WriteLine("\n---------------------");
    Console.WriteLine("Press the Escape (Esc) key to quit. \n");
    Console.WriteLine("Press the Enter to continue... \n");

    valoresEncontrados = "";

    cki = Console.ReadKey();

} while (cki.Key != ConsoleKey.Escape); */

string[] listaPeliculas = { "El padrino", "Batman", "Tiempos violentos", "Forrest Gump", "El origen", "Batman 2", "Superman", "El padrino II" };
string[] directores = { "Francis Ford Coppola", "Tim Burton", "Quentin Tarantino", "Robert Zemeckis", "Christopher Nolan", "Tim Burton", "Richard Donner", "Francis Ford Coppola" };

ConsoleKeyInfo cki;

do
{
    Console.WriteLine("¿Qué película quieres ver?");
    string peliculaBuscada = Console.ReadLine();
    bool encontrada = false;

    for (int i = 0; i < listaPeliculas.Length; i++)
    {
        if (listaPeliculas[i].ToLower() == peliculaBuscada.ToLower())
        {
            Console.WriteLine($"{listaPeliculas[i]} dirigida por {directores[i]}");
            encontrada = true;
            break;
        }
    }

    if (!encontrada)
    {
        Console.WriteLine("Película no encontrada.");
    }

    Console.WriteLine("\n---------------------");
    Console.WriteLine("Presiona la tecla Escape (Esc) para salir.");
    Console.WriteLine("Presiona Enter para buscar otra película.");

    cki = Console.ReadKey();

} while (cki.Key != ConsoleKey.Escape);