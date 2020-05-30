using System.Xml.Serialization;

namespace WOIHelper.Data.Models
{
    public class PackItem
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Chance")]
        public string Chance { get; set; }
    }
}