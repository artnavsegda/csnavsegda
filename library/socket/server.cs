using System.Net.Sockets;
using System.Net;
using System;

class Server {
    public static void Main() {
        TcpListener server = new TcpListener(IPAddress.Parse("127.0.0.1"), 80);
        server.Start();
        Console.WriteLine("Server has started on 127.0.0.1:80.{0}Waiting for a connection...", Environment.NewLine);
        TcpClient client = server.AcceptTcpClient();
        Console.WriteLine("A client connected.");
        NetworkStream stream = client.GetStream();
        //enter to an infinite cycle to be able to handle every change in stream
        while (true) {
          while (!stream.DataAvailable);
          Byte[] bytes = new Byte[client.Available];
          stream.Read(bytes, 0, bytes.Length);
        }
    }
}
