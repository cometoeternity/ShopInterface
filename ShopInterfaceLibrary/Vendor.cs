using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopInterfaceLibrary
{
    public class Vendor
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Commission { get; set; }
        public decimal PaymentDue { get; set; }
        public string Display
        {
            get
            {
                return string.Format($"{LastName} {FirstName} - {PaymentDue} руб.");
            }
        }
        public Vendor()
        {
            Commission = .8;
        }
    }
}
