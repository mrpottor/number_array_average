using System;

namespace NumberAverage
{
    public class NumberAverage
    {
        static void Main(string[] args)
        {

            // get size of array

            // declare array for the given size

            //get the values of the array from the user

            //call FindAverage() method to calculate average and receive string response

            //print the result
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];
            string input = Console.ReadLine();
            string[] inputArray = input.Split(' ');
            for (int i = 0; i < size; i++) 
            {
                array[i] = Convert.ToInt32(inputArray[i]);
            }
            string average = FindAverage(array);
            Console.WriteLine(average);
        }

        //write here logic to calculate the average an array
        public static String FindAverage(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double average = (double)sum / array.Length;
            return average.ToString();
        }
    }
}
