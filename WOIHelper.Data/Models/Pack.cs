using System.Collections.Generic;
using System.Xml.Serialization;

namespace WOIHelper.Data.Models
{
    public class Pack
    {
        [XmlElement("Name")]
        public string Name { get; set; }

        [XmlElement("Item")]
        public List<PackItem> Items { get; set; }
    }
}