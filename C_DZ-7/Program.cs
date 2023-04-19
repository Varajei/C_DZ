// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

double[,] GetArrey(int hight, int length, int min, int max)
{
    double[,] DubArrey = new double[hight, length];

    for (int i = 0; i < hight; i++)
    {
        for (int j = 0; j < length; j++)
        {
            DubArrey[i, j] = new Random().Next(min, max);
            DubArrey[i, j] *= new Random().NextSingle();

        }
    }

    return DubArrey;
}

void PrintArrey(double[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write($"{myArray[i, j]:f2} ");
        }
        Console.WriteLine();
    }
    }
double[,] mydoubleArray = GetArrey(3, 4, -10, 10);
PrintArrey(mydoubleArray);
Console.WriteLine();


// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет




// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.