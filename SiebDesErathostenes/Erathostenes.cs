using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SiebDesErathostenes
{
    class Erathostenes
    {
        private int i,j;
        private bool[] prim;
        public Erathostenes()
        {

        }

        public void calculatePrim(int maxNumber)
        {
            Init(maxNumber);
            while(i*i < prim.Length)
            {

            }
        }
        private void Init(int maxNumber)
        {
            i = 2;
            prim = new bool[maxNumber];
        }
    }
}
