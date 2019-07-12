using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
	    File.Move("test.txt", "test2.txt");
    }
}
