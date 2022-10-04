// программа, которая принимает на вход три числа и выдает максимальное из этих чисел

Console.Clear();
Console.WriteLine("введите первое число");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите второе число");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("введите третье число");
int c = int.Parse(Console.ReadLine()!);
if ((a > b) & (a > c))
{
    Console.WriteLine($"число {a} максимальное");
}
else if ((b > a) &(b > c))
{
    Console.WriteLine($"число {b} максимальное");
}
else 
{
    Console.WriteLine($"число {c} максимальное");
}