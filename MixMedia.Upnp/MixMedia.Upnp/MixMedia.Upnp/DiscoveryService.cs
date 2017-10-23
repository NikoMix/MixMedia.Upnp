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


                    udpSocket.IOControl(-1744830452, new[] {Convert.ToByte(false)}, null);

                    udpSocket.Bind(new IPEndPoint(localAddress, 0));

                    var multicastEndpoint = new IPEndPoint(IPAddress.Parse("239.255.255.250"), 1900);
                    var req = "M-SEARCH * HTTP/1.1\r\n" +
                              $"HOST: 239.255.255.250\r\n" +
                              $"ST: *\r\n" +
                              "MAN: \"ssdp:discover\"\r\n" +
                              "MX: 10\r\n\r\n";
                    var data = new ArraySegment<byte>(Encoding.UTF8.GetBytes(req));
                    for (int i = 0; i < 3; i++)
                    {
                        await udpSocket.SendToAsync(data, SocketFlags.None, multicastEndpoint);
                    }

                    byte[] buffer = new byte[4096];
                    int iRx = udpSocket.Receive(buffer);
                    char[] chars = new char[iRx];

                    System.Text.Decoder d = System.Text.Encoding.UTF8.GetDecoder();
                    int charLen = d.GetChars(buffer, 0, iRx, chars, 0);
                    System.String recv = new System.String(chars);

                  Console.WriteLine(recv);

        
                    
                    //var result = await udpSocket.ReceiveAsync(new ArraySegment<byte>(new byte[4096]), SocketFlags.None);
                    //udpSocket.EndReceive()
      

                }
            }
            catch (TimeoutException) { }
            catch (ObjectDisposedException) { }


            await new Task(() => {});
        }

        public class StateObject
        {
            // Client socket.
            public Socket workSocket = null;
            // Size of receive buffer.
            public const int BufferSize = 256;
            // Receive buffer.
            public byte[] buffer = new byte[BufferSize];
            // Received data string.
            public StringBuilder sb = new StringBuilder();
        }

        private static void Callback(IAsyncResult ar)
        {
            try
            {
                // Retrieve the state object and the client socket 
                // from the asynchronous state object.
                StateObject state = (StateObject)ar.AsyncState;
                Socket client = state.workSocket;
                // Read data from the remote device.
                int bytesRead = client.EndReceive(ar);
                if (bytesRead > 0)
                {
                    // There might be more data, so store the data received so far.
                    state.sb.Append(Encoding.ASCII.GetString(state.buffer, 0, bytesRead));
                    //  Get the rest of the data.
                    client.BeginReceive(state.buffer, 0, StateObject.BufferSize, 0,
                        new AsyncCallback(Callback), state);
                }
                else
                {
                    // All the data has arrived; put it in response.
                    if (state.sb.Length > 1)
                    {
                        state.sb.ToString();
                    }
                    // Signal that all bytes have been received.

                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }
    }
}
