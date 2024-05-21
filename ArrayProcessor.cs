namespace BITest
{
    public class ArrayProcessor
    {
        public int[] ProcessArray(int[] arr)
        {
            int[] filteredArray = FilterMultiplesOfThree(arr);
            SortArrayAscending(filteredArray);
            return filteredArray;
        }

        private int[] FilterMultiplesOfThree(int[] arr)
        {
            int count = 0;
            foreach (int value in arr)
            {
                if (value % 3 != 0)
                {
                    count++;
                }
            }

            int[] result = new int[count];
            int index = 0;
            foreach (int value in arr)
            {
                if (value % 3 != 0)
                {
                    result[index++] = value;
                }
            }

            return result;
        }

        private void SortArrayAscending(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = 0; j < arr.Length - 1 - i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
        }
    }
}