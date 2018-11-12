namespace Bakery.MappingModel
{
    public class BillDetail
    {
        public Bill Bill { get; set; }
        public Cake Cake { get; set; }
        public int Amount { get; set; }
        public int Cost { get; set; }
    }
}
