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
    public partial class SW_58993_Sort_UC : UserControl
    {
        private SW_58993_SortAlgorithm SW_58993_Sortowanie;
        public SW_58993_Sort_UC()
        {
            //inicjalizacja klasy do sortowania
            this.SW_58993_Sortowanie = new SW_58993_SortAlgorithm();
            InitializeComponent();
        }

        private void SW_58993_button1_Click(object SW_58993_sender, EventArgs SW_58993_e)
        {
            string SW_58993_arrayInString = this.SW_58993_textBox1.Text;
            //rozdzielenie stringa po przecinku do tablicy int
            int[] SW_58993_arrayToSort = Array.ConvertAll<string, int>(SW_58993_arrayInString.Split(','), Convert.ToInt32);

            //jezeli wybrane jest sortowanie bąbelkowe
            if (this.SW_58993_radioBubble.Checked == true)
            {
                //sortowanie bąbelkowe, a wartość zwracana przypisana jest do odpowiednich pól
                SW_58993_SortAlgorithm.SW_58993_SortInfo SW_58993_sortInfo = this.SW_58993_Sortowanie.SW_58993_BubbleSort(SW_58993_arrayToSort);
                this.SW_58993_textBox2.Text = string.Join(",", SW_58993_sortInfo.SW_58993_sortedArray);
                this.SW_58993_label4.Text = SW_58993_sortInfo.SW_58993_numberOfSortOperations.ToString();

                this.SW_58993_textBox2.Visible = true;
                this.SW_58993_label2.Visible = true;
                this.SW_58993_label3.Visible = true;
                this.SW_58993_label4.Visible = true;
            }
            //jezeli wybrane jest sortowanie przez wstawianie
            else if (this.SW_58993_radioInsertion.Checked == true)
            {
                //sortowanie przez wstawianie, a wartość zwracana przypisana jest do odpowiednich pól
                SW_58993_SortAlgorithm.SW_58993_SortInfo SW_58993_sortInfo = this.SW_58993_Sortowanie.SW_58993_InsertionSort(SW_58993_arrayToSort);
                this.SW_58993_textBox2.Text = string.Join(",", SW_58993_sortInfo.SW_58993_sortedArray);
                this.SW_58993_label4.Text = SW_58993_sortInfo.SW_58993_numberOfSortOperations.ToString();

                this.SW_58993_textBox2.Visible = true;
                this.SW_58993_label3.Visible = true;
                this.SW_58993_label4.Visible = true;
            }
        }

        //zdarzenie służące do walidacji pola do wprowadzania
        private void SW_58993_textBox1_Change(object SW_58993_sender, EventArgs SW_58993_e)
        {
            String SW_58993_value = ((TextBox)SW_58993_sender).Text;
            // wyrażenie regularne sprawdzające czy w polu są tylko
            // liczby oddzielone przecinkiem
            // jeżeli występują nieodpowiednie znaki to:
            if (!Regex.Match(SW_58993_value, "^\\d+(,\\d+)*$").Success)
            {
                //jeżeli w polu do wprowadzania danych są nieodpowiednie znaki
                //deaktywowany jest przycisk do sortowania i pokazywane pole
                //z odpowiednim komunikatem blędu
                SW_58993_label.Text = "Dopuszczalne są tylko liczby rozdzielone przecinkiem";
                SW_58993_label.Visible = true;
                SW_58993_button1.Enabled = false;
            }
            else
            {
                //jeżeli w polu do wprowadzania danych są odpowiednie znaki
                //aktywowany jest przycisk do sortowania i czyszczone pole z komunikatem blędu
                SW_58993_label.Text = "";
                SW_58993_label.Visible = false;
                SW_58993_button1.Enabled = true;
            }
        }
    }
}
