using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace UleyDiploma.Data
{
    internal class Products
    {
        public BigInteger upc { get; set; }

        public string name { get; set; }

        public double price { get; set; }

        public int discount { get; set; }

        public string catalog { get; set; }

        public string description { get; set; }

        public int quantity { get; set; }

        public bool application_visible { get; set; }

        public string preview { get; set; }
    }
}
