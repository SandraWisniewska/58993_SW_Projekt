using System;

public class SortowanieTablicy
{

    public class SortInfo
    {
        public int[] sortedArray;
        public int numberOfSortOperations;

        public SortInfo(int[] sortedArray, int numberOfSortOperations)
        {
            this.sortedArray = sortedArray;
            this.numberOfSortOperations = numberOfSortOperations;
        }
    }

    //public static void Main()
    //{
    //    Console.WriteLine("======= Sortowanie przez wstawianie =======");
    //    BubbleSort();
    //    Console.WriteLine("======= /Sortowanie przez wstawianie =======\n");

    //    Console.WriteLine("======= Sortowanie bąbelkowe ======= ");
    //    InsertionSort();
    //    Console.WriteLine("======= /Sortowanie bąbelkowe =======");
    //}

    public SortInfo InsertionSort(int[] tablica)
    {
        //int[] randomArray = GenerateWithRandomNumbers();
        int[] randomArray = tablica;

        int numberOfChanges = 0;
        for (int i = 1; i < randomArray.Length; i++)
        {
            int tmpI = i - 1;
            int tmp = randomArray[i];
            while (tmpI >= 0 && tmp < randomArray[tmpI])
            {
                randomArray[tmpI + 1] = randomArray[tmpI];
                numberOfChanges++;
                tmpI--;
            }
            randomArray[tmpI + 1] = tmp;
        }

        return new SortInfo(randomArray, numberOfChanges);
    }

    public SortInfo BubbleSort(int[] tablica)
    {
        int[] randomArray = tablica;

        int numberOfChanges = 0;
        for (int j = 0; j < randomArray.Length - 1; j++)
        {
            for (int i = 0; i < randomArray.Length - 1; i++)
            {
                if (randomArray[i] > randomArray[i + 1])
                {
                    int tmp = randomArray[i + 1];
                    randomArray[i + 1] = randomArray[i];
                    randomArray[i] = tmp;
                    numberOfChanges++;
                }
            }
        }


        return new SortInfo(randomArray, numberOfChanges);
    }

    public static int[] GenerateWithRandomNumbers()
    {
        var rand = new Random();
        int[] randomArray = new int[20];
        for (int i = 0; i < randomArray.Length - 1; i++)
        {
            //losuje w przedziale 0-100
            randomArray[i] = rand.Next(101);
        }
        Console.WriteLine("Wygenerowana tablica: ");
        Console.WriteLine(string.Join(",", randomArray));

        return randomArray;
    }
}