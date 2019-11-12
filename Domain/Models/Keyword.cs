using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AutomationAPI.Models
{
    [Serializable]
    [XmlRoot("Client")]
    public class Keyword
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("Status")]
        public string Status { get; set; }

        [XmlAttribute("None")]
        public string None { get; set; }

        [XmlAttribute("Product")]
        public string Product { get; set; }

        [XmlAttribute("Feature")]
        public string Feature { get; set; }

        [XmlAttribute("StartTime")]
        public string StartTime { get; set; }

        [XmlAttribute("FinishTime")]
        public string FinishTime { get; set; }

        [XmlAttribute("Description")]
        public string Description { get; set; }

        [XmlAttribute("Comment")]
        public string Comment { get; set; }

        [XmlElement("Param")]
        public List<Param> Params { get; set; }
    }
}
