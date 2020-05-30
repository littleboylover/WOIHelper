using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
using WOIHelper.Data.Models;

namespace WOIHelper.Services
{
    public class PackService
    {
        private readonly PackList _packList;

        public PackService()
        {
            if (_packList == null)
            {
                _packList = InitPacks();
            }
        }

        private PackList InitPacks()
        {
            var serializer = new XmlSerializer(typeof(PackList));

            using (var stream = new FileStream("Xml/Packs.xml", FileMode.Open))
            {
                return (PackList) serializer.Deserialize(stream);
            }
        }

        public IEnumerable<Pack> GetAllPacks()
        {
            return _packList.Packs;
        }

        public IEnumerable<PackItem> GetAllItems()
        {
            return _packList.Packs.SelectMany(p => p.Items).ToList();
        }

        public Pack GetPackByName(string packName)
        {
            return _packList.Packs.FirstOrDefault(p => p.Name.Equals(packName));
        }
    }
}