using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocketsServer
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("press any key to continue");
            Console.ReadLine();
            SyncSocketServer.StartListener();
            Console.ReadKey();
        }
    }
}
