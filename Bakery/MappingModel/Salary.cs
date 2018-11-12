using System;

namespace Bakery.MappingModel
{
    public class Salary
    {
        public Employee Employee { get; set; }
        public DateTime Date { get; set; }
        public int Value { get; set; }
    }
}
