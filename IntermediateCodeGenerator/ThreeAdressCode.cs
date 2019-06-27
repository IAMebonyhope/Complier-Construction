using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCodeGenerator
{
    public class ThreeAdressCode
    {
        private static List<string> operators = new List<string> { "+", "-", "*", "/", "^", "~" };
        public static List<ThreeAddress> converter(List<string> postfix)
        {
            List<ThreeAddress> addressCodes = new List<ThreeAddress>();
            int tempValues = 1;

            while(postfix.Count > 2)
            {
                for(int i=(postfix.Count-1); i>=1; i--)
                {
                    if (!operators.Contains(postfix[i]))
                    {
                        continue;
                    }

                    if((postfix[i] == "~")&&(!operators.Contains(postfix[i-1])))
                    {
                        string result = "T" + tempValues;
                        tempValues++;

                        string arg2 = postfix[i - 1];
                        string op = postfix[i];
                        string arg1 = "";

                        ThreeAddress t1 = new ThreeAddress(result, arg1, op, arg2);
                        addressCodes.Add(t1);

                        postfix[i] = result;
                        postfix.RemoveAt(i - 1);
                        break;
                    }

                    else if((!operators.Contains(postfix[i - 1])) && (!operators.Contains(postfix[i - 2])))
                    {
                        string result = "T" + tempValues;
                        tempValues++;

                        string arg1 = postfix[i - 2];
                        string arg2 = postfix[i - 1];
                        string op = postfix[i];

                        ThreeAddress t1 = new ThreeAddress(result, arg1, op, arg2);
                        addressCodes.Add(t1);

                        postfix[i] = result;
                        postfix.RemoveAt(i - 1);
                        postfix.RemoveAt(i - 2);
                        break;
                    }
                }
            }

            ThreeAddress t2 = new ThreeAddress("Y", "", ":=", postfix[0]);
            addressCodes.Add(t2);

            return addressCodes;
        }
    }
}
