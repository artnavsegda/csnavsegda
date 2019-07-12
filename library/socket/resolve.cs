using System;
using System.Net;
using System.Net.Sockets;

class Program
{
    static void Main(string[] args)
    {
	IPHostEntry host = Dns.GetHostEntry("artnavsegda.herokuapp.com");
        Console.WriteLine(host.AddressList[0]);
    }
}
