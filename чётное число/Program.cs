// Чётное число
Console.WriteLine("Введите число");
int number =int.Parse(Console.ReadLine()!);
int result = number/2;
if (number%2==0)
{
    Console.WriteLine("четное");
}
else
{
    Console.WriteLine("нечётное");
}