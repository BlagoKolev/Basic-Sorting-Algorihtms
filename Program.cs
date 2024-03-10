using System.Text;

namespace BasicSortingAlgorihtms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[13] { 7, 5, 1, 3, 2, -2, 6, 4, 9, 2, 8, 10, 11 };

            //var selectionResult = SelectionSort(arr);
            var bubbleResult = BubbleSort(arr);
           

            //  Console.WriteLine(String.Join(", ", selectionResult));
             Console.WriteLine(String.Join(", ", bubbleResult));
          
            #region [Swap function]
            static int[] Swap(int[] array, int currentElement, int currentElementIndex, int otherElement, int otherElementIndex)
            {
                var tempElement = currentElement;
                array[currentElementIndex] = otherElement;
                array[otherElementIndex] = tempElement;
                return array;
            }
            #endregion

            #region [Selection-Sort]
            //Selection Sort   – O(n2) / unstable / selection;
            //Simple but not efficient. Swap the first element with the min element to the right. Then the second element, etc.
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

            #region [Buuble-Sort]

            //Bubble Sort - O(n2) / stable / exchanging;
            //On every i-loop takes the first element and compares it with the next right element. If the left element is bigger then right element it swaps these two elements. After that the loops continues with swapped element to the next right element until the end of the collection. 
            static int[] BubbleSort(int[] array)
            {

                for (int i = 0; i < array.Length; i++)
                {
                    bool isSorted = true;

                    for (int j = i + 1; j < array.Length - i; j++)
                    {
                        var currentElement = array[j - 1];
                        var nextElement = array[j];
                        if (currentElement > nextElement)
                        {
                            Swap(array, currentElement, j - 1, nextElement, j);
                            isSorted = false;
                        }
                    }
                    if (isSorted)
                    {
                        break;
                    }
                    i = --i;
                }
                return array;
            }
            #endregion

           
        }
    }
}
