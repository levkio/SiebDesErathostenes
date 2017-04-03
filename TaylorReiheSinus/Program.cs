using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaylorReiheSinus
{
    class Program
    {
        /// <summary>
        /// Taylor := Summe von n = 0 bis unendlich: (-1)^n* x^2n+1 / (2n+1)! 
        /// => x/1! + x^3 / 3! + x^5/ 5! = x - x^3/6 + x^5/120
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Zahl in Gradmass eingeben 0-360");
            double grad = double.Parse(Console.ReadLine());
            double bog = (grad * Math.PI) / 180;
            Console.WriteLine("Das Bogenmass ist: {0}", bog);
            Console.WriteLine("Iteration angegeben:");
            int n = int.Parse(Console.ReadLine());
            taylor(bog,n);
        }

        static int fak(int a)
        {
            int x, fak;
            fak = 1;
            x = a;

            for(int i = 1; i <= x; i++)
            {
                fak *= i;
            }
            return fak;
        }

        static void taylor(double bog, int n)
        {
            double zeahler, nenner, sinx = 0;
            for(int i = 0; i <= n; i++)
            {
                zeahler = Math.Pow(bog, 2 * i + 1);
                nenner = fak(2 * i + 1);
                sinx += Math.Pow(-1,i)*(zeahler/nenner);
            }
            Console.WriteLine("Sin({0}): ist    = {1}", bog, sinx);
            Console.ReadKey();
        }
    }
}
