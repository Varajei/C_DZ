// Урок 4. Функции
// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.Write("Введите первое число: ");
string strNum1 = Console.ReadLine();
int num1 = Convert.ToInt32(strNum1);

Console.Write("Введите второе число: ");
string strNum2 = Console.ReadLine();
int num2 = Convert.ToInt32(strNum2);

int GetArrey(int num1, int num2)
{
    int GetArrey = 1;
    for (int i = 0; i < num2; i++)
    {
        GetArrey *= num1;
    }
    return GetArrey;
}

bool BooolArrey(int num2)
{
    if (num2 < 0)
    {
        Console.WriteLine("Больше нуля");
        return false;
    }
    return true;
}

Console.WriteLine($"Число {num1} в степени {num2} равно {GetArrey(num1, num2)}");

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

// 452 -> 11

// 82 -> 10

// 9012 -> 12




// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

