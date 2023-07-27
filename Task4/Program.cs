//Task4
// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел

Console.WriteLine("Введи три числа ");
Console.Write("Введи первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введи третье число: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int maxNum = 0;
if (num1 > maxNum) maxNum = num1;
if (num2 > maxNum) maxNum = num2;
if (num3 > maxNum) maxNum = num3;

Console.Write("Максимальное значение имеет число " + maxNum);
