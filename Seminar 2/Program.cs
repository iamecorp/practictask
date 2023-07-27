//Task2
//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.


Console.WriteLine("Введи 2 числа,");
Console.Write("Введи 1 число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введит 2 число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 > num2)
{
    Console.WriteLine("Число " + num1 + " большее");
    Console.Write("Число " + num2 + " меньшее");
}
else if (num1 == num2)
{
    Console.WriteLine("Число " + num1 + " равно числу " + num2);
}
else
{
    Console.WriteLine("Число " + num2 + " большее");
    Console.Write("Число " + num1 + " меньшее");
}
