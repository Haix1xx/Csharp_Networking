using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace SocketsClient
{
    public class SyncSocketClient
    {
        public static void StartClient()
        {
            byte[] buffer = new byte[1024];
            try
            {
                var hostName = Dns.GetHostName();
                IPHostEntry ipHost = Dns.GetHostEntry(hostName);
                Console.WriteLine($"Host: {hostName}");
                IPAddress address = ipHost.AddressList[0];
                IPEndPoint remoteEp = new IPEndPoint(address, 43665);
                Socket sender = new Socket(address.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                try
                {
                    sender.Connect(remoteEp);
                    Console.WriteLine("Socket connected");
                    byte[] msg = Encoding.ASCII.GetBytes("This is just a test <EOF>");
                    var byteSent = sender.Send(msg);
                    var byteRec = sender.Receive(buffer);
                    Console.WriteLine($"Echoed test {Encoding.ASCII.GetString(buffer, 0, byteRec)}");

                    //release the socket
                    sender.Shutdown(SocketShutdown.Both);
                    sender.Close();
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (SocketException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
