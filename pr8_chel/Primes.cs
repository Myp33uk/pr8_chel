using System;
using System.Collections.Generic;
using System.Text;

namespace pr8_chel
{
    //class Primes : ISeries
    //{
    //    int start;
    //    int val;
    //    public Primes()
    //    {
    //        start = 2;
    //        val = 2;
    //    }
    //    public int Next
    //    {
    //        get { return GetNext(); }
    //    }
    //    public int GetNext()
    //    {
    //        int i, j;
    //        bool isprime;
    //        val++;
    //        for (i = val; i < 100000; i++)
    //        {
    //            isprime = true;
    //            for (j = 2; j < i/j; j++)
    //            {
    //                if((i%j)==0)
    //                {
    //                    isprime = false;
    //                    break;
    //                }
    //            }
    //        }
    //        return val;
    //    }
    //    public void Reset()
    //    {
    //        val = start;
    //    }
    //    public void SetStart(int x)
    //    {
    //        start = x;
    //        val = start;
    //    }
    //}
    class Primes : ISeries
    {
        int start;
        int val;
        public Primes()
        {
            start = 1;
            val = 1;
        }
        public int GetNext()
        {
            int i, j;
            bool isprime;
            val++;
            for (i = val; i < 28; i++)
            {
                isprime = true;
                for (j = 2; j <= i / j; j++)
                {
                    if ((i % j) == 0)
                    {
                        isprime = false;
                        break;
                    }
                }
                if (isprime)
                {
                    val = i;
                    break;
                }
            }
            return val;
        }

        public void Reset()
        {
            val = start;
        }

        public void SetStart(int x)
        {
            start = x;
            val = start;
        }
    }
}