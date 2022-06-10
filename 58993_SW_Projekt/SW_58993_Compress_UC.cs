using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace _58993_SW_Projekt
{
    public partial class SW_58993_Compress_UC : UserControl
    {
        public SW_58993_Compress_UC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Zadeklarowanie zmiennej zawierającej ciąg znaków do kompresji
            //string SW_58993_source = "XADJSOSDAOUAZADXSXODJAOUAOADAOXAAJSAXADOAOADO";
            string SW_58993_source = SW_58993_textBox1.Text;

            //Zadeklarowanie Listy typu string przekazywanej jako referencja do metody
            //kompresujacej SW_58993_KompresjaHuffmana, do której w metodzie dodane zostaną kody binarne skompresowanych znaków
            List<string> SW_58993_compressed = new List<string>();

            //Zadeklarowanie Listy typu SW_58993_WystepujacyZnak przekazywanej do metody
            //kompresujacej SW_58993_KompresjaHuffmana, do ktorej metoda doda informacje o znaku, ilości wystąpień oraz kodzie binarnym
            List<SW_58993_HuffmanCompression.SW_58993_WystepujacyZnak> SW_58993_chars = new List<SW_58993_HuffmanCompression.SW_58993_WystepujacyZnak>();

            //Wywołanie metody kompresującej
            SW_58993_HuffmanCompression.SW_58993_Kompresuj(SW_58993_source, ref SW_58993_compressed, ref SW_58993_chars);

            //Generowanie informacji o znakach, ilości oraz kodzie binarnym
            string signsCombination = "";
            SW_58993_chars.ForEach(SW_58993_char =>
            {
                signsCombination += "Znak: " + SW_58993_char.SW_58993_Znak + " Ilość: " + SW_58993_char.SW_58993_Ilosc + " Kod: " + SW_58993_char.SW_58993_BinaryCode;
                signsCombination += System.Environment.NewLine;
            });

            SW_58993_textBox3.Text = signsCombination;

            //Generowanie kodu wynikowego
            string compressedString = "";
            SW_58993_compressed.ForEach(SW_58993_compressed_sign => compressedString += SW_58993_compressed_sign);
            SW_58993_textBox2.Text = compressedString;

            showAllResultControlls();
        }

        private void showAllResultControlls()
        {
            SW_58993_textBox2.Visible = true;
            SW_58993_textBox3.Visible = true;
            SW_58993_label3.Visible = true;
            SW_58993_label4.Visible = true;

        }

        //zdarzenie uruchamiane na każdą zmiane w polu do wprowadzania danych
        //słuące do walidacji
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string value = ((TextBox)sender).Text;
            //kompresja może zostać uruchomiona dla conajmniej dwóch róznych znaków
            if (value.Distinct().ToArray().Length <= 1)
            {
                SW_58993_label5.Visible = true;
                SW_58993_label5.Text = "Podaj wiecej niz jeden ten sam znak";
                SW_58993_button1.Enabled = false;
            }
            else
            {
                SW_58993_label5.Visible = false;
                SW_58993_label5.Text = "";
                SW_58993_button1.Enabled = true;

            }
        }
    }
}
