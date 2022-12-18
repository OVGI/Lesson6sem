/* Задача 40. Напишите программу , которая принимает на вход три числа  
и проверяет , может ли существовать треугольник со сторонами такой длины */

Console.Write($"Введите 3 стороны треугольника: ");
string[] lines = Console.ReadLine()!.Split(' ');
int[] nums = new int[lines.Length];

for (int i = 0; i < lines.Length; i++)
    int.TryParse(lines[i], out nums[i]);
if (IsTriang(nums[0], nums[1], nums[2]))
    Console.Write($"Существует");
else
    Console.Write($"Не существует");


bool IsTriang(int a, int b, int c)
{
    return (a < b + c) && (b < a + c) && (c < a + b);
}


