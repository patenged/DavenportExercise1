using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DavenportExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 6, 3, 2, 7, 5, 0 };
            List<int> odds = new List<int>();
            List<int> index = new List<int>();

            //finds the odd numbers and there index in the array
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 != 0)
                {
                    odds.Add(numbers[i]);
                    index.Add(i);
                }
            }

            //sorts the odd numbers
            odds.Sort();

            //places the odd numbers
            for (int i = 0; i < odds.Count; i++)
            {
                numbers[index[i]] = odds[i];
            }

            //displays the full array
            foreach (int x in numbers)
            {
                Console.WriteLine(x);
            }
        }
    }
}
