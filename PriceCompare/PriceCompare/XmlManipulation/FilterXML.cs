using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PriceCompare.Components;

namespace PriceCompare.XmlManipulation
{
    public class FilterXML
    {
        public static List<ItemInformation> IntesectingItemsList = new List<ItemInformation>();
        public static async Task<List<ItemInformation>> FilterXmlList()
        {
            var itemCollection = XmlParser.Data;

            await Task.Run(() =>
            {
                var itemInformation = itemCollection.SelectMany(v => v.Value);
                var groupedItems = itemInformation.GroupBy(v => v.ItemCode).Where(v => v.Count() == itemCollection.Keys.Count).ToList();

                IntesectingItemsList = groupedItems.SelectMany(v => v.Select(x => x)).ToList();
            });

            return IntesectingItemsList;
        }
    }
}
