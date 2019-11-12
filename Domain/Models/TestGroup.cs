using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AutomationAPI.Models
{
    [Serializable]
    [XmlRoot("TestGroup")]
    public class TestGroup
    {
        [XmlAttribute("ID")]
        public string ID { get; set; }

        [XmlAttribute("vstsID")]
        public string vstsID { get; set; }

        [XmlAttribute("Status")]
        public string Status { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Description")]
        public string Description { get; set; }

        [XmlAttribute("Author")]
        public string Author { get; set; }

        [XmlAttribute("Comment")]
        public string Comment { get; set; }

        [XmlAttribute("PrimaryCase")]
        public string PrimaryCase { get; set; }

        [XmlAttribute("Dependency")]
        public string Dependency { get; set; }

        [XmlElement("TestCase")]
        public List<TestCase> TestCases { get; set; }
    }
}
