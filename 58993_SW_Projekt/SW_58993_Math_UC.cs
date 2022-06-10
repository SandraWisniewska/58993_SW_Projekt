using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _58993_SW_Projekt
{
    public partial class SW_58993_Math_UC : UserControl
    {
        public SW_58993_Math_UC()
        {
            InitializeComponent();
            // Inicjalizacja klasy Calculator
            SW_58993_calculator = new SW_58993_Calculator();
        }

        private SW_58993_Calculator SW_58993_calculator;

        //Obsługa klawiszy numerycznych
        private void SW_58993_button_num_Click(object SW_58993_sender, EventArgs SW_58993_e)
        {
            Button SW_58993_pressedButton = (Button)SW_58993_sender;
            // Jezeli jest to pierwsz liczba działania lub pole wynikowe jest 0
            // to przypisz wartosc pustą
            if (this.SW_58993_calculator.SW_58993_startNewNumber || SW_58993_textBox1.Text.Equals("0"))
            {
                SW_58993_textBox1.Text = "";

            }
            // przypisz do pola wynikowego wartość z naciśniętego przycisku
            SW_58993_textBox1.Text += SW_58993_pressedButton.Text;
            // ustawienie zmiennej pomocniczej startNewNumber na false
            this.SW_58993_calculator.SW_58993_startNewNumber = false;
        }

        //zdarzenie po klinieciu przycisku "równa się"
        private void SW_58993_buttonEqual_Click(object SW_58993_sender, EventArgs SW_58993_e)
        {
            if (this.SW_58993_calculator.SW_58993_startNewNumber == false)
            {
                this.SW_58993_calculator.SW_58993_num2 = Convert.ToDouble(SW_58993_textBox1.Text);
                SW_58993_label1.Text = String.Empty;
            }
            // wykonanie odpowiednie operacji matematycznej na podstawie pola sign z Calculator
            switch (this.SW_58993_calculator.SW_58993_sign)
            {
                case "+":
                    SW_58993_textBox1.Text = Convert.ToString(this.SW_58993_calculator.SW_58993_add());
                    break;
                case "-":
                    SW_58993_textBox1.Text = Convert.ToString(this.SW_58993_calculator.SW_58993_sub());
                    break;
                case "*":
                    SW_58993_textBox1.Text = Convert.ToString(this.SW_58993_calculator.SW_58993_multi());
                    break;
                case "/":
                    try
                    {
                        SW_58993_textBox1.Text = Convert.ToString(this.SW_58993_calculator.SW_58993_div());

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
            this.SW_58993_calculator.SW_58993_startNewNumber = true;
        }

        private void SW_58993_buttonAdd_Click(object SW_58993_sender, EventArgs SW_58993_e)
        {
            SW_58993_Operation("+");
        }

        private void SW_58993_buttonSubtract_Click(object SW_58993_sender, EventArgs SW_58993_e)
        {
            SW_58993_Operation("-");
        }

        private void SW_58993_buttonMultiply_Click(object SW_58993_sender, EventArgs SW_58993_e)
        {
            SW_58993_Operation("*");
        }

        private void SW_58993_buttonDivide_Click(object SW_58993_sender, EventArgs SW_58993_e)
        {
            SW_58993_Operation("/");
        }

        //funkcje Operation służy do ustawiania znaku operacji matematycznej
        private void SW_58993_Operation(string SW_58993_sign)
        {
            this.SW_58993_calculator.SW_58993_num1 = Convert.ToDouble(SW_58993_textBox1.Text);
            SW_58993_label1.Text = SW_58993_textBox1.Text;
            SW_58993_label1.Text += SW_58993_sign;
            this.SW_58993_calculator.SW_58993_sign = SW_58993_sign;
            this.SW_58993_calculator.SW_58993_startNewNumber = true;
        }

        private void SW_58993_buttonBack_Click(object SW_58993_sender, EventArgs SW_58993_e)
        {
            //jeżeli przycisk back zostal nacisniety gdy została tylko jedna cyfra
            // wtedy liczby są czyszczone i ustawiane, w polu wyniku, jest zero
            if (SW_58993_textBox1.Text.Length == 1)
            {
                SW_58993_textBox1.Text = "0";
                this.SW_58993_calculator.SW_58993_num1 = 0;
                this.SW_58993_calculator.SW_58993_num2 = 0;
            }
            else
            {
                SW_58993_textBox1.Text = SW_58993_textBox1.Text.Substring(0, SW_58993_textBox1.Text.Length - 1);
            }
        }

        //obsluga przycisku do najmnejszej wspólnej wielokrotności
        private void SW_58993_buttonNWW_Click(object SW_58993_sender, EventArgs SW_58993_e)
        {
            //sprawdzenie czy liczby oddzielone są przecinkiem
            string[] SW_58993_nums = SW_58993_textBox1.Text.Split(',');
            if (SW_58993_nums.Length == 2)
            {
                SW_58993_label1.Text = SW_58993_textBox1.Text + " NWW";
                int[] SW_58993_numbers = Array.ConvertAll<string, int>(SW_58993_textBox1.Text.Split(','), int.Parse);
                SW_58993_textBox1.Text = this.SW_58993_calculator.SW_58993_calculate_NWW(SW_58993_numbers[0], SW_58993_numbers[1]).ToString();
            }
            else
            {
                MessageBox.Show("Podaj dwie liczby oddzielone przecinkiem za pomoca klawiatury np. 8,12 i nacisnij NWW");
            }
        }

        //obsługa przycisku do najwiekszego wspólnego dzielnika
        private void SW_58993_buttonNWD_Click(object SW_58993_sender, EventArgs SW_58993_e)
        {
            string[] SW_58993_nums = SW_58993_textBox1.Text.Split(',');
            //sprawdzenie czy liczby oddzielone są przecinkiem
            if (SW_58993_nums.Length == 2)
            {
                SW_58993_label1.Text = SW_58993_textBox1.Text + " NWD";
                int[] SW_58993_numbers = Array.ConvertAll<string, int>(SW_58993_textBox1.Text.Split(','), int.Parse);
                SW_58993_textBox1.Text = this.SW_58993_calculator.SW_58993_calculate_NWD(SW_58993_numbers[0], SW_58993_numbers[1]).ToString();
            }
            else
            {
                MessageBox.Show("Podaj dwie liczby oddzielone przecinkiem za pomoca klawiatury np. 8,12 i nacisnij NWD");
            }
        }

        private void SW_58993_buttonComma_Click(object SW_58993_sender, EventArgs SW_58993_e)
        {
            Button SW_58993_pressedButton = (Button)SW_58993_sender;
            if (SW_58993_textBox1.Text.IndexOf(",") == -1)
            {
                SW_58993_textBox1.Text += SW_58993_pressedButton.Text;
            }

        }
    }
}
