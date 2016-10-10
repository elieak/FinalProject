using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Linq;
using PriceCompare.Components;

namespace PriceCompare.XmlManipulation
{
    public static class XmlParser
    {
        private const string XmlFolderName = @"xml_Files\";
        private static readonly string RelativeBinDirectory = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase);
        public static readonly string DirecotryPath = new Uri(Path.Combine(RelativeBinDirectory, XmlFolderName)).AbsolutePath;

        public static readonly Dictionary<string, List<ItemInformation>> Data = new Dictionary<string, List<ItemInformation>>();

        public static void ParseXml()
        {
            Data.Clear();

            foreach (var xmlFile in Directory.GetFiles(DirecotryPath, "*.xml").Select(Path.GetFileName))
            {
                var list = new List<ItemInformation>();
                var xFile = XDocument.Load(DirecotryPath + xmlFile);
                var chainid = xFile.Root?.Element("ChainID")?.Value;
                var chainName = ChainInformation.GetChainName(chainid);

                list.AddRange(xFile.Descendants("Products")
                                   .Descendants("Product")
                                   .Select(xElement => new ItemInformation
                                   {
                                       ChainId = chainName,
                                       ItemName = xElement.Element("ItemName")?.Value,
                                       ItemPrice = (double)xElement.Element("ItemPrice"),
                                       ItemCode = xElement.Element("ItemCode")?.Value,
                                       StoreId = xElement.Element("StoreID")?.Value
                                   }));

                if (chainid != null) Data.Add(chainid, list);
            }
        }
    }
}
