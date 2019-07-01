using System;

class Program
{
    static void Main(string[] args)
    {
	myclass myobj = new myclass();
	myobj.printhello();
    }
}

public class myclass
{
    public void printhello()
    {
        Console.WriteLine("Hello World!");
    }
}
