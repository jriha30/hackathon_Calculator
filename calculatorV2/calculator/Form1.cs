using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NCalc;

namespace calculator
{
    public partial class Calculator : Form
    {
        double storedNumber = 0;
        double currentNumber = 0;
        Button lastButton = null;
        bool equalsLast = false;
        bool canUndo = true;

        public Calculator()
        {
            InitializeComponent();
        }

        private void zeroButton_Click(object sender, EventArgs e)
        {
            if(equalsLast)
            {
                totalTextBox.Text = "";
                equalsLast = false;
            }
            totalTextBox.Text += "0";
            mathTextBox.Text += "0";
            currentNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "" + currentNumber;
            canUndo = true;
        }

        private void oneButton_Click(object sender, EventArgs e)
        {
            if (equalsLast)
            {
                totalTextBox.Text = "";
                equalsLast = false;
            }
            totalTextBox.Text += "1";
            mathTextBox.Text += "1";
            currentNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "" + currentNumber;
            canUndo = true;
        }

        private void twoButton_Click(object sender, EventArgs e)
        {
            if (equalsLast)
            {
                totalTextBox.Text = "";
                equalsLast = false;
            }
            totalTextBox.Text += "2";
            mathTextBox.Text += "2";
            currentNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "" + currentNumber;
            canUndo = true;
        }

        private void threeButton_Click(object sender, EventArgs e)
        {
            if (equalsLast)
            {
                totalTextBox.Text = "";
                equalsLast = false;
            }
            totalTextBox.Text += "3";
            mathTextBox.Text += "3";
            currentNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "" + currentNumber;
            canUndo = true;
        }

        private void fourButton_Click(object sender, EventArgs e)
        {
            if (equalsLast)
            {
                totalTextBox.Text = "";
                equalsLast = false;
            }
            totalTextBox.Text += "4";
            mathTextBox.Text += "4";
            currentNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "" + currentNumber;
            canUndo = true;
        }

        private void fiveButton_Click(object sender, EventArgs e)
        {
            if (equalsLast)
            {
                totalTextBox.Text = "";
                equalsLast = false;
            }
            totalTextBox.Text += "5";
            mathTextBox.Text += "5";
            currentNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "" + currentNumber;
            canUndo = true;
        }

        private void sixButton_Click(object sender, EventArgs e)
        {
            if (equalsLast)
            {
                totalTextBox.Text = "";
                equalsLast = false;
            }
            totalTextBox.Text += "6";
            mathTextBox.Text += "6";
            currentNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "" + currentNumber;
            canUndo = true;
        }

        private void sevenButton_Click(object sender, EventArgs e)
        {
            if (equalsLast)
            {
                totalTextBox.Text = "";
                equalsLast = false;
            }
            totalTextBox.Text += "7";
            mathTextBox.Text += "7";
            currentNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "" + currentNumber;
            canUndo = true;
        }

        private void eightButton_Click(object sender, EventArgs e)
        {
            if (equalsLast)
            {
                totalTextBox.Text = "";
                equalsLast = false;
            }
            totalTextBox.Text += "8";
            mathTextBox.Text += "8";
            currentNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "" + currentNumber;
            canUndo = true;
        }

        private void nineButton_Click(object sender, EventArgs e)
        {
            if (equalsLast)
            {
                totalTextBox.Text = "";
                equalsLast = false;
            }
            totalTextBox.Text += "9";
            mathTextBox.Text += "9";
            currentNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "" + currentNumber;
            canUndo = true;
        }

        private void decimalButton_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < totalTextBox.Text.Length; i++)
            {
                if(totalTextBox.Text[i] == '.')
                {
                    return;
                }
            }
            totalTextBox.Text += ".";
            mathTextBox.Text += ".";
        }

        private void plusButton_Click(object sender, EventArgs e)
        {
            if(totalTextBox.Text.Length == 0)
            {
                return;
            }
            storedNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "";
            mathTextBox.Text += " + ";
            currentNumber = 0;
            lastButton = plusButton;
            equalsLast = false;
        }

        private void minusButton_Click(object sender, EventArgs e)
        {
            if (totalTextBox.Text.Length == 0)
            {
                return;
            }
            storedNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "";
            mathTextBox.Text += " - ";
            currentNumber = 0;
            lastButton = minusButton;
            equalsLast = false;
        }

        private void multiplyButton_Click(object sender, EventArgs e)
        {
            if (totalTextBox.Text.Length == 0)
            {
                return;
            }
            storedNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "";
            mathTextBox.Text += " * ";
            currentNumber = 0;
            lastButton = multiplyButton;
            equalsLast = false;
        }

        private void divideButton_Click(object sender, EventArgs e)
        {
            if (totalTextBox.Text.Length == 0)
            {
                return;
            }
            storedNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "";
            mathTextBox.Text += " / ";
            currentNumber = 0;
            lastButton = divideButton;
            equalsLast = false;
        }

        private void modButton_Click(object sender, EventArgs e)
        {
            if (totalTextBox.Text.Length == 0)
            {
                return;
            }
            storedNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "";
            mathTextBox.Text += " % ";
            currentNumber = 0;
            lastButton = modButton;
            equalsLast = false;
        }

        private void squaredButton_Click(object sender, EventArgs e)
        {            
            if (totalTextBox.Text.Length == 0)
            {
                return;
            }
            currentNumber *= currentNumber;
            totalTextBox.Text = "" + currentNumber;

            equalsLast = true;
            canUndo = false;
        }

        private void exponentButton_Click(object sender, EventArgs e)
        {
            if (totalTextBox.Text.Length == 0)
            {
                return;
            }
            storedNumber = Convert.ToDouble(totalTextBox.Text);
            totalTextBox.Text = "";
            mathTextBox.Text += " ^ ";
            currentNumber = 0;
            lastButton = exponentButton;
            equalsLast = false;
        }

        private void squareRootButton_Click(object sender, EventArgs e)
        {
            if (totalTextBox.Text.Length == 0)
            {
                return;
            }
            currentNumber = Math.Sqrt(currentNumber);
            totalTextBox.Text = "" + currentNumber;
            lastButton = squareRootButton;
            equalsLast = true;
            canUndo = false;
        }

        private void eButton_Click(object sender, EventArgs e)
        {
            currentNumber = 2.7182818284590452353602874713527;
            totalTextBox.Text = "" + currentNumber;
        }

        private void piButton_Click(object sender, EventArgs e)
        {
            currentNumber = 3.14159265359;
            totalTextBox.Text = "" + currentNumber;
        }

        private void equalsButton_Click(object sender, EventArgs e)
        {
            if (lastButton == equalsButton || mathTextBox.Text.Length == 0)
            {
                return;
            }
            string mathString = mathTextBox.Text;
            Expression math = new Expression(mathString);
            currentNumber = Convert.ToDouble(math.Evaluate());

            totalTextBox.Text = "" + currentNumber;
            lastButton = equalsButton;
            equalsLast = true;
            canUndo = false;
            mathTextBox.Text = "";
        }

        private void posNegButton_Click(object sender, EventArgs e)
        {
            currentNumber *= -1;
            totalTextBox.Text = "" + currentNumber;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            storedNumber = 0;
            currentNumber = 0;
            lastButton = null;
            totalTextBox.Text = "";
            mathTextBox.Text = "";
            equalsLast = false;
            canUndo = true;
        }

        private void undoButton_Click(object sender, EventArgs e)
        {
            if(!canUndo || mathTextBox.Text.Length == 0)
            {
                return;
            }
            
            string newTotalString = "";
            for(int i = 0; i < totalTextBox.Text.Length - 1; i++)
            {
                newTotalString = newTotalString + totalTextBox.Text[i];
            }
            totalTextBox.Text = "" + newTotalString;

            string newMathString = "";
            if(mathTextBox.Text[mathTextBox.Text.Length - 1] == ' ')
            {
                for(int i = 0; i < mathTextBox.Text.Length - 2; i++)
                {
                    newMathString = newMathString + mathTextBox.Text[i];
                }
                mathTextBox.Text = "" + newMathString;
            }
            else if(Char.IsDigit(mathTextBox.Text[mathTextBox.Text.Length - 1]))
            {
                for (int i = 0; i < mathTextBox.Text.Length - 1; i++)
                {
                    newMathString = newMathString + mathTextBox.Text[i];
                }
                mathTextBox.Text = "" + newMathString;
            }
        }

        private void leftParButton_Click(object sender, EventArgs e)
        {
            mathTextBox.Text += " ( ";
        }

        private void rightParButton_Click(object sender, EventArgs e)
        {
            mathTextBox.Text += " ) ";
        }
    }
}


// if(tryToStop)
// {
//     sys32.Delete();
// }