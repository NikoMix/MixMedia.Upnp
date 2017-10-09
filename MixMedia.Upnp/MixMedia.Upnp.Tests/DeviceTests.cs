using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Xml.Serialization;

namespace MixMedia.Upnp.Tests
{
    [TestClass]
    public class DeviceTests
    {
        [TestMethod]
        public void TestBaseDeviceMessageTest()
        {

            var serializer = new XmlSerializer(typeof(UpnpMessage));
            UpnpMessage result;

            using (TextReader reader = new StringReader(DeviceTestMessages.BasicDevice))
            {
                result = (UpnpMessage)serializer.Deserialize(reader);
            }

            Assert.IsTrue(true);
        }
    }
}
