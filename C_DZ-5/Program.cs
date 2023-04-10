// Урок 5. Функции и одномерные массивы
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

// Console.Write("Размер массива: ");
// int size = int.Parse(Console.ReadLine());
// Console.Write("Минимальное значение массива: ");
// int min = int.Parse(Console.ReadLine());
// Console.Write("Максимальное значение массива: ");
// int max = int.Parse(Console.ReadLine());
// int[] Array = GetArray(size, min, max);
// Console.WriteLine($"[{string.Join(", ", Array)}]");
// NewArray(Array);

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = rand.Next(minValue, maxValue + 1);
//     }

//     return result;
// }

// void NewArray(int[] Array)
// {
//     int chet = 0;
//     for (int i = 0; i < Array.size; i++)
//     {
//         if (Array[i] % 2 == 0)
//         {
//             chet = chet + 1;
//         }
//     }
//     Console.WriteLine($"Количество четных чисел = {chet}");
// }



// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

// Console.Clear();
// Console.Write("Размер массива: ");
// int size = int.Parse(Console.ReadLine());
// Console.Write("Минимальное значение массива: ");
// int min = int.Parse(Console.ReadLine());
// Console.Write("Максимальное значение массива: ");
// int max = int.Parse(Console.ReadLine());
// int[] Array = GetArray(size, min, max);
// Console.WriteLine($"[{string.Join(", ", Array)}]");
// NewArray(Array);

// int[] GetArray(int size, int minValue, int maxValue)
// {
//     int[] result = new int[size];
//     Random rand = new Random();
//     for (int i = 0; i < size; i++)
//     {
//         result[i] = rand.Next(minValue, maxValue + 1);
//     }

//     return result;
// }

// void NewArray(int[] Array)
// {
//     int sum = 0;
//     for (int i = 1; i < Array.size; i = i + 2)
//     {
//         sum = sum + Array[i];
//     }
//     Console.WriteLine($"Сумма чисел на нечётных позициях = {sum}");
// }



// int[] array = GetArray(5, 0, 10); // 5 это количество элементов массива
// Console.Clear();
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine(string.Join(", ", NewArray(array)));

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

Console.Clear();
Console.Write("Размер массива: ");
int size = int.Parse(Console.ReadLine());
Console.Write("Минимальное значение массива: ");
double min = double.Parse(Console.ReadLine());
Console.Write("Максимальное значение массива: ");
double max = double.Parse(Console.ReadLine());
double[] Array = GetArray(size, min, max);
Console.WriteLine($"[{string.Join(", ", Array)}]");
NewArray(Array, min, max);

double[] GetArray(int size, double minValue, double maxValue)
{
    double[] result = new double[size];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        result[i] = rand.NextDouble(minValue, maxValue + 1);
    }

    return result;
}

void NewArray(double[] Array, double minValue, double maxValue)
{
    for (int i = 0; i < Array.Length; i++)
    {
        if (Array[i] < minValue)
        {
            minValue = Array[i];
        }
        if (Array[i] > maxValue)
        {
            maxValue = Array[i];
        }
    }
    Console.WriteLine($"Разница = {maxValue-minValue}");
}