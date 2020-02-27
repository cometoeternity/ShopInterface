using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInterfaceLibrary
{
    public class Store
    {
        public string Name { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<Items> Items  { get; set; }
        public Store()
        {
            Vendors = new List<Vendor>();
            Items = new List<Items>();
        }
    }
}
