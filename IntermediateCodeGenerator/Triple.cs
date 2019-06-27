using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCodeGenerator
{
    class Triple
    {
        public static void converter(List<ThreeAddress> addressCodes)
        {
            Console.WriteLine("  ||\tOperator\t||\tArg1\t||\tArg2\t");

            for (int i = 0; i < addressCodes.Count; i++)
            {
                ThreeAddress addressCode = addressCodes[i];

                string arg1 = addressCode.Arg1;
                string arg2 = addressCode.Arg2;

                if((arg1 != "") && (arg1[0] == 'T') && (arg1.Length > 1))
                {
                    int index = int.Parse(arg1[1].ToString())-1;
                    arg1 = string.Format("({0})", index);
                }

                if ((arg2 != "") && (arg2[0] == 'T') && (arg2.Length > 1))
                {
                    int index = int.Parse(arg2[1].ToString())-1;
                    arg2 = string.Format("({0})", index);
                }

                if(addressCode.Result == "Y")
                {
                    arg1 = "Y";
                }

                Console.WriteLine((i) + " ||\t\t{0}\t||\t{1}\t||\t{2}\t", addressCode.Op, arg1, arg2);
            }
        }
    }
}
