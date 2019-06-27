using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntermediateCodeGenerator
{
    class InfixToPostFix
    {
        public override string ToString()
        {
            return base.ToString();
        }
        public static List<String> converter(string expression)
        {
            List<string> postfix = new List<string>();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < expression.Length; ++i)
            {
                char c = expression[i];

                // If the scanned character is an operand, add it to output.  
                if (char.IsLetterOrDigit(c))
                {
                    postfix.Add(c.ToString());
                }

                // If the scanned character is an '(', push it to the stack.  
                else if ((c == '(') || (stack.Count < 1))
                {
                    stack.Push(c);
                }

                //  If the scanned character is an ')', pop and output from the stack   
                // until an '(' is encountered.  
                else if (c == ')')
                {
                    while (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfix.Add(stack.Pop().ToString());
                    }

                    if (stack.Count > 0 && stack.Peek() != '(')
                    {
                        postfix = new List<string>();
                        return postfix; // invalid expression 
                    }

                    if (stack.Count <= 0)
                    {
                        postfix = new List<string>();
                        return postfix; // invalid expression 
                    }

                    else
                    {
                        stack.Pop();
                    }
                }
                else // an operator is encountered 
                {
                    while (stack.Count > 0 && precedence(c) <= precedence(stack.Peek()))
                    {
                        postfix.Add(stack.Pop().ToString());
                    }
                    stack.Push(c);
                }

            }

            // pop all the operators from the stack  
            while (stack.Count > 0)
            {
                postfix.Add(stack.Pop().ToString());
            }

            return postfix;

        }

        private static int precedence(char ch)
        {
            switch (ch)
            {
                case '~':
                    return 4;

                case '+':
                case '-':
                    return 1;

                case '*':
                case '/':
                    return 2;

                case '^':
                    return 3;
            }
            return -1;
        }
    }
}
