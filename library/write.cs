using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
	    StreamWriter sw = File.CreateText("test.txt");
            sw.WriteLine("Hello World!");
    }
}
