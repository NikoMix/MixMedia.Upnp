using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MixMedia.Upnp.Models
{
    [XmlType("icon")]
    public class Icon
    {
        [XmlElement("id")]
        public int Id { get; set; }

        [XmlElement("mimetype")]
        public string MimeType { get; set; }

        [XmlElement("width")]
        public int Width { get; set; }

        [XmlElement("height")]
        public int Height { get; set; }

        [XmlElement("depth")]
        public int Depth { get; set; }

        [XmlElement("url")]
        public string Url { get; set; }
    }
}
