int[] numbers = { 65, 55, 45, 35, 25, 15, 10 };

int valorLimiteDeEvaluacion = numbers.Length - 1;

bool sorteado = false;

while (!sorteado)
{

    sorteado = true;

    for(int i = 0; i < valorLimiteDeEvaluacion; i++)
    {
        if (numbers[i] < numbers[i + 1])
        {
            int temp1 = numbers[i];
            int temp2 = numbers[i + 1];

            numbers[i + 1] = temp1;
            numbers[i] = temp2;
            
            sorteado = false;
        }
    }

    valorLimiteDeEvaluacion -= 1;
}

foreach (var value in numbers)
{
    Console.WriteLine(value);
}