using System;
using System.Linq;

namespace ex8
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Arrays */
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Console.WriteLine(cars[0]);

            cars[0] = "Opel";
            Console.WriteLine(cars[0]);

            Console.WriteLine(cars.Length);
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine(cars[i]);
            }

            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            int[] myNumber = { 5, 1, 8, 9 };
            Array.Sort(myNumber);
            foreach( int i in myNumber)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("Max: " + myNumber.Max());
            Console.WriteLine("Min: " + myNumber.Min());
            Console.WriteLine("Sum: " + myNumber.Sum());

            /* Ways to create array
            string[] cars = new string[4];
            string[] cars = new string[4] {"Volvo", "BMW", "Ford", "Mazda"};
            string[] cars = new string[] {"Volvo", "BMW", "Ford", "Mazda"};
            string cars = {"Volvo", "BMW", "Ford", "Mazda"};
            */

        }

    }
}
