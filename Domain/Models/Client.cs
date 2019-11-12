using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AutomationAPI.Models
{
    [Serializable]
    [XmlRoot("Client")]
    public class Client
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Type")]
        public string Type { get; set; }

        [XmlAttribute("Address")]
        public string Address { get; set; }

        [XmlAttribute("Description")]
        public string Description { get; set; }
    }
}
