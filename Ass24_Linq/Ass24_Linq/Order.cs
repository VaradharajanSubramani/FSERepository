using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass24_Linq
{
    public class Order
    {
        public Order()
        {
            OrdersList = new List<Order>();

           

        }

        public int OrderID { get; set; }
        public string ItemName { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }

        public List<Order> OrdersList { get; set; }
    }
}
