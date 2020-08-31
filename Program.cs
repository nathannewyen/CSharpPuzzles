using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;
using System.Linq;
namespace puzzels
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(10);
            Names();
        }

        public static int[] RandomArray()
        {
            var rand = new Random();
            var randomArray = new int[10];
            for (int i = 0; i < 10; i++)
            {
                randomArray[i] = rand.Next(5, 25);
            }
            int min = randomArray[0], max = randomArray[0], sum = 0;
            for (int i = 0; i < 10; i++)
            {
                if (randomArray[i] > max)
                {
                    max = randomArray[i];
                }

                if (randomArray[i] < min)
                {
                    min = randomArray[i];
                }

                sum += randomArray[i];
            }
            Console.WriteLine($"Min: {min}, Max: {max}, Sum: {sum}");
            return randomArray;
        }

        public static string TossCoin()
        {
            Random rand = new Random();
            int toss = rand.Next(1, 3);
            string outcome = (toss == 1) ? "heads" : "tails";
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine(outcome);
            return outcome;
        }

        public static double TossMultipleCoins(int numb)
        {
            double heads = 0, tails = 0;
            for (int i = 0; i < numb; i++)
            {
                string outcome = TossCoin();
                if (outcome == "heads")
                {
                    heads += 1;
                }

                if (outcome == "tails")
                {
                    tails += 1;
                }
            }

            double ratio = (heads / tails);
            Console.WriteLine($"Ratio of {heads} heads to {tails} tails in {numb} tosses is {ratio}");
            return ratio;
        }

        public static string[] Names()
        {
            string[] names = { "Todd", "Tiffany", "Charlie", "Geneva", "Sydney" };
            Random rand = new Random();
            for (int i = 0; i < names.Length; i++)
            {
                int idx = rand.Next(names.Length);
                string temp = names[idx];
                names[idx] = names[i];
                names[i] = temp;
            }
            List<string> overFive = new List<string>();
            foreach (string name in names)
            {
                if (name.Length > 5)
                {
                    overFive.Add(name);
                }
            }
            foreach (string person in overFive)
            {
                Console.WriteLine(person);
            }
            return overFive.ToArray();
        }
    }
}
