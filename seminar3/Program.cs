//practica2
/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1
*/

/*int number = ReadInt("Enter a three-digit number: ");
int amount = number.ToString().Length;

if (amount < 3 || amount > 3)
{
    Console.WriteLine("You didn't enter a three-digit number.");
}
else
{
    Console.WriteLine(InCenter(number));
}


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int InCenter(int a)
{
    
    int result = ((a / 10) % 10);
    return result;
}
*/

//practica3
/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа ( или -1, если третьей цифры нет).
645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

/*
int number = ReadInt("Enter the number: ");
int count = number.ToString().Length;
Console.Write(MakeArray(number, count));

int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int MakeArray(int a, int b)
{
int result = 0;
    if (b < 3)
    {
        Console.Write("There's no number 3, so here you go: ");
    }
    else
    {
        int c = 1;
        for (int i = b; i > 3; i--)
        {
            c = c * 10;
        }

        result = (a / c) % 10;
    }
return result;
}
*/

//practica4
/*Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным./*

/*int dayNumber = ReadInt("Enter the number from 1 to 7:");
Console.WriteLine(WorkHoliday(dayNumber));


int ReadInt(string message)
{
    Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

string WorkHoliday(int a)
{
    if (a > 0 && a < 8)
    {
        if (a == 7 || a == 6)
        {
            Console.Write("Underneath the digit. " + a + " - Weekend");
        }
        else
        {
            Console.Write("Underneath the digit " + a + " - Working");
        }
    }
    else
    {
        Console.Write("You entered a number not in the range of 1 to 7, so you can't determine");
    }
    return " day.";
}
*/
