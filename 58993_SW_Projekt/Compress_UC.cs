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
    public partial class Compress_UC : UserControl
    {
        public Compress_UC()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Zadeklarowanie zmiennej zawierającej ciąg znaków do kompresji
            //string SW_58993_source = "XADJSOSDAOUAZADXSXODJAOUAOADAOXAAJSAXADOAOADO";
            string SW_58993_source = textBox1.Text;

            //Zadeklarowanie Listy typu string przekazywanej jako referencja do metody
            //kompresujacej SW_58993_KompresjaHuffmana, do której w metodzie dodane zostaną kody binarne skompresowanych znaków
            List<string> SW_58993_compressed = new List<string>();

            //Zadeklarowanie Listy typu SW_58993_WystepujacyZnak przekazywanej do metody
            //kompresujacej SW_58993_KompresjaHuffmana, do ktorej metoda doda informacje o znaku, ilości wystąpień oraz kodzie binarnym
            List<HuffmanCompression.SW_58993_WystepujacyZnak> SW_58993_chars = new List<HuffmanCompression.SW_58993_WystepujacyZnak>();

            //Wywołanie metody kompresującej
            HuffmanCompression.SW_58993_Kompresuj(SW_58993_source, ref SW_58993_compressed, ref SW_58993_chars);

            //Generowanie informacji o znakach, ilości oraz kodzie binarnym
            string signsCombination = "";
            SW_58993_chars.ForEach(SW_58993_char =>
            {
                signsCombination += "Znak: " + SW_58993_char.SW_58993_Znak + " Ilość: " + SW_58993_char.SW_58993_Ilosc + " Kod: " + SW_58993_char.SW_58993_BinaryCode;
                signsCombination += System.Environment.NewLine;
            });

            textBox3.Text = signsCombination;

            //Generowanie kodu wynikowego
            string compressedString = "";
            SW_58993_compressed.ForEach(SW_58993_compressed_sign => compressedString += SW_58993_compressed_sign);
            textBox2.Text = compressedString;

            showAllResultControlls();
        }

        private void showAllResultControlls()
        {
            textBox2.Visible = true;
            textBox3.Visible = true;
            label3.Visible = true;
            label4.Visible = true;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string value = ((TextBox)sender).Text;
            if (value.Distinct().ToArray().Length <= 1)
            {
                label5.Visible = true;
                label5.Text = "Podaj wiecej niz jeden ten sam znak";
                button1.Enabled = false;
            }
            else
            {
                label5.Visible = false;
                label5.Text = "";
                button1.Enabled = true;

            }
        }
    }
}
