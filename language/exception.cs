using System;

class Program
{
	static void myfunc2(int number)
	{
		if (number == 34)
		{
			throw new ArithmeticException("Number is thirty four");
		}
		Console.WriteLine(number);
	}
	static void myfunc(int number)
	{
		try
		{
			myfunc2(number);
		}
		catch (Exception e)
		{
			Console.WriteLine("error");
		}
	}
	static void Main(string[] args)
	{
		myfunc(22);
		myfunc(34);
	}
}
