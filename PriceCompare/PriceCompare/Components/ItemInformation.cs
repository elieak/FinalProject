namespace PriceCompare.Components
{
    public class ItemInformation
    {
        public string ChainId { get; set; }
        public  string ItemName { get; set; }
        public string ItemCode { get; set; }
        public double ItemPrice { get; set; }
        public string StoreId { get; set; }

        public override string ToString()
        {
            return ItemName;
        }
    }
}