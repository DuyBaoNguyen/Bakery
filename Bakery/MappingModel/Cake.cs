using System.Drawing;

namespace Bakery.MappingModel
{
    public class Cake
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public Image Image { get; set; }
        public bool Active { get; set; }
    }
}
