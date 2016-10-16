namespace PriceCompare.Components
{
    /*Couldn't find a reference to the Subchain, which could be critical one day.
     * Make it a habit to follow domain rules- while ensuring the system will scale if they change.
     */
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