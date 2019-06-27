using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCodeGenerator
{
    public class ThreeAddress
    {
        public string Result { get; }

        public string Arg1 { get; }

        public string Arg2 { get; }

        public string Op { get; }

        public ThreeAddress(String result, String arg1, String op, String arg2)
        {
            Result = result;
            Arg1 = arg1;
            Arg2 = arg2;
            Op = op;
        }

        public override string ToString()
        {
            if(Op == ":=")
            {
                return Result + Arg1 + Op + Arg2;
            }
            else
            {
                return Result + ":=" + Arg1 + Op + Arg2;
            }
            
        }
    }
}
