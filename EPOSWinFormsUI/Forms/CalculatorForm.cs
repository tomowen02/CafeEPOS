using EPOSLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EPOSWinFormsUI.Forms
{
    public partial class CalculatorForm : Form
    {
        // TODO - Fix scaling
        // TODO - Fix negative at begining

        static List<string> expression = new List<string>();

        public CalculatorForm()
        {
            InitializeComponent();
        }
        
        private void DrawExpression()
        {
            ExpressionTextBox.Text = "";

            foreach (string item in expression)
            {
                ExpressionTextBox.Text += item;
            }
        }

        private void AppendDigit(string newItem)
        {
            if (expression.Count == 1)
            {
                if ((expression.First().Contains("+") | expression.First().Contains("-")) & newItem.IsNumeric())
                {
                    // The new digit is still part of the last operand. Concatenate them together
                    expression[expression.Count - 1] += newItem;
                }
                else
                {
                    expression.Add(newItem);
                }
            }
            else if (expression.Count > 0)
            {
                string lastValue = expression.Last();

                // If the last item IN THE LIST is a number and so is the new digit
                if (lastValue.IsNumeric() & newItem.IsNumeric())
                {
                    // The new digit is still part of the last operand. Concatenate them together
                    expression[expression.Count - 1] += newItem;
                }
                else
                {
                    // This is a new operator or operand
                    expression.Add(newItem);
                }
            }
            else
            {
                // This is the first operand
                expression.Add(newItem);
            }

            DrawExpression();
        }


        #region Control buttons events
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            List<string> rpn = Calculator.ConvertToRPN(expression);
            int result = Calculator.EvaluateRPN(rpn);
            expression.Clear();
            ResultTextbox.Text = result.ToString();
            Console.WriteLine(result);
        }

        private void ACButton_Click(object sender, EventArgs e)
        {
            expression.Clear();
            DrawExpression();
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            expression.RemoveAt(expression.Count - 1);
            DrawExpression();
        }
        #endregion


        #region Operator events
        private void OpenBacketsButton_Click(object sender, EventArgs e)
        {
            AppendDigit("(");
        }

        private void CloseBacketsButton_Click(object sender, EventArgs e)
        {
            AppendDigit(")");
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            AppendDigit("^");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            AppendDigit("*");
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            AppendDigit("/");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AppendDigit("+");
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            AppendDigit("-");
        }
        #endregion


        #region Digit events
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            AppendDigit("0");
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            AppendDigit("1");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            AppendDigit("2");
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            AppendDigit("3");
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            AppendDigit("4");
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            AppendDigit("5");
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            AppendDigit("6");
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            AppendDigit("7");
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            AppendDigit("8");
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            AppendDigit("9");
        }
        #endregion

        private void DecimalButton_Click(object sender, EventArgs e)
        {

        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
