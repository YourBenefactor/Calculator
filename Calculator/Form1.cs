using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private const int maxSignCount = 21;

        private List<double> allNumbers;
        private List<string> allOperations;
        private float startFontSize;
        private bool locked, endOfExample;

        public Form1()
        {
            InitializeComponent();
            SetDefaults();
            startFontSize = Output.Font.Size;
            locked = true; endOfExample = false;
        }

        private void SetDefaults()
        {
            Output.Text = "0";
            UpdateStates(true, false);
            allNumbers = new List<double>();
            allOperations = new List<string>();
        }

        private void PrintNumberOrOperation(object sender, EventArgs e)
        {
            if (endOfExample) SetSolutionAsValue();
            else if (Output.Text.Length == maxSignCount) return;

            Button button = (Button)sender;
            string sign = button.Text;
            if (Output.Text == "0" & !IsMathematicalSign(sign))
            {
                Output.Text = sign;
                UpdateStates(false, false);
            }
            else if (IsMathematicalSign(sign))
            {
                if (!locked && Output.Text.Length + 3 < maxSignCount)
                {
                    Output.Text += " " + sign + " ";
                    UpdateStates(true, false);
                }
            }
            else
            {
                Output.Text += sign;
                UpdateStates(false, false);
            }

            UpdateFontScale();
        }

        private void PrintСomma(object sender, EventArgs e)
        {
            if (locked && Output.Text != "0") return;
            Button button = (Button)sender;
            string sign = button.Text;
            Output.Text += sign;
        }

        private void AdvancedOperation(object sender, EventArgs e)
        {
            if (Output.Text[Output.Text.Length - 1] == ' ') return;
            if (endOfExample) SetSolutionAsValue();
            else if (Output.Text.Length == maxSignCount) return;

            Button button = (Button)sender;
            string sign = button.Text;

            int indexOfLastSign = GetIndexOfLastSign(Output.Text);
            int indexOfStartNumber = GetIndexOfStartNumber(Output.Text, indexOfLastSign);
            int length = indexOfLastSign - indexOfStartNumber + 1;

            string line = Output.Text.Substring(indexOfStartNumber, length);
            double number = double.Parse(line);
            Output.Text = Output.Text.Substring(0, indexOfStartNumber);

            switch (sign)
            {
                case "x²":
                    number = Math.Pow(number, 2);
                    break;
                case "1/x":
                    number = 1 / number;
                    break;
                case "√":
                    number = Math.Sqrt(number);
                    break;
            }

            Output.Text += number;
            UpdateStates(locked, false);
        }

        private void Calculate(object sender, EventArgs e)
        {
            if (locked || endOfExample) return;
            ReadNumbersAndOperations();
            PerformPriorityOperations();
            PerformBasicOperations();
            UpdateFontScale();
            UpdateStates(false, true);
        }

        private void ReadNumbersAndOperations()
        {
            string example = Output.Text;
            while (example.Length > 0)
            {
                int indexOfLastSign = GetIndexOfLastSign(example);
                int indexOfStartNumber = GetIndexOfStartNumber(example, indexOfLastSign);
                int length = indexOfLastSign - indexOfStartNumber + 1;
                string line = example.Substring(indexOfStartNumber, length);
                if (IsMathematicalSign(line)) allOperations.Add(line);
                else allNumbers.Add(double.Parse(line));
                example = example.Substring(0, indexOfStartNumber);
            }
            allOperations.Reverse(); allNumbers.Reverse();
        }

        private void PerformPriorityOperations()
        {
            for (int i = 0; i < allOperations.Count && i >= 0; i++)
            {
                if (IsPriorityOperation(allOperations[i]))
                {
                    double a = allNumbers[i]; double b = allNumbers[i + 1];
                    allNumbers[i] = PerformOperation(a, b, allOperations[i]);
                    allNumbers.RemoveAt(i + 1);
                    allOperations.RemoveAt(i);
                    i--;
                }
            }
        }

        private void PerformBasicOperations()
        {
            for (int i = 0; i < allOperations.Count && i >= 0; i++)
            {
                double a = allNumbers[i]; double b = allNumbers[i + 1];
                allNumbers[i] = PerformOperation(a, b, allOperations[i]);
                allNumbers.RemoveAt(i + 1);
                allOperations.RemoveAt(i);
                i--;
            }
            Output.Text += $" = {allNumbers[0]}";
        }

        private double PerformOperation(double a, double b, string operation)
        {
            switch (operation)
            {
                case "%":
                    return a * b / 100;
                case "×":
                    return a * b;
                case "÷":
                    return a / b;
                case "-":
                    return a - b;
                case "+":
                    return a + b;
            }
            throw new Exception("Данная операция недоступна!");
        }

        private void InvertSign(object sender, EventArgs e)
        {
            if (Output.Text == "0") return;
            int indexOfLastSign = GetIndexOfLastSign(Output.Text);
            int indexOfStartNumber = GetIndexOfStartNumber(Output.Text, indexOfLastSign);
            int length = indexOfLastSign - indexOfStartNumber + 1;
            string line = Output.Text.Substring(indexOfStartNumber, length);
            double number;
            if (IsMathematicalSign(line))
            {
                DeleteLastSign(sender, e);
                Output.Text += "-";
            }
            else if (double.TryParse(line, out number))
            {
                Output.Text = Output.Text.Substring(0, indexOfStartNumber);
                Output.Text += (-number).ToString();
            }
        }

        private void DeleteLastSign(object sender, EventArgs e)
        {
            if (Output.Text == "0") return;
            int indexOfLastSign = GetIndexOfLastSign(Output.Text);
            if (indexOfLastSign - 1 >= 0 && Output.Text[indexOfLastSign-1] == ' ') indexOfLastSign--;
            Output.Text = Output.Text.Substring(0, indexOfLastSign);
            if (String.IsNullOrEmpty(Output.Text)) ClearCalculations(sender, e);
        }

        private void ClearCalculations(object sender, EventArgs e)
        {
            SetDefaults();
            Output.Font = new System.Drawing.Font(Output.Font.FontFamily, startFontSize);
        }

        private void SetSolutionAsValue()
        {
            int indexOfLastSign = GetIndexOfLastSign(Output.Text);
            int indexOfStartNumber = GetIndexOfStartNumber(Output.Text, indexOfLastSign);
            int length = indexOfLastSign - indexOfStartNumber + 1;
            string line = Output.Text.Substring(indexOfStartNumber, length);
            Output.Text = line;
        }

        private void UpdateFontScale()
        {
            while (GetMaxLength(Output) < Output.Text.Length)
                Output.Font = new System.Drawing.Font(Output.Font.FontFamily, Output.Font.Size - 0.01f);
        }

        private void UpdateStates(bool locked, bool endOfExample)
        {
            this.locked = locked;
            this.endOfExample = endOfExample;
        }

        private int GetIndexOfLastSign(string example)
        {
            int startIndex = example.Length - 1;
            for (int i = startIndex; i >= 0; i--)
            {
                if (example[i] != ' ') return i;
            }
            return 0;
        }

        private int GetIndexOfStartNumber(string example, int indexOfLastSign)
        {
            int startIndex = indexOfLastSign;
            for (int i = startIndex; i >= 0; i--)
            {
                if (example[i] == ' ') return i+1;
            }
            return 0;
        }

        private bool IsMathematicalSign(string line)
        {
            return line.Equals("%") || line.Equals("×") || line.Equals("÷") || line.Equals("-") || line.Equals("+");
        }

        private bool IsPriorityOperation(string operation)
        {
            return operation.Equals("%") || operation.Equals("×") || operation.Equals("÷");
        }

        private int GetMaxLength(TextBox textBox)
        {
            return (int)(textBox.Width / textBox.Font.Size);
        }
    }
}
