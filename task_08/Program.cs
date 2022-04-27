Console.WriteLine("введите число: ");
int a = int.Parse(Console.ReadLine());
if (a>99)
{
   do 
    { 
        a=a/10;
    }   
    while (a>=999);

    a = a%10;
    Console.Write("третья цифра числа = ");
    Console.Write(a);
}
else
Console.WriteLine ("это число двузначное и в нем нет третьей цифры!");