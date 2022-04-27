Console.WriteLine("введите число от 10 до 99: ");
int n = int.Parse(Console.ReadLine());
int a = n%10;
int b = (n/10)%10;
if (n>=10 && n<=99)
{
    int max = a;
    if (b>max) max = b;
    Console.Write("наибольшая цифра числа: ");
    Console.Write(max);
}
else
{
    Console.Write("это число не входит в отрезок от 10 до 99!");
}

