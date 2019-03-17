using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputParentChildCalc
{
    class Record
    {
        public int Id { get; set; }
        public string x { get; set; }
        public string y { get; set; }
        public decimal amount { get; set; }


        public override string ToString()
        {
            return $"{Id},{x},{y},{amount}";
        }
    }
}
