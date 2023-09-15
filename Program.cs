using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warmup1diff21
{
    internal class Program
    {
        static void Main(string[] args) {

            

            Console.WriteLine(diff21(100));
            Console.ReadLine();

        }

        static int diff21(int n) {

            int number = 21;

            if (n <= number)
            {

                int sum = number - n;
                return sum;
            }

            else {

                int sum2 = (n - number) * 2;
                return sum2;
            
            } 
           
            
           
        
        }
    }
}
