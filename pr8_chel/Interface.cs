using System;
using System.Collections.Generic;
using System.Text;

namespace pr8_chel
{
    interface IComparable
    {
        int CompareTo(object obj);
    }
    interface ICloneable
    {
        Object Clone();
    }
    interface ISeries
    {
        bool IsPrimeNumber(int number);
        void Reset();
        void SetStart(int x);
    }
}
