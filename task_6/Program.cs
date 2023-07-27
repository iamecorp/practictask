//Task6
// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
int remain = num % 2;
if (remain == 0)
{
    Console.WriteLine("Число " + num + " чётное?");
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Число " + num + " чётное?");
    Console.WriteLine("Нет");
}