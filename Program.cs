using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[9];
            for (int i =0; i < arr.Length; i++)
            {
                int number = RandomNumber(0, 10);
                arr[i] = number;  
            }
            
            Console.WriteLine(String.Join(",", arr));
        }

        static int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }
    }
}
