using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

class Program
{
	static void Main(string[] args)
	{
		IPAddress myaddr = IPAddress.Parse("192.168.88.41");
		IPEndPoint endpoint = new IPEndPoint(myaddr, 9999);
		Socket mysock = new Socket(endpoint.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
		mysock.Connect(endpoint);
		if (mysock.Connected)
		{
			mysock.Send(Encoding.ASCII.GetBytes("hello"));
		}
		Console.WriteLine("Hello World!");
	}
}
