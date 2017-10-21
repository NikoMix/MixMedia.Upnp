using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace MixMedia.Upnp
{
    // References:
    // https://www.dvb.org/standards
    // https://openconnectivity.org/developer
    public static class DiscoveryService
    {
        public static async Task Search(IPAddress localAddress)
        {
            try
            {
                var responses = new List<string>();
                using (var udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
                {
                    udpSocket.ExclusiveAddressUse = true;
                    
                    udpSocket.Bind(new IPEndPoint(localAddress, 0));

                    var multicastEndpoint = new IPEndPoint(IPAddress.Parse("239.255.255.250"), 1900);

                    udpSocket.BeginReceive(new List<ArraySegment<byte>>(), SocketFlags.None, Callback, null);
                    //udpSocket.EndReceive()


                }
            }
            catch (TimeoutException) { }
            catch (ObjectDisposedException) { }


            await new Task(() => {});
        }

        private static void Callback(IAsyncResult ar)
        {
            throw new NotImplementedException();
        }
    }
}
