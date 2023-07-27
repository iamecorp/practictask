Console.Write("Введи число: ");
int num = Convert.ToInt32(Console.ReadLine());
int quad = 2;

while (num >= quad)
{
    Console.Write(quad + " ");
    quad = quad + 2;
}