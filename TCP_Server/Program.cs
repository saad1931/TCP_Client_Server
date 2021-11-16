using System;
using System.Net;
using System.Text;
using System.Net.Sockets;

namespace TCP_Server
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is Server");


            IPHostEntry host = Dns.GetHostEntry("localhost");
            IPAddress ip = host.AddressList[0];
            IPEndPoint ipe = new IPEndPoint(ip, 12000);

            Socket listner = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            listner.Bind(ipe);
            listner.Listen(10);

            Socket handler = listner.Accept();

            byte[] buffer = new byte[1024];
            string data = " ";
            handler.Receive(buffer);
            data = Encoding.ASCII.GetString(buffer);

            Console.WriteLine(data);

            data = "Hi From Server!";
            buffer = Encoding.ASCII.GetBytes(data);
            handler.Send(buffer);
            handler.Shutdown(SocketShutdown.Both);
            handler.Close();


            Console.ReadLine();






        }
    }
}
