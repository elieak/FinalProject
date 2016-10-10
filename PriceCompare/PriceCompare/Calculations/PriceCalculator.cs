using System.Collections.Generic;
using System.Linq;
using System.Text;
using PriceCompare.Components;
using PriceCompare.XmlManipulation;

namespace PriceCompare.Calculations
{
    public class PriceCalculator
    {
        public List<string> CalculatePrice(IEnumerable<ItemInformation> listboxItems)
        {
            var itemsTotal = XmlParser.Data
                .SelectMany(v => v.Value)
                .Where(v => { return listboxItems.Any(x => v.ItemCode == x.ItemCode); })
                .GroupBy(x => x.ChainId)
                .Select(v => { return new { Sum = v.Sum(x => x.ItemPrice * listboxItems.Count(z => z.ItemCode == x.ItemCode)), Name = v.Key }; })
                .OrderBy(v => v.Sum)
                .Select(v => $"{v.Name} {v.Sum}").ToList();

            return itemsTotal;
        }

        public List<MinMax> CalculateMinMax()
        {
            var filteredList = FilterXML.IntesectingItemsList;

            var minMaxItems = filteredList.GroupBy(v => v.ChainId)
                                 .Select(v => new MinMax
                                 {
                                     ChainId = v.Key,
                                     Min = v.OrderBy(x => x.ItemPrice).Take(3).ToList(),
                                     Max = v.OrderByDescending(x => x.ItemPrice).Take(3).ToList(),
                                 }).ToList();

            return minMaxItems;
        }

        public string GetMax(List<MinMax> minMaxItems)
        {
            var sb = new StringBuilder();
            foreach (var minMax in minMaxItems)
            {
                sb.Append($"\n{minMax.ChainId}\n");
                foreach (var highest in minMax.Max)
                {
                    sb.Append($"{highest.ItemName}: {highest.ItemPrice}\n");
                }
            }
            return sb.ToString();
        }

        public string GetMin(List<MinMax> minMaxItems)
        {
            var sb = new StringBuilder();
            foreach (var minMax in minMaxItems)
            {
                sb.Append($"\n{minMax.ChainId}\n");
                foreach (var lowest in minMax.Min)
                {
                    sb.Append($"{lowest.ItemName}: {lowest.ItemPrice}\n");
                }
            }
            return sb.ToString();
        }
    }
}
