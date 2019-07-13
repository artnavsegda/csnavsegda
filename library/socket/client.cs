using System;
using System.Net;
using System.Net.Sockets;

class Program
{
	static void Main(string[] args)
	{
		IPAddress myaddr = IPAddress.Parse("127.0.0.1");
		IPEndPoint endpoint = new IPEndPoint(myaddr, 8888);
		Socket mysock = new Socket(SocketType.Stream, ProtocolType.Tcp);
		mysock.Connect(endpoint);
		Console.WriteLine("Hello World!");
	}
}
