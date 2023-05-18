using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using YeelightAPI.Models;

namespace YeelightAPI
{
    [XmlRoot("Device")]
    public class DeviceModel
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlAttribute("Hostname")]
        public string Hostname { get; set; }

        [XmlAttribute("Port")]
        public int Port { get; set; }

        [XmlAttribute("Id")]
        public string Id { get; set; }

        public DeviceModel()
        {

        }
    }


}
