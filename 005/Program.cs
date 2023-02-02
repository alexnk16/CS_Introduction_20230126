// С клавиатуры вводятся два числа. Найти и вывести на экран максимальное из них
int a,b,c;
System.Console.Write("Введите a:");
a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b:");
b=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите c:");
c=Convert.ToInt32(Console.ReadLine());


int max;


if (a>b)
{
max=a;
}
else
{
    max=b;
}

if (a>c)
{
max=a;
}
else
{
    max=c;
}

System.Console.WriteLine($"max={max}");

