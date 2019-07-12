using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
	 using (StreamReader sr = new StreamReader("test2.txt"))
	 {
	      Console.WriteLine(sr.ReadToEnd());
	 }
    }
}
