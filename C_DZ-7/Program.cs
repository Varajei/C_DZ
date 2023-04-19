// Урок 7. Двумерные массивы
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

float[,] GetArrey(int hight, int length, int min, int max)
{
    float[,] DubArrey = new float[hight, length];

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

void PrintArrey(float[,] myArray)
{
    for (int i = 0; i < myArray.GetLength(0); i++)
    {
        for (int j = 0; j < myArray.GetLength(1); j++)
        {
            Console.Write($"{myArray[i, j]:f1} ");
        }
        Console.WriteLine();
    }
    }
float[,] myfloatArray = GetArrey(3, 4, -10, 10);
PrintArrey(myfloatArray);
Console.WriteLine();


// Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, и возвращает его индексы первого найденого числа или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


Random random = new Random();
int[,] array = new int[random.Next(3, 10), random.Next(3, 10)];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = random.Next(1, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}

int IndexOf(int[,] array, int valeu) // Я не понимаю почему у меня данный код не хочет работать смотрел несколько способов IndexOf, FindIndex,
// делаю вроде все правильно, но понимаю что где то просто грубейшую ошибку допускаю из-за незнания и непонимания
// к сожалению из-за нехватки времени затянул и уже не смог вов время разобраться с данной задачей
{
    for (int d = 0; d < array.Length; d++)
    {
        if(array[d] == valeu)
        {
            return d;
        }
    }
    return -1;
}

Console.Write("Введите число N: ");
string strNumN = Console.ReadLine();
int valeu = Convert.ToInt32(strNumN);

int[,] myArray = array;
int result = IndexOf(myArray, valeu);
Console.WriteLine(result);



// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Random random = new Random();
int[,] arr = new int[random.Next(3, 10), random.Next(3, 10)];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = random.Next(1, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Среднее арифметическое каждого столбца: ");
for (int j = 0; j < arr.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];

    }
    Console.Write($"{(sum/arr.GetLength(0)):f1} ");
}

