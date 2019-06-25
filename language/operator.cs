using System;

class Program
{
    static void Main(string[] args)
    {
	int i;
	i = 42 + 20;
        Console.WriteLine(i);
	i++;
        Console.WriteLine(i);
	--i;
        Console.WriteLine(i);
	i = 42 - 20;
        Console.WriteLine(i);
	i = 42 * 2;
        Console.WriteLine(i);
	i = 42 / 2;
        Console.WriteLine(i);
	i = 5 % 3;
        Console.WriteLine(i);
	float x;
	x = 26.32F + 10.0F;
        Console.WriteLine(x);
	x = 26.32F - 10.0F;
        Console.WriteLine(x);
	x = 13F * 1.5F;
        Console.WriteLine(x);
	x = 13F / 2F;
        Console.WriteLine(x);
	string f;
       	f = "hello" + "world";
        Console.WriteLine(f);
	char y;
	y = 'x';
        Console.WriteLine(y);
    }
}
