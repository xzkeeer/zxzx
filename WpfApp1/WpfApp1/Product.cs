using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    public class Product
    {
        public string ProductName { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public DateTime DeliveryTime { get; set; }
        public bool IsAvailable { get; set; }
    }
}
