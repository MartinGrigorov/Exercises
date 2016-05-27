using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] one = Console.ReadLine().Split(' ').ToArray();
            string[] two = Console.ReadLine().Split(' ').ToArray();

            var rightCount = 0;

            while (rightCount < one.Length && rightCount < two.Length)
            {
                if (one[one.Length - rightCount - 1] == two[two.Length - rightCount - 1])
                {
                    rightCount++;
                }
                else break;

            }
            Console.WriteLine( $"{rightCount}");
        }
    }
}
