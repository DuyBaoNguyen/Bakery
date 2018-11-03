using Bakery.MappingModel;

namespace Bakery.Other
{
    public class ListOrder
    {
        static EventList<Order> instance;

        public static EventList<Order> Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new EventList<Order>();
                }
                return instance;
            }
        }

        private ListOrder() { }
    }
}
