using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCodeGenerator
{
    public class Quadruple
    {
        public static void converter(List<ThreeAddress> addressCodes)
        {
            Console.WriteLine("  ||\tOperator\t||\tArg1\t||\tArg2\t||\tResult");
            
            for(int i=0; i<addressCodes.Count; i++)
            {
                ThreeAddress addressCode = addressCodes[i];
                Console.WriteLine((i+1) + " ||\t\t{0}\t||\t{1}\t||\t{2}\t||\t{3}", addressCode.Op, addressCode.Arg1, addressCode.Arg2, addressCode.Result);
            }
        }
    }
}
