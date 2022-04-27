Console.WriteLine("введите трехзначное число: ");
int a = int.Parse(Console.ReadLine());
if (a>99 && a<1000)
{
    a = (a/10)%10;
    Console.Write("вторая цифра этого числа: ");
    Console.Write(a);
}

else
{
    Console.Write("число не трехзначное!");
}
