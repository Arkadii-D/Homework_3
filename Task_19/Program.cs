// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.WriteLine("Введите пятизначное число: ");
string number = Console.ReadLine();
int len = number.Length;
if (len == 5)
{
 if (number[0] == number[4] && number[1] == number[3])
    {
 Console.WriteLine($"{number} - Является палиндром");
    }
 else
    {
 Console.WriteLine($"{number} - Не является палиндром");
    }
}
else
{
 Console.WriteLine($"Внимание ошибка: {number} - число не пятизначное");
}

