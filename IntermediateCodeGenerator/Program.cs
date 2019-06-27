using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Expression: ");
            string input = Console.ReadLine();
            Console.WriteLine();

            List<string> postfix = InfixToPostFix.converter(input);
            if(postfix.Count <= 0)
            {
                Console.WriteLine("Invalid Expression");
            }
            else
            {
                Console.WriteLine("PostFix Expression: ");
                Console.WriteLine(string.Join(" ", postfix));

                Console.WriteLine();
                Console.WriteLine();

                List<ThreeAddress> addressCodes = ThreeAdressCode.converter(postfix);
                Console.WriteLine("Three Address Codes: ");
                Console.WriteLine(string.Join("\n", addressCodes));

                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Quadruple: ");
                Quadruple.converter(addressCodes);
                Console.WriteLine();
                Console.WriteLine();

                Console.WriteLine("Triple: ");
                Triple.converter(addressCodes);
                Console.WriteLine();
                Console.WriteLine();
            }


            Console.ReadLine();
        }
    }
}
