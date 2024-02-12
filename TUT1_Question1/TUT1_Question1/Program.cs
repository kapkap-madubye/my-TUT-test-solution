using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class TUT1_Question1
    {
        static void Main(string[] args)
        {
            int[] numpack = new int[10];
            for (int i = 0; i < numpack.Length; i++)
            {
                Console.WriteLine("Enter a number");
                numpack[i] = int.Parse(Console.ReadLine());

            }
            int highnum = numpack[0];
            int lowernum = numpack[0];

            for (int i = 1; i < numpack.Length; i++)
            {
                if (numpack[i] >= highnum)
                {
                    highnum = numpack[i];
                }
                if (numpack[i] <= lowernum)
                {
                    lowernum = numpack[i];
                }

            }
            for (int i = 0; i < numpack.Length; i++)
            {
                Console.WriteLine(numpack[i]);
            }

            Console.WriteLine("highest Number is :" + highnum);
            Console.WriteLine("Lowest Number is : " + lowernum);
            Console.ReadKey();





        }
    }
}