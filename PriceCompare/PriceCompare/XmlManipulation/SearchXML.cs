using System.Collections.Generic;
using PriceCompare.Components;

namespace PriceCompare.XmlManipulation
{
    public static class SearchXML
    {
        public static List<ItemInformation> Result(string searchText)
        {
            return FilterXML.IntesectingItemsList.FindAll(x => x.ItemName.Contains(searchText));
        }
    }
}
