/* Напишите программу , которая перевернет  массив */
// Двойной массив

int[,] array = new int[5, 4];

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

for (int n = 0; n < array.GetLength(0) * array.GetLength(1) / 2; n++)
{
    int i = n / array.GetLength(1);
    int j = n - i * array.GetLength(1);

    (array[i, j], array[array.GetLength(0) - i - 1, array.GetLength(1) - j - 1]) =
     (array[array.GetLength(0) - i - 1, array.GetLength(1) - j - 1], array[i, j]);
}
Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]} ");
    Console.WriteLine();
}


