Console.WriteLine("введите трехзначное число: ");
int n = int.Parse(Console.ReadLine());
int a = n%10;
int b = (n/10)%10;
int c = n/100;

if (n>99 && n<1000)
{
   
    Console.Write("число без второй цифры: ");
    Console.Write(c);
    Console.Write(a);
}
else
{
    Console.Write("это не трехзначное число!");
}
