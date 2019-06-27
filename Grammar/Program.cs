using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Number of Production Lines: ");

            int lines = Convert.ToInt32(Console.ReadLine());
            String[] productionLines = new String[lines];

            for (int i = 0; i < lines; i++)
            {
                Console.Write("Line " + i + ": ");
                string line = Console.ReadLine();
                productionLines[i] = line;
            }

            Grammar grammar = new Grammar(productionLines);

            Console.Write("Enter String To Be Parsed: ");
            string input = Console.ReadLine();
            grammar.parseString(input);
            Console.ReadLine();
        }
    }
}
