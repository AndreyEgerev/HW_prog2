// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


//функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}
//Приветствие
Console.WriteLine("Нахождение второй цифры в трехзначном числе");

int number = GetNumberInt("Введите трехзначное число - ");
if (number < 100 || number > 1000)
{
    Console.WriteLine("Введено не трехзначное число");
    return;
}
int secondRank = number / 10 % 10;
Console.WriteLine("Вторая цифра " + secondRank);