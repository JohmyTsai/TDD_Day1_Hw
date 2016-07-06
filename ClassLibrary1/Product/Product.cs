using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    public class Order
    {
        public int _Id { get; set; }
        public int _Cost { get; set; }
        public int _Revenue { get; set; }
        public int _SellPrice { get; set; }

        public Order()
        {
        }

        public Order(int id, int Cost, int Revenue, int SellPrice)
        {
            _Id = id;
            _Cost = Cost;
            _Revenue = Revenue;
            _SellPrice = SellPrice;
        }
    }
}