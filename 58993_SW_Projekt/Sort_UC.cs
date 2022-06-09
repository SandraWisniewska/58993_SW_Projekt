using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace _58993_SW_Projekt
{
    public partial class Sort_UC : UserControl
    {
        private SortAlgorithm Sortowanie;
        public Sort_UC()
        {
            //inicjalizacja klasy do sortowania
            this.Sortowanie = new SortAlgorithm();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arrayInString = this.SW_58993_textBox1.Text;
            //rozdzielenie stringa po przecinku do tablicy int
            int[] arrayToSort = Array.ConvertAll<string, int>(arrayInString.Split(','), Convert.ToInt32);

            //jezeli wybrane jest sortowanie bąbelkowe
            if (this.SW_58993_radioBubble.Checked == true)
            {
                //sortowanie bąbelkowe, a wartość zwracacna przypisana jest do odpowiednich pól
                SortAlgorithm.SortInfo sortInfo = this.Sortowanie.BubbleSort(arrayToSort);
                this.SW_58993_textBox2.Text = string.Join(",", sortInfo.sortedArray);
                this.SW_58993_label4.Text = sortInfo.numberOfSortOperations.ToString();

                this.SW_58993_textBox2.Visible = true;
                this.SW_58993_label2.Visible = true;
                this.SW_58993_label3.Visible = true;
                this.SW_58993_label4.Visible = true;
            }
            //jezeli wybrane jest sortowanie przez wstawianie
            else if (this.SW_58993_radioInsertion.Checked == true)
            {
                //sortowanie przez wstawianie, a wartość zwracacna przypisana jest do odpowiednich pól
                SortAlgorithm.SortInfo sortInfo = this.Sortowanie.InsertionSort(arrayToSort);
                this.SW_58993_textBox2.Text = string.Join(",", sortInfo.sortedArray);
                this.SW_58993_label4.Text = sortInfo.numberOfSortOperations.ToString();

                this.SW_58993_textBox2.Visible = true;
                this.SW_58993_label3.Visible = true;
                this.SW_58993_label4.Visible = true;
            }
        }

        //zdarzenie służące do walidacji pola do wprowania
        private void textBox1_Change(object sender, EventArgs e)
        {
            String value = ((TextBox)sender).Text;
            // wyrażenie regularne sprawdzające czy w polu są tylko
            // liczby oddzielone przecinkiem
            // jeżeli występują nieodpowiednie znaki to:
            if (!Regex.Match(value, "^\\d+(,\\d+)*$").Success)
            {
                //jeżeli w polu do wprowadzania danych są nieodpowiednie znaki
                //deaktywowany jest przycisk do sortowania i pokazywane pole
                //z odpowiednim komunikatem blędu
                label1.Text = "Dopuszczalne są tylko liczby rozdzielone przecinkiem";
                label1.Visible = true;
                SW_58993_button1.Enabled = false;
            }
            else
            {
                //jeżeli w polu do wprowadzania danych są odpowiednie znaki
                //aktywowany jest przycisk do sortowania i czyszczone pole z komunikatem blędu
                label1.Text = "";
                label1.Visible = false;
                SW_58993_button1.Enabled = true;
            }
        }
    }
}
