using System;

public class SW_58993_SortAlgorithm
{
    //Klasa wewnetrzna SortInfo s³u¿y do zwracania wyników sortowania:
    // - posortowanej tablicy
    // - iloœci operacji wykonanych podczas sortowania
    public class SW_58993_SortInfo
    {
        public int[] SW_58993_sortedArray;
        public int SW_58993_numberOfSortOperations;

        //konstruktor ustawiaj¹cy posortowana tablice i iloœæ operacji
        public SW_58993_SortInfo(int[] SW_58993_sortedArray, int SW_58993_numberOfSortOperations)
        {
            this.SW_58993_sortedArray = SW_58993_sortedArray;
            this.SW_58993_numberOfSortOperations = SW_58993_numberOfSortOperations;
        }
    }

    //Funkcja do sortowania przez wstawianie zwracajaca
    //obiekt SortInfo(posortowana tablice i ilosc operacji)
    public SW_58993_SortInfo SW_58993_InsertionSort(int[] SW_58993_tablica)
    {
        int[] SW_58993_randomArray = SW_58993_tablica;

        int SW_58993_numberOfChanges = 0;
        for (int SW_58993_i = 1; SW_58993_i < SW_58993_randomArray.Length; SW_58993_i++)
        {
            int SW_58993_tmpI = SW_58993_i - 1;
            int SW_58993_tmp = SW_58993_randomArray[SW_58993_i];
            while (SW_58993_tmpI >= 0 && SW_58993_tmp < SW_58993_randomArray[SW_58993_tmpI])
            {
                SW_58993_randomArray[SW_58993_tmpI + 1] = SW_58993_randomArray[SW_58993_tmpI];
                SW_58993_numberOfChanges++;
                SW_58993_tmpI--;
            }
            SW_58993_randomArray[SW_58993_tmpI + 1] = SW_58993_tmp;
        }
        return new SW_58993_SortInfo(SW_58993_randomArray, SW_58993_numberOfChanges);
    }

    //Funkcja do sortowania b¹belkowego zwracajaca
    //obiekt SortInfo(posortowana tablice i ilosc operacji)
    public SW_58993_SortInfo SW_58993_BubbleSort(int[] SW_58993_tablica)
    {
        int[] SW_58993_randomArray = SW_58993_tablica;

        int SW_58993_numberOfChanges = 0;
        for (int SW_58993_j = 0; SW_58993_j < SW_58993_randomArray.Length - 1; SW_58993_j++)
        {
            for (int SW_58993_i = 0; SW_58993_i < SW_58993_randomArray.Length - 1; SW_58993_i++)
            {
                if (SW_58993_randomArray[SW_58993_i] > SW_58993_randomArray[SW_58993_i + 1])
                {
                    int SW_58993_tmp = SW_58993_randomArray[SW_58993_i + 1];
                    SW_58993_randomArray[SW_58993_i + 1] = SW_58993_randomArray[SW_58993_i];
                    SW_58993_randomArray[SW_58993_i] = SW_58993_tmp;
                    SW_58993_numberOfChanges++;
                }
            }
        }
        return new SW_58993_SortInfo(SW_58993_randomArray, SW_58993_numberOfChanges);
    }
}