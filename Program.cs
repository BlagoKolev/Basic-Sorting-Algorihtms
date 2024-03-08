namespace BasicSortingAlgorihtms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[12] { 7, 5, 1, 3, 2, 2, 6, 4, 9, 8, 10, 11 };
            var result = SelectionSort(arr);

            #region [Selection-Sort]
            static int[] SelectionSort(int[] arr)
            {
                for (int i = 0; i < arr.Length - 1; i++)
                {
                    var currentElement = arr[i];
                    var minElement = currentElement;
                    var minElementIndex = -1;

                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        var nextElement = arr[j];
                        if (nextElement < currentElement)
                        {
                            if (nextElement < minElement)
                            {
                                minElement = nextElement;
                                minElementIndex = j;
                            }
                        }
                    }
                    if (minElement < currentElement)
                    {
                        var tempElement = currentElement;
                        arr[i] = minElement;
                        arr[minElementIndex] = tempElement;
                    }
                }

                return arr;
            }
            #endregion
        }
    }
}
