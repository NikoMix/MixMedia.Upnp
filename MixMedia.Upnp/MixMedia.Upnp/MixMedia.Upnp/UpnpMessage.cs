using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using MixMedia.Upnp.Models;

namespace MixMedia.Upnp
{
    [XmlRoot]
    [XmlInclude(typeof(Device)), XmlInclude(typeof(SpecificationVersion))]
    public class UpnpMessage
    {
        [XmlAttribute("xmlns")]
        public string Namespace { get; set; }

        [XmlElement("specVersion")]
        public SpecificationVersion SpecificationVersion { get; set; }

        [XmlElement("URLBase")]
        public string UrlBase { get; set; }

        [XmlElement("device")]
        public Device Device { get; set; }
    }
}
