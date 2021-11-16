using System;
using System.Net;
using System.Text;
using System.Net.Sockets;

namespace TCP_Client_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Client");

            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ip = host.AddressList[0];
            IPEndPoint remote = new IPEndPoint(ip, 12000);


            Socket sender = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            sender.Connect(remote);

            byte[] buffer = new byte[1024];
            string data = "Hi From Client!";
            buffer = Encoding.ASCII.GetBytes(data);
            sender.Send(buffer);



            sender.Receive(buffer);
            data = Encoding.ASCII.GetString(buffer);
            Console.WriteLine(data);



            sender.Shutdown(SocketShutdown.Both);
            sender.Close();

            Console.ReadLine();
        }
    }
}
