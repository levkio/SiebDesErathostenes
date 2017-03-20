using System;

namespace SiebDesErathostenes
{
    class Erathostenes
    {
        private int i, e;
        private bool[] prim;
        public Erathostenes()
        {

        }

        public void calculatePrim(int maxNumber)
        {
            Init(maxNumber);
            while(i*i < prim.Length)
            {
                e = 2*i;
                while (e < prim.Length)
                {
                    streiche(e);
                    e += i;
                }
                i++;

            }
            print();
        }
        private void Init(int maxNumber)
        {
            i = 2;
            e = 0;
            prim = new bool[maxNumber];
            for(int i = 0; i < prim.Length; i++)
            {
                prim[i] = true;
            }
        }
        
        private void streiche(int i)
        {
            prim[i] = false;
        }

        public void print()
        {
            for(int i = 0; i < prim.Length; i++)
            {
                Console.WriteLine("Zahl "+(i+1)+" ist Prim: "+prim[i]);
            }
            Console.ReadKey();
        }
    }
}
