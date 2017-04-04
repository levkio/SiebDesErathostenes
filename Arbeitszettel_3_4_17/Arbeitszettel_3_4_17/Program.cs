using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arbeitszettel_3_4_17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ink(5): {0}",Ink(5));
            Console.WriteLine("Dek(5): {0}", Dekrement(5));
            Console.WriteLine("Pro(4,2): {0}",Pro(4, 2));
            Console.WriteLine("Pro(5,5): {0}",Pro(5, 5));
            Console.WriteLine("Pot(2,2): {0}", Pot(2, 2));
            Console.WriteLine("Pot(2,3): {0}",Pot(2, 3));
            Console.WriteLine("Pot(2,4): {0}",Pot(2, 4));
            Console.WriteLine("Pot(2,8): {0}", Pot(2, 8));
            Console.WriteLine("Pot(3,3): {0}", Pot(3, 3));


            Console.WriteLine("Quo(10,3): {0}", Qou(10, 3));

            Console.WriteLine("Qou(20,4): {0}", Qou(20, 4));


            Console.WriteLine("QWo(16): {0}", QWu(16));
            Console.WriteLine("QWo(25): {0}", QWu(25));

            Console.WriteLine("QWo(49): {0}", QWu(49));
            int erg = Sum(Pot(7, 5), 3); 
            Console.WriteLine("7^5 + 3: " + erg);


            Console.ReadKey();
        }

        private static int Ink(int a)
        {
            return ++a;
        }
        private static int Dekrement(int a)
        {
            return --a;
        }

        private static int Sum(int sumA, int sumB)
        {
            while(0 < sumB)
            {
                sumA = Ink(sumA);
                sumB = Dekrement(sumB);
            }
            return sumA;
        }
        private static int Dif(int min, int sub)
        {
            while(0 < sub)
            {
                min = Dekrement(min);
                sub = Dekrement(sub);
            }
            return min;
        }

        private static int Pro(int fakA, int fakB)
        {
            if (fakA == 0 || fakB == 0)
                return 0;
            else
            {
                return Sum(fakA, Pro(fakA, Dekrement(fakB)));
            }
        }
        private static int Pot(int basis, int exp)
        {
            if (exp == 1)
                return basis;
            if(exp > 1)
            {
                return Pro(basis,Pot(basis, exp - 1));
            }
            return 1;
            
        
        }
        private static int Qou(int divd, int divr)
        {
            if (divr == 0)
                return 0; // nice try
            if (divr == 1)
                return divd;
            if(divr > 1)
            {
                divd = Dif(divd - divr);
                return Sum(1 + Qou(divd, divr));
            }
            return 1;

        }

        private static int QWu(int rad)
        {
            int ctr = 0;
            int prod = 0;
            while(prod < rad)
            {
                prod = Pro(ctr, ctr);
                ctr = Ink(ctr);
            }
            return --ctr;
        }
    }
}
