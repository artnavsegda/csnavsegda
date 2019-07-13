using System;
using System.Net;
using System.Net.Sockets;

class Program
{
	static void Main(string[] args)
	{
		using (Socket mysock = new Socket(SocketType.Stream, ProtocolType.Tcp))
		{
			IPHostEntry host = Dns.GetHostEntry("artnavsegda.herokuapp.com");
			IPEndPoint endpoint = new IPEndPoint(host.AddressList[0], 80);
			mysock.Connect(endpoint);
			if (mysock.Connected)
			{
				mysock.Send
			}
			Console.WriteLine("Hello World!");
		}
	}
}
