using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hotel.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string SuiteType, int Capacity, decimal PriceDay) { }

        public Suite(string name) { }
        public string SuiteType { get; set; }
        public int Capacity { get; set; }
        public decimal PriceDay { get; set; }
    }
}