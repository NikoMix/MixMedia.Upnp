using System;
using System.Collections.Generic;
using System.Text;

namespace MixMedia.Upnp.Discovery
{
    public class SsdpMessage : Dictionary<string, string>
    {
        public SsdpMessage()
        {

        }

        public SsdpMessage(string host) : this()
        {
            
        }

        public override string ToString()
        {
            return $"";
        }
    }
}
