using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grammar
{
    public class Grammar
    {
        private Dictionary<string, string> rulesDictionary;
        private String[] productionRules;
        public Grammar(String[] rules)
        {
            rulesDictionary = new Dictionary<string, string>();
            productionRules = rules;
            createRules();
        }

        private void createRules()
        {
            for(int i=0; i<productionRules.Length; i++)
            {
                string rule = productionRules[i];
                rule = rule.Replace(" ", "");

                string[] productionLine = rule.Split(new string[] { ":=>" }, StringSplitOptions.None);
                string LHS = productionLine[0];
                string[] RHS = productionLine[1].Split('|');

                for(int j=0; j<RHS.Length; j++)
                {
                    rulesDictionary.Add(RHS[j], LHS);
                }
            }
        }

        public void parseString(string inputString)
        {
            String stack = "";
            Console.WriteLine(inputString);

            for (int i=0; i<inputString.Length; i++)
            {
                stack += inputString[i];

                for(int j=(stack.Length-1); j>=0; j--)
                {
                    bool isReduced = true;
                    while (isReduced == true)
                    {
                        isReduced = false;

                        int startIndex = j;
                        int endIndex = stack.Length - j;
                        string temp = stack.Substring(startIndex, endIndex);

                        if (rulesDictionary.ContainsKey(temp))
                        {
                            string valueInRules = rulesDictionary[temp];
                            stack = stack.Replace(temp, valueInRules);
                            string temp2 = inputString.Substring((i + 1), (inputString.Length - (i + 1)));
                            Console.WriteLine(stack + temp2);
                            isReduced = true;
                        }
                    }
                       
                }
                
            }
        }
    }
}
