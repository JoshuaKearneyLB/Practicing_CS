using System;

namespace Binary_search_algorithm
{
    class Program
    {

        static void BinarySearch()
        {
            Console.WriteLine("Enter Length of array: ");
            int Length = int.Parse(Console.ReadLine());
            int[] NumList = new int[Length];

            for (int i = 0; i < Length; i++)
            {
                Console.WriteLine("Enter item {0} in the array: ", i + 1);
                NumList[i] = int.Parse(Console.ReadLine());
            }

            // fINDING ITEM YOU WANT

            Console.WriteLine("Enter the element you want to find: ");
            int Target = int.Parse(Console.ReadLine());

            int LowerBound = 1;
            int UpperBound = Length;
            bool Found = false;

            while (Found != true)
            {
                if (UpperBound < LowerBound)
                {
                    Console.WriteLine("{0} is not in the array", Target);
                }
                int MidPoint = LowerBound + (UpperBound - LowerBound) / 2;
                if (NumList[MidPoint] < Target)
                {
                    LowerBound = MidPoint + 1;
                }

                if (NumList[MidPoint] > Target)
                {
                    UpperBound = MidPoint - 1;
                }
                if (NumList[MidPoint] == Target)
                {
                    Console.WriteLine("{0} has been found at midpoint {1} or element {2}", Target, MidPoint, MidPoint + 1);
                    Found = true;
                }
            }
        }        
        static void Main(string[] args)
        {
            BinarySearch();
        }
    }
}
