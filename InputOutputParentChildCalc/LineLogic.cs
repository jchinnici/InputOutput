using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputParentChildCalc
{
    public class LineLogic
    {
        public LineLogic(string line, string nextLine)
        {
            
            decimal amount = line[3];
            decimal nxtAmount = nextLine[3];
            if (line[2] == nextLine[1])
            {
                decimal calcAmount = (amount * nxtAmount);
                string calcLine = $"{line[1]},{nextLine[3]},{calcAmount}";
                Console.WriteLine(calcLine);

            }
            else Console.WriteLine("SHIT");
        }
    }
}
