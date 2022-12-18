// Рекурсия

// int a;
// Console.Write($"Введите число: ");
// int.TryParse(Console.ReadLine()!, out a);

Recurs(0);

for (int i = 0; i < 10; i++)
    Console.WriteLine($"{i} Запуск функции");


void Recurs(int i)
{
    Console.WriteLine($"{i} Запуск функции");
    i++;
    if (i < 10)
    {
        Recurs(i);
        Recurs(i + 1);
    }
}

