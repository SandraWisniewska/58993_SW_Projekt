using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _58993_SW_Projekt
{
    public partial class Math_UC : UserControl
    {
        public Math_UC()
        {
            InitializeComponent();
            calculator = new Calculator();
        }

        private Calculator calculator;


        private void button_num_Click(object sender, EventArgs e)
        {
            Button pressedButton = (Button)sender;
            if (this.calculator.startNewNumber || SW_58993_textBox1.Text.Equals("0"))
            {
                SW_58993_textBox1.Text = "";

            }
            SW_58993_textBox1.Text += pressedButton.Text;
            this.calculator.startNewNumber = false;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (this.calculator.startNewNumber == false)
            {
                this.calculator.num2 = Convert.ToDouble(SW_58993_textBox1.Text);
                SW_58993_label1.Text = String.Empty;
            }
            switch (this.calculator.sign)
            {
                case "+":
                    SW_58993_textBox1.Text = Convert.ToString(this.calculator.add());
                    break;
                case "-":
                    SW_58993_textBox1.Text = Convert.ToString(this.calculator.sub());
                    break;
                case "*":
                    SW_58993_textBox1.Text = Convert.ToString(this.calculator.multi());
                    break;
                case "/":
                    try
                    {
                        SW_58993_textBox1.Text = Convert.ToString(this.calculator.div());

                    }
                    catch (DivideByZeroException)
                    {
                        SW_58993_label1.Text = "Cannot be divided by 0";
                        SW_58993_textBox1.Text = "0";
                    }
                    break;
            }
            this.calculator.startNewNumber = true;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Operation("+");
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            Operation("-");
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Operation("*");
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Operation("/");
        }
        private void Operation(string sign)
        {
            this.calculator.num1 = Convert.ToDouble(SW_58993_textBox1.Text);
            SW_58993_label1.Text = SW_58993_textBox1.Text;
            SW_58993_label1.Text += sign;
            this.calculator.sign = sign;
            this.calculator.startNewNumber = true;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            if (SW_58993_textBox1.Text.Length == 1)
            {
                SW_58993_textBox1.Text = "0";
                this.calculator.num1 = 0;
                this.calculator.num2 = 0;
            }
            else
            {
                SW_58993_textBox1.Text = SW_58993_textBox1.Text.Substring(0, SW_58993_textBox1.Text.Length - 1);
            }
        }

        private void buttonNWW_Click(object sender, EventArgs e)
        {
            string[] nums = SW_58993_textBox1.Text.Split(',');
            if (nums.Length == 2)
            {
                SW_58993_label1.Text = SW_58993_textBox1.Text + " NWW";
                int[] numbers = Array.ConvertAll<string, int>(SW_58993_textBox1.Text.Split(','), int.Parse);
                SW_58993_textBox1.Text = this.calculator.calculate_NWW(numbers[0], numbers[1]).ToString();
            }
            else
            {
                MessageBox.Show("Podaj dwie liczby oddzielone przecinkiem za pomoca klawiatury np. 8,12 i nacisnij NWW");
            }
        }

        private void buttonNWD_Click(object sender, EventArgs e)
        {
            string[] nums = SW_58993_textBox1.Text.Split(',');
            if (nums.Length == 2)
            {
                SW_58993_label1.Text = SW_58993_textBox1.Text + " NWD";
                int[] numbers = Array.ConvertAll<string, int>(SW_58993_textBox1.Text.Split(','), int.Parse);
                SW_58993_textBox1.Text = this.calculator.calculate_NWD(numbers[0], numbers[1]).ToString();
            }
            else
            {
                MessageBox.Show("Podaj dwie liczby oddzielone przecinkiem za pomoca klawiatury np. 8,12 i nacisnij NWD");
            }
        }

        private void SW_58993_buttonComma_Click(object sender, EventArgs e)
        {
            Button pressedButton = (Button)sender;
            if (SW_58993_textBox1.Text.IndexOf(",") == -1)
            {
                SW_58993_textBox1.Text += pressedButton.Text;
            }

        }
    }
}
