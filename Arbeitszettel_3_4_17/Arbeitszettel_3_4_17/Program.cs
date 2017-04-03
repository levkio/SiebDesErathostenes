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
            int erg2 = Sum(4, 10);
            erg2 = Dif(erg2, 5);
            erg2 = Qou(erg2, 2);
            erg2 = Qou(erg2, 3);

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
            int sum = sumA;
            for(int i = 0; i < sumB; i++)
            {
                sum = Ink(sum);
            }
            return sum;
        }
        private static int Dif(int min, int sub)
        {
            int dif = min;
            for(int i = 0; i < sub; i++)
            {
                dif = Dekrement(dif);
            }
            return dif;
        }

        private static int Pro(int fakA, int fakB)
        {
            int prod = 0;
            for (int i = 0; i < fakB; i++)
            {
                for(int j = 0; j < fakA; j++)
                {
                    prod = Ink(prod);
                }
            }
            return prod;
        }
        private static int Pot(int basis, int exp)
        {
            int potenz = basis;
            exp = Dekrement(exp);
            while(exp > 0)
            {
                potenz = Pro(potenz, basis);
                exp = Dekrement(exp);
            }
            return potenz;
        
        }
        private static int Qou(int divd, int divr)
        {
            int ret = 0;
            while(divd > 0)
            {
                divd = Dif(divd, divr);
                ret = Ink(ret);
            } return ret;
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
