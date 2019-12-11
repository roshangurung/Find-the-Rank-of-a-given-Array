using System;

namespace Find_the_Rank_of_a_given_Array
{
    class Program////Create single and two dimensional arrays using ‘array1’ and ‘array2’ variables respectively and had defined the coefficient element values of a single and two dimensional arrays.//
    {
        static void Main(string[] args)
        {
            int[] array1 = new int[5] { 1, 2, 3, 4, 5 };///The function rank denotes the dimensions of the array. Thus the rank is found for various types of array that are declared and print the rank of the matrix.///
            int[,] array2 = new int[10, 3];
            Console.WriteLine("Total dimensions of Array is : " + array1.Rank);
            Console.WriteLine("Total dimensions of Array is : " + array2.Rank);
            Console.ReadLine();
        }
    }
}
///Output:
///Total dimensions of Array is: 1
///Total dimensions of Array is: 2