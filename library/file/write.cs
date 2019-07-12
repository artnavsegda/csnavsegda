using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
	 using (StreamWriter sw = new StreamWriter("test.txt"))
	 {
              sw.WriteLine("Hello World!");
	 }
    }
}
