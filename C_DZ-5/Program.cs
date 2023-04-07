// Урок 5. Функции и одномерные массивы
// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2


int[] GetArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rand = new Random();
    for (int i = 0; i < length; i++)
        result[i] = rand.Next(minValue, maxValue + 1);
    return result;
}

int[] NewArray(int[] array)
{
    
}

int[] array = GetArray(5, 100, 999); // 5 это количество элементов массива
Console.Clear();
Console.WriteLine(string.Join(", ", array));
Console.WriteLine(string.Join(", ", NewArray(array)));


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0


// int[] GetArray(int length, int minValue, int maxValue)
// {
//     int[] result = new int[length];
//     Random rand = new Random();
//     for (int i = 0; i < length; i++)
//         result[i] = rand.Next(minValue, maxValue + 1);
//     return result;
// }



// int[] array = GetArray(5, 0, 10); // 5 это количество элементов массива
// Console.Clear();
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine(string.Join(", ", NewArray(array)));

// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

// int[] GetArray(int length, int minValue, int maxValue)
// {
//     int[] result = new int[length];
//     Random rand = new Random();
//     for (int i = 0; i < length; i++)
//         result[i] = rand.Next(minValue, maxValue + 1);
//     return result;
// }



// int[] array = GetArray(5, 0, 10); // 5 это количество элементов массива
// Console.Clear();
// Console.WriteLine(string.Join(", ", array));
// Console.WriteLine(string.Join(", ", NewArray(array)));