using System;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Threading.Tasks;
using Xunit;

namespace MixMedia.Upnp.Tests
{
    public class DiscoveryUnitTests
    {
        [Fact]
        public async Task Discovery()
        {
            var addresses = NetworkInterface.GetAllNetworkInterfaces().Where(address => address.OperationalStatus == OperationalStatus.Up);
            foreach (var address in addresses)
            {
                foreach (var uniAddress in address.GetIPProperties().UnicastAddresses.Where(add => add.Address.AddressFamily == AddressFamily.InterNetwork))
                {
                 
                    await DiscoveryService.Search(uniAddress.Address.MapToIPv4());
                }
            }
        }
    }
}
