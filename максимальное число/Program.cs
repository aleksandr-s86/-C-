// находим максимальное из трёх чисел
Console.WriteLine("Введите первое число");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int number2 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int number3 = int.Parse(Console.ReadLine()!);
int max = number1;
if(number2>number3)
{
Console.WriteLine("максимальное число -"+number2);
}
if(number3>number1)
{
Console.WriteLine("максимальное число -"+number3);
}
else
{Console.WriteLine("максимальное число -"+number1);
}