// Урок 1. Знакомство с языком программирования С#
// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.WriteLine("Введите число А :");
string strNum = Console.ReadLine();
int num = Convert.ToInt32(strNum);

Console.WriteLine("Введите число Б :");
string strNum2 = Console.ReadLine();
int num2 = Convert.ToInt32(strNum2);

if(num > num2)
{
    Console.WriteLine("Число А > Числа Б");
}
else if(num < num2)
{
    Console.WriteLine("Число А < Числа Б");
}



// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

// Выполнение задачи было решено при помощи Условного оператора логического И && (оператор короткого замыкания) вычисляет логическое И для своих операндов. Результат операции x && y принимает значение true, если оба оператора x и y имеют значение true. В противном случае результат будет false. Если x имеет значение false, y не вычисляется.

Console.WriteLine("Введите три числа");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());

int max = x;
int min = x;
{
    max = Math.Max(x, Math.Max(y, z));
    min = Math.Min(x, Math.Min(y, z));
}
Console.WriteLine(max);
Console.WriteLine(min);

//         int max = 0;
//         int min = 0;
 
//         if (x >= y && x >= z)
//             max = x;
//         else if (y >= x && y >=z )
//             max = y;
//         else if (z >= x && z >= y)
//             max = z;
 
//         if (x<= y && x <= z)
//             min = x;
//         else if (y <= x && y <= z)
//             min = y;
//         else if (z <= x && z <= y)
//             min = z;
 
// Console.WriteLine("Максимальное число {0} . Минимальное число {1}" , max , min);
// Console.ReadLine();



// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

if (number % 2 == 0)
{
    Console.WriteLine("Четное число");
}
else
{
    Console.WriteLine("Нечетное число");
}



// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());

int i = 2;

while (i <= number)
{
    Console.Write(i + ",");
    i += 2;
}
