Console.WriteLine("введите число: ");
int n = int.Parse(Console.ReadLine());
Console.WriteLine("введите число, чтобы проверить кратность: ");
int m = int.Parse(Console.ReadLine());
int a = n%m;
if (a==0) 
{
Console.WriteLine("первое число кратно второму!");
}
else 
{
Console.WriteLine("первое число некратно второму!");
Console.Write("остаток= ");
Console.Write(a);
}