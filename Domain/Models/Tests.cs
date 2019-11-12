using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AutomationAPI.Models
{
    [Serializable]
    [XmlRoot("Tests")]
    public class Tests
    {
        [XmlAttribute("ID")]
        public string ID { get; set; }

        [XmlElement("TestCase")]
        public List<TestCase> TestCases { get; set; }

        [XmlElement("TestGroup")]
        public List<TestGroup> TestGroups { get; set; }
    }
}
