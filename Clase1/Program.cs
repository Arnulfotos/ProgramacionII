/*int[] vector = new int[5];

vector = [10, 30, 50, 70, 90];

for (int i = 0; i < vector.Length; i++)
{
    Console.WriteLine(vector[i]);   
} */

int[] vector = new int[5];

double promedio = 0;


for (int i = 0; i < vector.Length; i++)
{
    do
    {
        Console.WriteLine($"Ingrese el valor del vector {i} entre 0 al 100");
        vector[i] = int.Parse(Console.ReadLine()!);

    } while (vector[i] > 100 || vector[i] < 0);
}

Console.WriteLine();


for (int j = 0; j < vector.Length; j++)
{
    Console.WriteLine(vector[j]);
}

Console.WriteLine();

for(int k = 0; k < vector.Length; k++)
{
    promedio += vector[k];
}

promedio = promedio / vector.Length;

Console.WriteLine($"El promedio final es {promedio}"); 

/*int[] vector = new int[6];
for (int i = 0; i <= 5; i++)
{
    do
    {
        Console.WriteLine($"Ingrese un numero del 0 al 100 | Vector {i}");
        vector[i] = int.Parse(Console.ReadLine());
        
    } while (vector[i] < 0 && vector[i] > 100);
}
Console.WriteLine("\nContenido del Vector");
for (int i = 0; i <= 5; i++)
{
    Console.WriteLine(vector[i]);
}*/

