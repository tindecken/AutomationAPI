using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace AutomationAPI.Models
{
    [Serializable]
    [XmlRoot("TestSuite")]
    public class TestSuite
    {
        [Required]
        [StringLength(255)]
        [XmlAttribute("Name")]
        public string Name { get; set; }

        [XmlAttribute("vstsID")]
        public string vstsID { get; set; }

        [XmlAttribute("Status")]
        public string Status { get; set; }

        [XmlAttribute("AutoCheck")]
        public string AutoCheck { get; set; }

        [XmlAttribute("SourceURL")]
        public string SourceURL { get; set; }

        [XmlAttribute("Description")]
        public string Description { get; set; }
        
        [XmlAttribute("Author")]
        public string Author { get; set; }

        [XmlArray("Clients")]
        [XmlArrayItem("Client")]
        public List<Client> Clients { get; set; }

        [XmlElement("Tests")]
        public Tests Tests { get; set; }
       
    }
}
