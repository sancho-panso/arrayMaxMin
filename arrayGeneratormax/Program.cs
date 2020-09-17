using System;

namespace arrayGeneratormax
{
    class Program
    {
        static int[] arrayGenerator()//Method for generation of array filled with unique value's elements
        {
            int[] randomArray = new int[20];// empty array variable declaration
            Random rand = new Random();// random object declaration
            bool isElementUnique;// flag to check if value is unique
            for (int i = 0; i < randomArray.Length; i++) //loop for array initialisation
            {
                isElementUnique = false;
                while (!isElementUnique)// nested loop check if value is in array
                {
                    int elem = rand.Next(100);// generation of random int value from 0 to 100
                    if (Array.IndexOf(randomArray, elem) == -1)// if random value unique, assing to array element and escape inner loop
                    {
                        randomArray[i] = elem;
                        isElementUnique = true;
                    }
                    else
                    {
                        isElementUnique = false;
                    }
                }


            }

            return randomArray;

        }

        static void arrayMaxValue(int[] array)// Method to find max value in array
        {
            int max = Int32.MinValue;// new variable with smallest possible int value in C# scope

            for (int i = 0; i < array.Length; i++)// check each array's element if it is bigger than all previous array elements
            {
                if (array[i] > max) max = array[i]; //, if yes assing new value to max
            }

            Console.WriteLine($" The max value of array elements is: {max}");
        }

        static void arrayMinValue(int[] array)// Method to find min value in array
        {
            int min = Int32.MaxValue;// new variable with highest possible int value in C# scope

            for (int i = 0; i < array.Length; i++)// check each array's element if it is smaller than all previous array elements
            {
                if (array[i] < min) min = array[i]; //, if yes assing new value to min
            }

            Console.WriteLine($" The min value of array elements is: {min}");
        }

        static void Main(string[] args)
        {
            int[] array = arrayGenerator();// generate array

            for (int i = 0; i < array.Length; i++)// print array in Console
            {
                Console.Write(array[i] + " ");

            }

            Console.WriteLine();

            arrayMaxValue(array);// print max
            arrayMinValue(array);//print min
        }
    }
}
