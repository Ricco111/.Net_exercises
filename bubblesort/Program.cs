using System;

namespace bubblesortWithArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Put string of numbers to sort: (divided by space)");
                        
            string userNumbers = Console.ReadLine();
            string[] rawNumbers = userNumbers.Split(' ');
            int[] arrayToSort = Array.ConvertAll(rawNumbers, s => int.Parse(s));

            //int[] arrayToSort = { 2, 10, 22, 45, 9, 3 };

            foreach (var item in arrayToSort)
            {
                Console.WriteLine(item);
            }

            BubbleSortFunction(arrayToSort);

            Console.WriteLine("Sorted numbers: ");

            foreach (var item in arrayToSort)
            {
                Console.WriteLine(item);
            }

        }
        
        public static void BubbleSortFunction(int[] arrayToSort)
        {
            int l = arrayToSort.Length;
            do
            {
                for (int i = 0; i < l-1; i++)
                {
                    if (arrayToSort[i] > arrayToSort[i + 1])
                    {
                        //tuple
                        (arrayToSort[i], arrayToSort[i+1]) = (arrayToSort[i+1], arrayToSort[i]);
                        
                        /*
                        int tmp = tablica[i];
                        tablica[i] = tablica[i + 1];
                        tablica[i + 1] = tmp;*/                        
                    }
                }
                l--;
            } 
            while(l>1);            
        }
    }
}
