using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace _58993_SW_Projekt
{
    internal class SW_58993_HuffmanCompression
    {
        public class SW_58993_WystepujacyZnak
        {
            public int SW_58993_Ilosc { get; set; }
            public string SW_58993_Znak { get; set; }
            public string SW_58993_BinaryCode { get; set; }
        }
        public class SW_58993_DrzewoHuffmana
        {
            public int SW_58993_BinaryCode { get; set; }
            public string SW_58993_Znak { get; set; }
            public string SW_58993_Node { get; set; }
            public int SW_58993_Ilosc { set; get; }
        }
        public class SW_58993_HuffmanSourceDictionary
        {
            public string SW_58993_SingleChar { get; set; }
            public string SW_58993_BinaryCode { set; get; }

        }
        public static void SW_58993_Kompresuj(string SW_58993_source, ref List<string> SW_58993_resultCode, ref List<SW_58993_WystepujacyZnak> SW_58993_listaZnaków)
        {
            string SW_58993_pozostaly = SW_58993_source;
            string SW_58993_roboczy = SW_58993_pozostaly;
            int SW_58993_indexListy = 0;
            string SW_58993_kolejnyZnak = "";

            List<SW_58993_DrzewoHuffmana> SW_58993_drzewoHuffmana = new List<SW_58993_DrzewoHuffmana>();
            List<SW_58993_WystepujacyZnak> SW_58993_tymczasowaListaZnakow = new List<SW_58993_WystepujacyZnak>();
            List<SW_58993_DrzewoHuffmana> SW_58993_tymczasoweDrzewoHuffmana = new List<SW_58993_DrzewoHuffmana>();

            do
            {
                SW_58993_roboczy = SW_58993_pozostaly;
                SW_58993_kolejnyZnak = SW_58993_roboczy.Substring(0, 1);
                SW_58993_indexListy = SW_58993_tymczasowaListaZnakow.FindIndex(SW_58993_f => SW_58993_f.SW_58993_Znak == SW_58993_kolejnyZnak);

                if (SW_58993_indexListy == -1)
                {
                    SW_58993_WystepujacyZnak SW_58993_nowyZnak = new SW_58993_WystepujacyZnak();
                    SW_58993_nowyZnak.SW_58993_Ilosc = 1;
                    SW_58993_nowyZnak.SW_58993_Znak = SW_58993_kolejnyZnak;
                    SW_58993_tymczasowaListaZnakow.Add(SW_58993_nowyZnak);
                }
                else
                {
                    SW_58993_tymczasowaListaZnakow.Where(SW_58993_w => SW_58993_w.SW_58993_Znak == SW_58993_kolejnyZnak).ToList()
                                         .ForEach(SW_58993_s => SW_58993_s.SW_58993_Ilosc = SW_58993_s.SW_58993_Ilosc + 1);
                }
                SW_58993_pozostaly = SW_58993_roboczy.Remove(0, 1);
            } while (SW_58993_pozostaly.Length != 0);

            SW_58993_listaZnaków = SW_58993_tymczasowaListaZnakow.OrderBy(SW_58993_o => SW_58993_o.SW_58993_Ilosc).ToList();
            List<SW_58993_WystepujacyZnak> SW_58993_posortowanaListaZnaków = new List<SW_58993_WystepujacyZnak>(SW_58993_listaZnaków);

            int SW_58993_nrKorzenia = 0;
            int SW_58993_nowyKorzenWartosc = 0;
            string SW_58993_nowyKorzen = "SW_58993_node";

            do
            {
                if (SW_58993_posortowanaListaZnaków.Count > 1)
                {
                    if (SW_58993_drzewoHuffmana.Count > 0)
                    {
                        if (SW_58993_drzewoHuffmana[0].SW_58993_Ilosc + SW_58993_posortowanaListaZnaków[0].SW_58993_Ilosc > SW_58993_posortowanaListaZnaków[0].SW_58993_Ilosc + SW_58993_posortowanaListaZnaków[1].SW_58993_Ilosc)
                            SW_58993_nowyKorzenWartosc = SW_58993_drzewoHuffmana[0].SW_58993_Ilosc + SW_58993_posortowanaListaZnaków[0].SW_58993_Ilosc;
                        else
                            SW_58993_nowyKorzenWartosc = SW_58993_posortowanaListaZnaków[0].SW_58993_Ilosc +
                                                SW_58993_posortowanaListaZnaków[1].SW_58993_Ilosc;
                    }
                    else if (SW_58993_drzewoHuffmana.Count == 0)
                        SW_58993_nowyKorzenWartosc = SW_58993_posortowanaListaZnaków[0].SW_58993_Ilosc +
                                            SW_58993_posortowanaListaZnaków[1].SW_58993_Ilosc;

                    if (SW_58993_posortowanaListaZnaków.Count > 2)
                    {
                        if (SW_58993_nowyKorzenWartosc >= SW_58993_posortowanaListaZnaków[2].SW_58993_Ilosc &&
                                                 SW_58993_posortowanaListaZnaków.Count >= 3)
                            SW_58993_nrKorzenia++;
                    }
                    else
                        SW_58993_nrKorzenia++;

                    SW_58993_WystepujacyZnak SW_58993_nowyZnak = new SW_58993_WystepujacyZnak
                    {
                        SW_58993_Ilosc = SW_58993_nowyKorzenWartosc,
                        SW_58993_Znak = SW_58993_nowyKorzen + SW_58993_nrKorzenia
                    };

                    SW_58993_posortowanaListaZnaków.Add(SW_58993_nowyZnak);

                    for (int SW_58993_i = 0; SW_58993_i <= 1; SW_58993_i++)
                    {
                        SW_58993_DrzewoHuffmana SW_58993_drzewoHuffmanaItem = new SW_58993_DrzewoHuffmana();

                        if (SW_58993_posortowanaListaZnaków.Count > 1)
                            SW_58993_drzewoHuffmanaItem.SW_58993_BinaryCode = SW_58993_i;
                        else
                            SW_58993_drzewoHuffmanaItem.SW_58993_BinaryCode = 2;

                        SW_58993_drzewoHuffmanaItem.SW_58993_Znak = SW_58993_posortowanaListaZnaków[SW_58993_i].SW_58993_Znak;
                        SW_58993_drzewoHuffmanaItem.SW_58993_Node = SW_58993_nowyKorzen + SW_58993_nrKorzenia.ToString();
                        SW_58993_drzewoHuffmanaItem.SW_58993_Ilosc = SW_58993_posortowanaListaZnaków[SW_58993_i].SW_58993_Ilosc;
                        SW_58993_drzewoHuffmana.Add(SW_58993_drzewoHuffmanaItem);
                    }

                    SW_58993_posortowanaListaZnaków.RemoveRange(0, 2);
                    SW_58993_tymczasowaListaZnakow = SW_58993_posortowanaListaZnaków.OrderBy(SW_58993_o => SW_58993_o.SW_58993_Ilosc).ToList();
                    SW_58993_tymczasoweDrzewoHuffmana = SW_58993_drzewoHuffmana.OrderByDescending(SW_58993_o => SW_58993_o.SW_58993_Ilosc).ToList();
                    SW_58993_drzewoHuffmana = SW_58993_tymczasoweDrzewoHuffmana;
                    SW_58993_posortowanaListaZnaków = SW_58993_tymczasowaListaZnakow;
                }

                else
                {
                    SW_58993_DrzewoHuffmana SW_58993_drzewoHuffmanaItem = new SW_58993_DrzewoHuffmana
                    {
                        SW_58993_BinaryCode = 2,
                        SW_58993_Znak = SW_58993_nowyKorzen + (SW_58993_nrKorzenia + 1).ToString(),
                        SW_58993_Node = "TOP"
                    };

                    SW_58993_drzewoHuffmana.Add(SW_58993_drzewoHuffmanaItem);
                    SW_58993_posortowanaListaZnaków.Clear();
                }
            } while (SW_58993_posortowanaListaZnaków.Count != 0);

            SW_58993_tymczasoweDrzewoHuffmana = SW_58993_drzewoHuffmana.OrderBy(SW_58993_o => SW_58993_o.SW_58993_Ilosc).ToList();
            SW_58993_drzewoHuffmana = SW_58993_tymczasoweDrzewoHuffmana;

            string SW_58993_tempBinaryCode = "";
            string SW_58993_actualNode = "";

            for (int SW_58993_i = 0; SW_58993_i < SW_58993_drzewoHuffmana.Count - 1; SW_58993_i++)
            {
                if (SW_58993_drzewoHuffmana[SW_58993_i].SW_58993_Ilosc == SW_58993_drzewoHuffmana[SW_58993_i + 1].SW_58993_Ilosc && SW_58993_drzewoHuffmana[SW_58993_i + 1].SW_58993_Znak.Length > 1)
                {
                    SW_58993_DrzewoHuffmana SW_58993_tymczasowy = new SW_58993_DrzewoHuffmana();
                    SW_58993_tymczasowy = SW_58993_drzewoHuffmana[SW_58993_i];
                    SW_58993_drzewoHuffmana[SW_58993_i] = SW_58993_drzewoHuffmana[SW_58993_i + 1];
                    SW_58993_drzewoHuffmana[SW_58993_i + 1] = SW_58993_tymczasowy;
                    SW_58993_drzewoHuffmana[SW_58993_i].SW_58993_BinaryCode = 0;
                    SW_58993_drzewoHuffmana[SW_58993_i + 1].SW_58993_BinaryCode = 1;
                }
            }
            for (int SW_58993_i = 0; SW_58993_i < SW_58993_listaZnaków.Count; SW_58993_i++)
            {
                SW_58993_kolejnyZnak = SW_58993_listaZnaków[SW_58993_i].SW_58993_Znak;
                SW_58993_indexListy = SW_58993_drzewoHuffmana.FindIndex(SW_58993_f => SW_58993_f.SW_58993_Znak == SW_58993_kolejnyZnak);
                SW_58993_actualNode = SW_58993_drzewoHuffmana[SW_58993_indexListy].SW_58993_Node;
                SW_58993_tempBinaryCode = SW_58993_drzewoHuffmana[SW_58993_indexListy].SW_58993_BinaryCode.ToString();

                do
                {
                    SW_58993_indexListy = SW_58993_drzewoHuffmana.FindIndex(SW_58993_f => SW_58993_f.SW_58993_Znak == SW_58993_actualNode);
                    if (SW_58993_indexListy != -1)
                    {
                        SW_58993_actualNode = SW_58993_drzewoHuffmana[SW_58993_indexListy].SW_58993_Node;
                        SW_58993_tempBinaryCode = SW_58993_tempBinaryCode + SW_58993_drzewoHuffmana[SW_58993_indexListy].SW_58993_BinaryCode.ToString();

                        if (SW_58993_tempBinaryCode.Length > 1 && SW_58993_tempBinaryCode.Substring(0, 1) == "0")
                            SW_58993_tempBinaryCode = SW_58993_tempBinaryCode.Remove(0, 1);
                    }
                } while (SW_58993_indexListy != -1);
                SW_58993_listaZnaków[SW_58993_i].SW_58993_BinaryCode = SW_58993_tempBinaryCode;
            }

            //String wyjsciowy znaków
            SW_58993_StworzStringWyjsciowy(SW_58993_source, ref SW_58993_resultCode, ref SW_58993_listaZnaków);
        }
        private static void SW_58993_StworzStringWyjsciowy(string SW_58993_source, ref List<string> SW_58993_resultCode, ref List<SW_58993_WystepujacyZnak> SW_58993_listaZnaków)
        {
            string SW_58993_kolejnyZnak = "";

            for (int SW_58993_i = 0; SW_58993_i < SW_58993_source.Length; SW_58993_i++)
            {
                SW_58993_kolejnyZnak = SW_58993_source.Substring(SW_58993_i, 1);
                for (int SW_58993_j = 0; SW_58993_j <= SW_58993_listaZnaków.Count; SW_58993_j++)
                {
                    if (SW_58993_listaZnaków[SW_58993_j].SW_58993_Znak == SW_58993_kolejnyZnak)
                    {
                        SW_58993_resultCode.Add(SW_58993_listaZnaków[SW_58993_j].SW_58993_BinaryCode + ",");
                        SW_58993_j = SW_58993_listaZnaków.Count;
                    }
                }
            }
        }

    }

}

