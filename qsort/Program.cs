using System;

namespace qsort
{
    
    class Program
    {
        public static void Sort(int[] arr, int first, int last)
        {
            int p = arr[(last - first) / 2 + first];
            int temp;
            int i = first, j = last;
            while (i <= j)
            {
                while (arr[i] < p && i <= last) ++i;
                while (arr[j] > p && j >= first) --j;
                if (i <= j)
                {
                    temp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = temp;
                    ++i; --j;
                }
            }
            if (j > first) Sort(arr, first, j);
            if (i < last) Sort(arr, i, last);
        }
        
        static void Main(string[] args)
        {
            int[] array = {1, 10, 15, 20, 30, 40, 5, 60, 8, -5};
            
            Sort(array,0,array.Length-1);

            foreach (var number in array)
            {
                Console.WriteLine(number);
            }
        }
    }
}