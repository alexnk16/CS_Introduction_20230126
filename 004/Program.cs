// По заданному с клавиатуры номеру дня недели вывести его название

// 7 дней недели, 1-понедельник,2-вторник, 3-....
// если вводим другие числа - выходит напоминалка

string? s;
int a, b ,c, d, e, f, g, h;

s=Console.ReadLine();

a=Convert.ToInt32(s);
b=Convert.ToInt32(s);
c=Convert.ToInt32(s);
d=Convert.ToInt32(s);
e=Convert.ToInt32(s);
f=Convert.ToInt32(s);
g=Convert.ToInt32(s);
h=Convert.ToInt32(s);



if (a==1)
System.Console.WriteLine("Monday");
if (b==2)
System.Console.WriteLine("Tuesday");
if (c==3)
System.Console.WriteLine("Wednesday");
if (d==4)
System.Console.WriteLine("Thursday");
if (e==5)
System.Console.WriteLine("Friday");
if (f==6)
System.Console.WriteLine("Saturday");
if (g==7)
System.Console.WriteLine("Sunday");


if (h>7)
System.Console.WriteLine("Monday-1, Tuesday-2; Wednesday–3; Thursday–4; Friday–5; Saturday–6; Sunday–7");

