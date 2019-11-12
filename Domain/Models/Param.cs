using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AutomationAPI.Models
{
    [Serializable]
    [XmlRoot("Param")]
    public class Param
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("TestBedPath")]
        public string TestBedPath { get; set; }

        [XmlAttribute("Description")]
        public string Status { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}
