using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Compare_Char_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] first = Console.ReadLine().Split(' ').ToArray();
            string[] second = Console.ReadLine().Split(' ').ToArray();

            
            Array.Sort(first, second);
           

        }
    }
}
