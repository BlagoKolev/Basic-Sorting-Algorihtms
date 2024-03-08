namespace BasicSortingAlgorihtms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[12] { 7, 5, 1, 3, 2, 2, 6, 4, 9, 8, 10, 11 };
            var result = SelectionSort(arr);
            
            static int[] Swap(int[] array, int currentElement, int currentElementIndex, int otherElement, int otherElementIndex)
            {
                var tempElement = currentElement;
                array[currentElementIndex] = otherElement;
                array[otherElementIndex] = tempElement;
                return array;
            }

            #region [Selection-Sort]
            //Selection Sort   – O(n2) / unstable / selection; Simple but not efficient. Swap the first element with the min element to the right. Then the second element, etc.
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
                        { //Here we check not only for lower then, but and for equals becasuse the algo should be unstable
                            if (nextElement <= minElement)
                            {
                                minElement = nextElement;
                                minElementIndex = j;
                            }
                        }
                    }
                    if (minElement < currentElement)
                    {
                        //var tempElement = currentElement;
                        //arr[i] = minElement;
                        //arr[minElementIndex] = tempElement;
                        Swap(arr, currentElement, i, minElement, minElementIndex);
                    }
                }

                return arr;
            }
            #endregion
        }
    }
}
