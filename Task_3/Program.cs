// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет


//функция ввода числа и возврата в числовом формате
int GetNumberInt( string text)
{
    Console.Write(text);
    string value = Console.ReadLine ();
    int number = Convert.ToInt32(value);
    return number;
}
//функция проверки корректности ввода номера дня
bool ValidDay (int numberDay)
{
    if (numberDay > 0 && numberDay <=7)
    {
        return true;
    }
    Console.WriteLine("Введен не номер дня недели");
    return false;
}
//функция определения дня недели
bool NumDay(int numberDay)
{
    if (numberDay > 5)
    {
        return true;
    }
    return false;
}
//Приветствие
Console.WriteLine("Определение является ли день выходным, по введенному номеру дня");

int dayNumber = GetNumberInt("Введите номер дня недели ");
if (ValidDay(dayNumber))
{
    if (NumDay(dayNumber))
    {
        Console.WriteLine("Выходной");
    }
    else
    {
        Console.WriteLine("Рабочий день");
    }
}