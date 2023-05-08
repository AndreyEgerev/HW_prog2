// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

//функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}

int GetRank (int number)
{
    while (number > 999)
    {
        number /= 10;    
    }
    return number % 10;
}

bool ValidNumber (int number)
{
    if (number < 100)
    {
        Console.WriteLine("Введено некорректное число");
        return false;
    }
    return true;
}
//Приветствие
Console.WriteLine("Нахождение третьей цифры в числе");
int number = GetNumberInt("Введите число - ");
if (ValidNumber(number))
{
    Console.WriteLine(GetRank(number));
}