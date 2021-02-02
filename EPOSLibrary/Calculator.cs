using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary
{
    public class Calculator
    {
        // TODO - Check validity
        // TODO - Add decimal place support

        public static List<string> ConvertToRPN(List<string> inFixQueue)
        {
            List<string> RPN = new List<string>();

            string poppedOperator;
            CustomStack<string> operators = new CustomStack<string>();
            foreach (string current in inFixQueue)
            {
                if (current.IsNumeric())
                {
                    RPN.Add(current);
                }
                else if (current == "(")
                {
                    operators.Push(current);
                }
                else if (current == ")")
                {
                    // Remove all previous elements from stack and pput them in front of RPN
                    poppedOperator = operators.Pop();
                    while (poppedOperator != "(")
                    {
                        RPN.Add(poppedOperator);
                        poppedOperator = operators.Pop();
                    }
                }
                else
                {
                    // If there are operators in the operator stack, and the top operator is of higher or equal precedence than the current operator
                    if (operators.Count != 0 && IsPrecedenceGreaterOrEqualTo(operators.Peek(), current))
                    {
                        poppedOperator = operators.Pop();
                        while (IsPrecedenceGreaterOrEqualTo(poppedOperator, current))
                        {
                            RPN.Add(poppedOperator);
                            if (operators.Count == 0)
                            {
                                break;
                            }
                            poppedOperator = operators.Pop();
                        }
                        operators.Push(current);
                    }
                    else
                    {
                        // The stack is empty or the operator has precedence
                        operators.Push(current);
                    }
                }
            } 
            while (operators.Count > 0)
            {
                poppedOperator = operators.Pop();
                RPN.Add(poppedOperator);
            }
            return RPN;
        }

        public static int EvaluateRPN(List<string> RPN)
        {
            CustomStack<int> operands = new CustomStack<int>();

            foreach (string current in RPN)
            {
                if (current.IsNumeric())
                {
                    operands.Push(Int32.Parse(current));
                }
                else
                {
                    int op2 = operands.Pop();
                    int op1 = operands.Pop();

                    if (current == "-")
                    {
                        operands.Push(op1 - op2);
                    }
                    else if (current == "+")
                    {
                        operands.Push(op1 + op2);
                    }
                    else if (current == "/")
                    {
                        operands.Push(op1 / op2);
                    }
                    else if (current == "*")
                    {
                        operands.Push(op1 * op2);
                    }
                    else if (current == "^")
                    {
                        operands.Push((int)Math.Pow(op1, op2));
                    }
                }
            }
            return operands.Pop();
        }

        private static bool IsPrecedenceGreaterOrEqualTo(string firstOperator, string secondOperator)
        {
            Dictionary<string, int> precedence = new Dictionary<string, int>() {
                { "(", 0},
                { "+", 1 }, { "-", 1 },
                { "*", 2 }, { "/", 2 },
                { "^", 3}
            };

            return precedence[firstOperator] >= precedence[secondOperator];
        }
    }
}
