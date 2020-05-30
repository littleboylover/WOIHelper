using System.Collections.Generic;
using System.Xml.Serialization;

namespace WOIHelper.Data.Models
{
    [XmlRoot("Packs")]
    public class PackList
    {
        [XmlElement("Pack")]
        public List<Pack> Packs { get; set; }
    }
}