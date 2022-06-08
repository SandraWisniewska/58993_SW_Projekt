using System;

public class SortAlgorithm
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

    public SortInfo InsertionSort(int[] tablica)
    {
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
}