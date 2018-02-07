using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Alchemy;
using System.Net;
using Alchemy.Classes;

namespace ConsoleApplication17
{
    class Program
    {
        static void Main(string[] args)
        {
            var aServer = new WebSocketServer(1111, IPAddress.Any)
            {
                OnReceive = new OnEventDelegate(OnReceive),
                OnSend = new OnEventDelegate(OnSend),
                OnConnect = new OnEventDelegate(OnConnect),
                OnConnected = new OnEventDelegate(OnConnected),
                OnDisconnect = new OnEventDelegate(OnDisconnect),
                TimeOut = new TimeSpan(0, 5, 0)
            };

            aServer.Start();

            Console.Read();
        }

        private static void OnDisconnect(UserContext context)
        {
            Console.WriteLine("Client Connection From : " + context.ClientAddress.ToString());
        }

        private static void OnConnect(UserContext context)
        {
            Console.WriteLine("Client Connection From : " + context.ClientAddress.ToString());
        }

        private static void OnSend(UserContext context)
        {
            Console.WriteLine("Client Connection From : " + context.ClientAddress.ToString());
        }

        private static void OnReceive(UserContext context)
        {
            Console.WriteLine("Client Connection From : " + context.DataFrame.ToString());
        }

        static void OnConnected(UserContext aContext)
        {
            Console.WriteLine("Client Connection From : " + aContext.ClientAddress.ToString());
            // TODO: send data back
        }
    }
}
