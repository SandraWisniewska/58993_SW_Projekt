using System;
using System.Collections.Generic;
using System.Text;

namespace _58993_SW_Projekt
{
    internal class Calculator
    {
        public string sign { set; get; }
        public double num1 { set; get; }
        public double num2 { set; get; }
        public bool startNewNumber { set; get; } = true;
        public bool gcd { set; get; } = false;

        public int calculate_NWD(int num1, int num2)
        {
            int Remainder;

            while (num2 != 0)
            {
                Remainder = num1 % num2;
                num1 = num2;
                num2 = Remainder;
            }

            return num1;
        }
        public int calculate_NWW(int num1, int num2)
        {
            return (num1 / calculate_NWD(num1, num2)) * num2;
        }

        public double add()
        {
            this.num1 = this.num1 + this.num2;
            return this.num1;
        }

        public double sub()
        {
            this.num1 = this.num1 - this.num2;
            return this.num1;
        }

        public double div()
        {
            if (this.num2 == 0)
            {
                throw new DivideByZeroException();
            }
            this.num1 = this.num1 / this.num2;
            return this.num1;
        }

        public double multi()
        {
            this.num1 = this.num1 * this.num2;
            return this.num1;
        }
    }
}
