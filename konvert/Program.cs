using System;

Console.WriteLine("Vibirite vo chto perevesti");
Console.WriteLine("esli iz celsius v fahrenheit vibirite 1");
Console.WriteLine("esli iz fahrenheit v celsius vibirite 2");
int gr = Convert.ToInt32(Console.ReadLine());
double otvet = 0;
switch (gr)
{
    case 1:
        Console.WriteLine("Vvedite gradusi");
        int C=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("otvet");
        otvet = (C * 1.8) + 32;
        Console.WriteLine(otvet);
        break;
    case 2:
        Console.WriteLine("Vvedite gradusi");
        int F = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("otvet");
        otvet = (F-32)/1.8;
        Console.WriteLine(otvet);
        break;
}