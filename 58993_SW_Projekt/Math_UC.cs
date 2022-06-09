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
            // Inicjalizacja klasy Calculator
            calculator = new Calculator();
        }

        private Calculator calculator;

        //Obsługa klawiszy numerycznych
        private void button_num_Click(object sender, EventArgs e)
        {
            Button pressedButton = (Button)sender;
            // Jezeli jest to pierwsz liczba działania lub pole wynikowe jest 0
            // to przypisz wartosc pustą
            if (this.calculator.startNewNumber || SW_58993_textBox1.Text.Equals("0"))
            {
                SW_58993_textBox1.Text = "";

            }
            // przypisz do pola wynikowego wartość z naciśniętego przycisku
            SW_58993_textBox1.Text += pressedButton.Text;
            // ustawienie zmiennej pomocniczej startNewNumber na false
            this.calculator.startNewNumber = false;
        }

        //zdarzenie po klinieciu przycisku "równa się"
        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (this.calculator.startNewNumber == false)
            {
                this.calculator.num2 = Convert.ToDouble(SW_58993_textBox1.Text);
                SW_58993_label1.Text = String.Empty;
            }
            // wykonanie odpowiednie operacji matematycznej na podstawie pola sign z Calculator
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
                    //Obsługa wyjątku dzielenia przez zero
                    catch (DivideByZeroException)
                    {
                        // ustawienie odpowiednich komunikatow dzielenia przez zero
                        SW_58993_label1.Text = "Cannot be divided by 0";
                        SW_58993_textBox1.Text = "0";
                    }
                    break;
            }
            // po wykonaniu operacji matematycznej ustawienie zmiennej pomocniczej na true
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

        //funkcje Operation służy do ustawiania znaku operacji matematycznej
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
            //jeżeli przycisk back zostal nacisniety gdy została tylko jedna cyfra
            // wtedy liczby są czyszczone i ustawiane, w polu wyniku, jest zero
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

        //obsluga przycisku do najmnejszej wspólnej wielokrotności
        private void buttonNWW_Click(object sender, EventArgs e)
        {
            //sprawdzenie czy liczby oddzielone są przecinkiem
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

        //obsługa przycisku do najwiekszego wspólnego dzielnika
        private void buttonNWD_Click(object sender, EventArgs e)
        {
            string[] nums = SW_58993_textBox1.Text.Split(',');
            //sprawdzenie czy liczby oddzielone są przecinkiem
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
