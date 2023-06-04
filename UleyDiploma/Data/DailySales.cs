using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace UleyDiploma.Data
{
    internal class DailySales
    {
        public BigInteger upc { get; set; }
        public DateTime dates { get; set; }
        public int quantity { get; set; }
        public int id_merchandiser { get; set; }
    }
}
