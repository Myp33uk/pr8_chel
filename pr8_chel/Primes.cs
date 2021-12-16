using System;
using System.Collections.Generic;
using System.Text;

namespace pr8_chel
{
    class Primes : ISeries, ICloneable, IComparable
    {
        public Primes()
        {
            start = 2;
            val = start;//
        }
        public Primes(int _start)
        {
            start = _start;
            val = start;
        }
        private int start;
        public int val;
        public object Clone()
        {
            Primes new1 = new Primes(start);
            new1.val = val;
            return new1;
        }
        public int CompareTo(object primes)
        {
            Primes prim = (Primes)primes;
            if (val < prim.val) return 1;
            if (val > prim.val) return -1;
            return 0;
        }
        public bool IsPrimeNumber(int number)
        {
            for (int i = 2; i < number; i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        public void Reset()
        {
            val = start;
        }

        public void SetStart(int _start)
        {
            start = _start;
        }
    }
}