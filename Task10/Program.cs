using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            string str2 = "";
            foreach(char c in str)
            {
                str2 = str + str2;
            }
            Console.WriteLine(str2);
            Console.ReadLKey();
        }
    }
}
