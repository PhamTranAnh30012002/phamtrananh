using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi1_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int answer = 0;
            for (int i = 1; i <= 2*n-1; i+=2)
            {
                answer += i;
            }
            Console.WriteLine(answer);
            Console.ReadKey();
        }
    }
}
