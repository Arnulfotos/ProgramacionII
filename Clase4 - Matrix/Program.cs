string[,] biblioteca = new string[3,2];


//Console.WriteLine(biblioteca.GetLength(0));
//Console.WriteLine(biblioteca.GetLength(1));


for (int i = 0; i < biblioteca.GetLength(0); i++)
{
    for (int j = 0; j < biblioteca.GetLength(1); j++)
    {
        Console.WriteLine("Ingrese un valor:");
        biblioteca[i, j] = Console.ReadLine();
    }


    Console.WriteLine("");
}



for (int i = 0; i < biblioteca.GetLength(0); i++)
{
    for(int j = 0; j < biblioteca.GetLength(1); j++)
    {
        Console.Write($"    {biblioteca[i,j]}  |");
    }
    Console.WriteLine("");
}
