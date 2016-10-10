using System.Collections.Generic;

namespace PriceCompare.Components
{
    public class MinMax
    {
        public string ChainId { get; set; }
        public List<ItemInformation> Max { get; set; }
        public List<ItemInformation> Min { get; set; }
    }
}