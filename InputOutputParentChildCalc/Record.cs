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

}
