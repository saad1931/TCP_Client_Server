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

            //TCP-Server//
            //Console.WriteLine("This is Server");


            //IPHostEntry host = Dns.GetHostEntry("localhost");
            //IPAddress ip = host.AddressList[0];
            //IPEndPoint ipe = new IPEndPoint(ip, 12000);

            //Socket listner = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

            //listner.Bind(ipe);
            //listner.Listen(10);

            //Socket handler = listner.Accept();

            //byte[] buffer = new byte[1024];
            //string data = " ";
            //handler.Receive(buffer);
            //data = Encoding.ASCII.GetString(buffer);

            //Console.WriteLine(data);

            //data = "Hi From Server!";
            //buffer = Encoding.ASCII.GetBytes(data);
            //handler.Send(buffer);
            //handler.Shutdown(SocketShutdown.Both);
            //handler.Close();


            //Console.ReadLine();

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



            //TCP-Client//
            //Console.WriteLine("This is Client");

            //IPHostEntry host = Dns.GetHostEntry("localhost");
            //IPAddress ip = host.AddressList[0];
            //IPEndPoint remote = new IPEndPoint(ip, 12000);


            //Socket sender = new Socket(ip.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            //sender.Connect(remote);

            //byte[] buffer = new byte[1024];
            //string data = "Hi From Client!";
            //buffer = Encoding.ASCII.GetBytes(data);
            //sender.Send(buffer);



            //sender.Receive(buffer);
            //data = Encoding.ASCII.GetString(buffer);
            //Console.WriteLine(data);



            //sender.Shutdown(SocketShutdown.Both);
            //sender.Close();

            //Console.ReadLine();
        }
    }
}
