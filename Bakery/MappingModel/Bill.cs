using System;

namespace Bakery.MappingModel
{
    public class Bill
    {
        public int Id { get; set; }
        public int Value { get; set; }
        public DateTime PaymentDate { get; set; }
        public Employee Employee { get; set; }
    }
}
