using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace UleyDiploma.Data
{
    public class OrdersCreate
    {
        public string name { get; set; }

        public int id { get; set; }

        public BigInteger upc { get; set; }
        
        public string inn { get; set; }

        public int quantity { get; set; }

        public string status { get; set; }

        public DateTime date_create { get; set; }

        public double price { get; set; }
    }
}
