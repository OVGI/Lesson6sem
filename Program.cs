
// Двойной массив

int[,] array = new int[3, 4];

for (int i = 0; i < 3; i++)  // внешний  строки
{
    for (int j = 0; j < 4; j++) // внутренний столбцы / элементы
    {
        array[i, j] = new Random().Next(10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine();
}

