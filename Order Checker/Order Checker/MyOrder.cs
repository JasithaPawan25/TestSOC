using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_Checker
{
    class MyOrder
    {
        public int id { get; set; }
        public string DrugName { get; set; }
        public int DrugQty { get; set; }
        public double DrugPrice { get; set; }
        public string Description { get; set; }
        public string PharmacyName { get; set; }
        public string PharmacyAddress { get; set; }
        public string PharmacyCity { get; set; }
        public int PharmacyContactNO { get; set; }
    }
}
