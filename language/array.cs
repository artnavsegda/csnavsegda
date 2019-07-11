using System;

class Program
{
    static void Main(string[] args)
    {
	int[] myarray = new int[10];
	myarray[0] = 12;
        Console.WriteLine(myarray[0]);
	myarray[1] = 34;
        Console.WriteLine(myarray[1]);
	int[] noarray = { 1, 2, 3 };
        Console.WriteLine(noarray[1]);
    }
}
