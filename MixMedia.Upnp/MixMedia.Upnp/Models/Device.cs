using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace MixMedia.Upnp.Models
{
    [XmlType("device")]
    public class Device
    {
        [XmlElement("deviceType")]
        public string DeviceType { get; set; }

        [XmlElement("friendlyName")]
        public string FriendlyName { get; set; }

        [XmlElement("manufacturer")]
        public string Manufacturer { get; set; }

        [XmlElement("manufacturerURL")]
        public string ManufacturerUrl { get; set; }

        [XmlElement("modelNumber")]
        public string ModelNumber { get; set; }

        [XmlElement("modelDescription")]
        public string ModelDescription { get; set; }

        [XmlElement("modelName")]
        public string ModelName { get; set; }

        [XmlElement("modelUrl")]
        public string ModelUrl { get; set; }

        [XmlElement("softwareVersion")]
        public string SoftwareVersion { get; set; }

        [XmlElement("hardwareVersion")]
        public string HardwareVersion { get; set; }

        [XmlElement("serialNum")]
        public string SerialNumber { get; set; }

        [XmlElement("UDN")]
        public string Udn { get; set; }

        [XmlElement("UPC")]
        public string Upc { get; set; }

        [XmlElement("iconList")]
        public List<Icon> Icons { get; set; }

        [XmlElement("presentationUrl")]
        public string PresentationUrl { get; set; }
    }
}
