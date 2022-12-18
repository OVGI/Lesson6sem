/* Задача 39. Напишите программу , котроая перевернет одномерный массив */
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

for (int i = 0; i < array.GetLength(0); i++)
    for (int j = 0; j < array.GetLength(1) / 2; j++)
        (array[i, j], array[i, array.GetLength(1) - j - 1]) = (array[i, array.GetLength(1) - j - 1], array[i, j]);

Console.WriteLine();

for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write($"{array[i, j]} ");
    Console.WriteLine();
}


