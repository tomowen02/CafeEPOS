using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EPOSLibrary
{
    public class Calculator
    {
        public delegate void ExpressionChangedEvent(object sender, ExpressionChangedEventArgs e);
        public event ExpressionChangedEvent OnExpressionChanged;


        List<string> expression = new List<string>();


        public void AddDigit(string digit)
        {
            string lastItem = "";
            string secondToLastItem = "";

            try
            {
                lastItem = expression.Last();
                secondToLastItem = expression[expression.Count - 2];
            }
            catch (Exception) { }

            // If there is only one item and that item is a plus or minus
            if (!secondToLastItem.IsNumeric() & (lastItem == "+" || lastItem == "-"))
            {
                expression[expression.Count - 1] += digit;
            }
            else if (lastItem.IsNumeric())
            {
                expression[expression.Count - 1] += digit;
            }
            else
            {
                expression.Add(digit);
            }

            SendExpressionChanged();
        }

        public void AddOperand(string operand)
        {
            expression.Add(operand);

            SendExpressionChanged();
        }

        public void AddDecimal()
        {
            if (expression.Last().IsNumeric())
            {
                expression[expression.Count - 1] += ".";

                SendExpressionChanged();
            }
        }

        public void Del()
        {
            if (expression.Count > 0)
            {
                int lastItemIndex = expression.Count - 1;

                string lastItem = expression.Last();
                if (lastItem.Length > 1)
                {
                    expression[lastItemIndex] = lastItem.Remove(lastItem.Length - 1, 1);
                }
                else
                {
                    expression.RemoveAt(lastItemIndex);
                }
            }
            SendExpressionChanged();
        }

        public decimal Equals()
        {
            List<string> RPN = ConvertToRPN();
            decimal result = EvaluateRPN(RPN);

            return result;
        }

        public void Clear()
        {
            expression.Clear();

            SendExpressionChanged();
        }

        public void ClearWithoutVisual()
        {
            expression.Clear();
        }

        private void SendExpressionChanged()
        {
            string expressionAsString = "";

            // Display each section of the expression in the expression text box
            foreach (string item in expression)
            {
                expressionAsString += item;
            }


            if (OnExpressionChanged == null) return;
            OnExpressionChanged(this, new ExpressionChangedEventArgs(expressionAsString));
        }


        private List<string> ConvertToRPN()
        {
            List<string> RPN = new List<string>();

            string poppedOperator;
            CustomStack<string> operators = new CustomStack<string>();
            foreach (string current in expression)
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

        private decimal EvaluateRPN(List<string> RPN)
        {
            CustomStack<decimal> operands = new CustomStack<decimal>();

            foreach (string current in RPN)
            {
                if (current.IsNumeric())
                {
                    operands.Push(decimal.Parse(current));
                }
                else
                {
                    decimal op2 = operands.Pop();
                    decimal op1 = operands.Pop();

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
                        operands.Push((decimal)Math.Pow((double)op1, (double)op2));
                    }
                }
            }
            return operands.Pop();
        }

        private bool IsPrecedenceGreaterOrEqualTo(string firstOperator, string secondOperator)
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


    public class ExpressionChangedEventArgs
    {
        public string Expression { get; private set; }

        public ExpressionChangedEventArgs(string expression) 
        {
            Expression = expression;
        }
    }
}
