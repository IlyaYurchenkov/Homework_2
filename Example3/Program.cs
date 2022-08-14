//  Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
//  и проверяет, является ли этот день выходным
Console.Clear();

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

bool Weekend (int a)
{
    bool result = (a == 6) || (a == 7);
    return result;
}

int day = ReadInt("Введите число дня недели от 1 до 7: ");

while (day >= 8)
{
    day = ReadInt("Неккоректный ввод, повторите ввод: ");
}

if (Weekend(day) == true)
{
    Console.Write("Выходной");
}
else
{
    Console.Write("Будний день");
}
