using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MixMedia.Upnp.Models
{
    [XmlType("specVersion")]
    public class SpecificationVersion
    {
        [XmlElement("major")]
        public string Major { get; set; }

        [XmlElement("minor")]
        public string Minor { get; set; }
    }
}
