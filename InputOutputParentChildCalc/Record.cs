using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputParentChildCalc
{
    class Record
    {

        public string parent { get; set; }
        public string child { get; set; }
        public decimal amount { get; set; }


        public override string ToString()
        {
            return $"{parent},{child},{amount}";
        }
    }
    class Record2
    {
        public string parent2 { get; set; }
        public string child2 { get; set; }
        public decimal amount2 { get; set; }


        public override string ToString()
        {
            return $"{parent2},{child2},{amount2}";
        }
    }
}
