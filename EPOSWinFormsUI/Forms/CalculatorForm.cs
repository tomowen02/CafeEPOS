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
        private Calculator calculator = new Calculator();

        public CalculatorForm()
        {
            InitializeComponent();

            calculator.OnExpressionChanged += new Calculator.ExpressionChangedEvent(ExpressionChanged);
        }

        // ExpressionChangedEvent raised by Calculator
        private void ExpressionChanged(object sender, ExpressionChangedEventArgs e)
        {
            ExpressionTextBox.Text = "";

            ExpressionTextBox.Text = e.Expression;

            ResultTextbox.Text = "";
        }


        #region Control buttons events
        private void EqualsButton_Click(object sender, EventArgs e)
        {
            if (ExpressionTextBox.Text != "")
            {
                try
                {
                    // Display the evaluated result to the user
                    ResultTextbox.Text = calculator.Equals().ToString();

                    // Clear the contents of the expression without clearing the textbox
                    calculator.ClearWithoutVisual();
                }
                catch (Exception)
                {
                    ExpressionTextBox.Text = "Invalid syntax";
                    calculator.ClearWithoutVisual();
                }
            }
        }

        private void ACButton_Click(object sender, EventArgs e)
        {
            calculator.Clear();
            ResultTextbox.Text = "";
        }

        private void DelButton_Click(object sender, EventArgs e)
        {
            calculator.Del();
        }
        #endregion


        #region Operator events
        private void OpenBacketsButton_Click(object sender, EventArgs e)
        {
            calculator.AddOperand("(");
        }

        private void CloseBacketsButton_Click(object sender, EventArgs e)
        {
            calculator.AddOperand(")");
        }

        private void PowerButton_Click(object sender, EventArgs e)
        {
            calculator.AddOperand("^");
        }

        private void MultiplyButton_Click(object sender, EventArgs e)
        {
            calculator.AddOperand("*");
        }

        private void DivideButton_Click(object sender, EventArgs e)
        {
            calculator.AddOperand("/");
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            calculator.AddOperand("+");
        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            calculator.AddOperand("-");
        }
        #endregion


        #region Operand events
        private void ZeroButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("0");
        }

        private void OneButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("1");
        }

        private void TwoButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("2");
        }

        private void ThreeButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("3");
        }

        private void FourButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("4");
        }

        private void FiveButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("5");
        }

        private void SixButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("6");
        }

        private void SevenButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("7");
        }

        private void EightButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("8");
        }

        private void NineButton_Click(object sender, EventArgs e)
        {
            calculator.AddDigit("9");
        }
        #endregion

        private void DecimalButton_Click(object sender, EventArgs e)
        {
            calculator.AddDecimal();
        }

        private void CloseFormButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
