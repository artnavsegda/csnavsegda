using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
	 using (StreamReader sr = new StreamReader("test.txt"))
	 {
	      Console.WriteLine(sr.ReadToEnd());
	 }
    }
}
