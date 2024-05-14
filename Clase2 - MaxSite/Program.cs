ConsoleKeyInfo cki;

string[] listaPeliculas = { "El padrino", "Batman", "Tiempos violentos", "Forrest Gump", "El origen", "Batman 2", "Superman", "El padrino II" };
string[] directores = { "Francis Ford Coppola", "Tim Burton", "Quentin Tarantino", "Robert Zemeckis", "Christopher Nolan", "Tim Burton", "Richard Donner", "Francis Ford Coppola" };
string[] calificaciones = { "9.2", "7.5", "8.9", "8.8", "8.7", "7.0", "7.3", "9.0" }; //calificaciones de IMDb.
string[] displayMergeText = new string[8];
string valoresEncontrados = "";

for (int i = 0; i < listaPeliculas.Length; i++)
{
    displayMergeText[i] = $"{listaPeliculas[i]} dirigida por {directores[i]} ({calificaciones[i]} estrellas en IMDb)";
    //Console.WriteLine(displayMergeText[i]);
}


do
{
    Console.WriteLine("Ingrese el dato que desee buscar");
    string peliculaBuscada = Console.ReadLine();

    for (int i = 0; i < displayMergeText.Length; i++)
    {

        if (displayMergeText[i].ToLower().Contains(peliculaBuscada.ToLower()))
        {
            valoresEncontrados += $"\n{displayMergeText[i]}\n ";
        }

    }

    if (string.IsNullOrEmpty(valoresEncontrados))
    {
        valoresEncontrados += "Busquda sin resultados\n";
    }

    /*Console.WriteLine("Seleccione la accion que desea\n 1. Buscar por titulo\n 2. Buscar por director\n 3.Buscar por rating\n");
    cki = Console.ReadKey();

    switch (cki.KeyChar)
    {
        case '1':
            Console.WriteLine("\nUsted desea buscar por titulo");
            break;

        case '2':
            Console.WriteLine("\nUsted desea buscar por director");
            break;

        case '3':
            Console.WriteLine("\nUsted desea buscar por rating");
            break;

    } */
    Console.WriteLine(valoresEncontrados);




    Console.WriteLine("\n---------------------");
    Console.WriteLine("Presiona la tecla Escape (Esc) para salir.");
    Console.WriteLine("Presiona Enter para buscar otra película.");

    valoresEncontrados = "";

    cki = Console.ReadKey();

    Console.Clear();


}  while (cki.Key != ConsoleKey.Escape) ;