// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}

// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear ();
Console.WriteLine("Enter X1");
double X1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Y1");
double Y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Z1");
double Z1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter X2");
double X2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Y2");
double Y2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter Z2");
double Z2 = double.Parse(Console.ReadLine());

// double len = Math.Sqrt((X2 - X1)*(X2 - X1) + (Y2 - Y1)*(Y2 - Y1) + (Z2 - Z1)*(Z2 - Z1)); 
double len = Math.Pow((X2 - X1),2) + Math.Pow((Y2 - Y1),2) + Math.Pow((Z2 - Z1),2); 

Console.WriteLine(Math.Sqrt(len));

// Задача 23

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear ();
Console.Write("Введите число N: ");
string strNumN = Console.ReadLine();
int numN = Convert.ToInt32(strNumN);
int count = 1;

Console.WriteLine($"Квадраты чисел от 1 до {numN}:");
while (count <= numN)
{
    Console.Write($" {Math.Pow((count), 3)} ");
    count++;
}
Console.WriteLine();