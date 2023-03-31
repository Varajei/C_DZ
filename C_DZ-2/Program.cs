// Урок 2. Базовые алгоритмы
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1

Console.Write("Введите трехзначное число: ");
int Value = Convert.ToInt32(Console.ReadLine());
int Length = Value.ToString().Length;
if (Length == 3) 
{
	int result = ( Value/10 ) % 10;
	Console.WriteLine("Вторая цифра числа - " + result);
} 
else
{
	Console.WriteLine("Не верное число");
}


// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

// 645 -> 5

// 78 -> третьей цифры нет

// 32679 -> 6

Console.Write("Введите номер:");
int Value2 = Convert.ToInt32(Console.ReadLine());
int Length2 = Value2.ToString().Length;
if (Length2 >= 3) 
{
	while (Value2 > 999)
	{
		Value2 = Value2 / 10;
	}
	int result = Value2 % 10;
	Console.WriteLine("Третья цифра - " + result);
} 
else 
{
	Console.WriteLine("Это не трехзначное число");
}

// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Введите день недели: ");
int Day = Convert.ToInt32(Console.ReadLine());
if (Day >= 1 && Day <=7) 
{
	if (Day >= 6) 
    {
		Console.Write("Выходной день");
	} 
    else 
    {
		Console.Write("Рабочий день");
	}
} 
else 
{
	Console.Write("Неправельный день недели");
}