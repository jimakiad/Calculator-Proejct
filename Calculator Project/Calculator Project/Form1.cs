namespace Calculator_Project
{
    public partial class Form1 : Form
    {
        public string currentOperation { get; private set; }
        public double currentValue { get; private set; }
        public double previousResult;
        private double previousValue = 0; // variable to store previous value
        private string previousOperation = ""; // variable to store previous operation
        private double result = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";

        }

        private void btnNum0_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
            txtHistory.Text += btn.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
            txtHistory.Text += btn.Text;
        }

        private void btnNum2_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
            txtHistory.Text += btn.Text;
        }

        private void btnNum3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
            txtHistory.Text += btn.Text;
        }

        private void btnNum4_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
            txtHistory.Text += btn.Text;
        }

        private void btnNum5_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
            txtHistory.Text += btn.Text;
        }

        private void btnNum6_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
            txtHistory.Text += btn.Text;
        }

        private void btnNum7_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
            txtHistory.Text += btn.Text;
        }

        private void btnNum8_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
            txtHistory.Text += btn.Text;
        }

        private void btnNum9_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (txtDisplay.Text == "0")
            {
                txtDisplay.Text = btn.Text;
            }
            else
            {
                txtDisplay.Text += btn.Text;
            }
            txtHistory.Text += btn.Text;
        }

        private void btnOperationPlus_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string operation = btn.Text;
            currentOperation = operation;
            currentValue = double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
            txtHistory.Text += currentOperation;

        }

        private void btnOperationMinus_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string operation = btn.Text;
            currentOperation = operation;
            currentValue = double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
            txtHistory.Text += currentOperation;

        }

        private void btnOperationMultiply_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string operation = btn.Text;
            currentOperation = operation;
            currentValue = double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
            txtHistory.Text += currentOperation;

        }

        private void btnOperationDivide_Click(object sender, EventArgs e)

        {
            Button btn = (Button)sender;
            string operation = btn.Text;
            currentOperation = operation;
            currentValue = double.Parse(txtDisplay.Text);
            txtDisplay.Text = "0";
            txtHistory.Text += currentOperation;

        }

        private void btnOperationEqual_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            string operation = btn.Text;

            {
                // Perform the current operation with the stored value and the current value
                switch (currentOperation)
                {
                    case "+":
                        result = currentValue + double.Parse(txtDisplay.Text);
                        break;
                    case "-":
                        result = currentValue - double.Parse(txtDisplay.Text);
                        break;
                    case "*":
                        result = currentValue * double.Parse(txtDisplay.Text);
                        break;
                    case "/":
                        result = currentValue / double.Parse(txtDisplay.Text);
                        break;
                    default:
                        // If currentOperation is not a valid operator, just return
                        return;
                }
                previousValue = double.Parse(txtDisplay.Text);
                txtDisplay.Text = result.ToString();
            }

            if (previousResult == 0)
            {
                txtHistory.Text += Environment.NewLine + " " + "=" + " " + result;
            }
            else
            {
                txtHistory.Text += Environment.NewLine + previousResult + " " + currentOperation + " " + previousValue + " = " + result.ToString();
            }

            previousResult = result; // store the result for future use
            currentOperation = "=";
        }




        private void btnClear_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(txtDisplay.Text);
            txtDisplay.Text = (-currentValue).ToString();

        }

        private void btnDecimal_Click(object sender, EventArgs e)
        {
            // Check if the current value in the textbox already contains a decimal point
            if (!txtDisplay.Text.Contains("."))
            {
                txtDisplay.Text += ".";
                txtHistory.Text += ".";
            }

        }

        private void btnBackspace_Click(object sender, EventArgs e)
        {
            if (txtDisplay.Text.Length > 0)
            {
                txtDisplay.Text = txtDisplay.Text.Substring(0, txtDisplay.Text.Length - 1);
                txtHistory.Text = txtHistory.Text.Substring(0, txtHistory.Text.Length - 1);
            }
        }

        private void btnReciprocal_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(txtDisplay.Text);
            double reciprocalValue = 1.0 / currentValue;
            txtDisplay.Text = reciprocalValue.ToString();
            txtHistory.Text += Environment.NewLine + "reciprocal(" + currentValue.ToString() + ") = " + txtDisplay.Text ;
            result = reciprocalValue;
            previousValue = currentValue;
            return;
        }

        private void btnSquare_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(txtDisplay.Text);
            double squaredValue = currentValue * currentValue;
            txtDisplay.Text = squaredValue.ToString();
            txtHistory.Text += Environment.NewLine + "square(" + currentValue.ToString() + ") = " + squaredValue.ToString() ;
            result = squaredValue;
            previousValue = currentValue;
            return;
        }

        private void txtDisplay_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSquareRoot_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(txtDisplay.Text);
            double squareRootValue = Math.Sqrt(currentValue);
            txtDisplay.Text = squareRootValue.ToString();
            txtHistory.Text += Environment.NewLine + "√(" + currentValue.ToString() + ") = " + squareRootValue.ToString() ;
            result = squareRootValue;
            previousValue = currentValue;
            return;
        }

        private void btnPercentage_Click(object sender, EventArgs e)
        {
            double currentValue = double.Parse(txtDisplay.Text);
            double percentageValue = currentValue / 100.0;
            txtDisplay.Text = percentageValue.ToString();
            txtHistory.Text += Environment.NewLine + currentValue.ToString() + "% = " + percentageValue.ToString() ;
            result = percentageValue;
            previousValue = currentValue;
            return;
        }

        private void btnClearEntry_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "0";
            txtHistory.Text = "";
            previousResult = 0;
        }

    }
}
