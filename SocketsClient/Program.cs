using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketsClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press any key to continue");
            Console.ReadLine();
            SyncSocketClient.StartClient();
            Console.ReadKey();
        }
    }
}
