namespace DataStructAndAlgorithm;

public class SortList : ISortList
{
    public void BubbleSort(ref int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    // First way for swap with variable
                    // var tmp = array[j];
                    // array[j] = array[j + 1];
                    // array[j + 1] = tmp;

                    // Second way for swap with tuple
                    (array[j + 1], array[j]) = (array[j], array[j + 1]);

                }

            }

        }
    }
}
