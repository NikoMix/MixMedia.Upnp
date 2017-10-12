using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace MixMedia.Upnp
{
    public static class Discovery
    {
        public static async Task Search()
        {
            try
            {
                using (var udpSocket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp))
                {
                    udpSocket.ExclusiveAddressUse = true;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
            await new Task(() => {});
        }
    }
}
