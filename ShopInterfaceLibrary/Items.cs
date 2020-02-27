using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInterfaceLibrary
{
    public class Items
    {
        public string Title { get; set; }
        public string Discription { get; set; }
        public decimal Price { get; set; }
        public bool Sold { get; set; }
        public bool PaymentDistributed { get; set; }
        public Vendor Owner { get; set; }
        public string Display
        {
            get
            {
                return string.Format($"{Title} - {Price} руб.");
            }
        }
    }
}
