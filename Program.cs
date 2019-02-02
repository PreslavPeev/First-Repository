change with tortoise
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var i = 1;
            while(i<=n)
            {
                Console.WriteLine(i);
                i = i * 2 + 1;
            }

        }
    }
}
