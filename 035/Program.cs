﻿//Подсчитать сумму цифр в числе. Сделать подпрограмму.

int n=1459876;
int s=0;
while(n!=0)
{
    s=s+n%10;
    n=n/10;
}
Console.WriteLine($"s={s}");