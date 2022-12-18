/* Задача 39. Напишите программу , котроая перевернет одномерный массив */
// Двойной массив

int[] array = new int[5];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(10);
    Console.Write($"{array[i]} ");
}

for (int i = 0; i < array.Length / 2; i++)
{
    (array[i], array[array.Length - i - 1]) = (array[array.Length - i - 1], array[i]);
}
Console.WriteLine();

for (int i = 0; i < array.Length; i++)
    Console.Write($"{array[i]} ");
