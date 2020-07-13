using System.Collections.Generic;

namespace Tourism
{
    public class Tour
    {
        public int Id { set; get; }
        public string Country { set; get; }
        public int Price { set; get; }

        public override string ToString()
        {
            return Country;
        }

        public virtual ICollection<Order> Orders { get; set; }
    }
}