using System;
using System.Collections.Generic;
using System.Text;

namespace _58993_SW_Projekt
{
    internal class SW_58993_Calculator
    {
        public string SW_58993_sign { set; get; }
        public double SW_58993_num1 { set; get; }
        public double SW_58993_num2 { set; get; }
        public bool SW_58993_startNewNumber { set; get; } = true;
        public bool SW_58993_gcd { set; get; } = false;

        public int SW_58993_calculate_NWD(int SW_58993_num1, int SW_58993_num2)
        {
            int SW_58993_Remainder;

            while (SW_58993_num2 != 0)
            {
                SW_58993_Remainder = SW_58993_num1 % SW_58993_num2;
                SW_58993_num1 = SW_58993_num2;
                SW_58993_num2 = SW_58993_Remainder;
            }

            return SW_58993_num1;
        }
        public int SW_58993_calculate_NWW(int SW_58993_num1, int SW_58993_num2)
        {
            return (SW_58993_num1 / SW_58993_calculate_NWD(SW_58993_num1, SW_58993_num2)) * SW_58993_num2;
        }

        public double SW_58993_add()
        {
            this.SW_58993_num1 = this.SW_58993_num1 + this.SW_58993_num2;
            return this.SW_58993_num1;
        }

        public double SW_58993_sub()
        {
            this.SW_58993_num1 = this.SW_58993_num1 - this.SW_58993_num2;
            return this.SW_58993_num1;
        }

        public double SW_58993_div()
        {
            if (this.SW_58993_num2 == 0)
            {
                throw new DivideByZeroException();
            }
            this.SW_58993_num1 = this.SW_58993_num1 / this.SW_58993_num2;
            return this.SW_58993_num1;
        }

        public double SW_58993_multi()
        {
            this.SW_58993_num1 = this.SW_58993_num1 * this.SW_58993_num2;
            return this.SW_58993_num1;
        }
    }
}
