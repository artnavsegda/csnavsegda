using System;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
	Socket mysock = new Socket(SocketType.Stream, ProtocolType.Tcp);
        Console.WriteLine("Hello World!");
    }
}
