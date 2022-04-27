Console.WriteLine("введите первое число: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("введите второе число: ");
int b = int.Parse(Console.ReadLine());

if (a==b*b)
{
    Console.Write("Первое число является квадратом второго!");
}
else
{
    Console.Write("Первое число не является квадратом второго!");
}