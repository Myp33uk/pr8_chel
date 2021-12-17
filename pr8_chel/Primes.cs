using System;
using System.Collections.Generic;
using System.Text;

namespace pr8_chel
{
    class Primes : ISeries, ICloneable, IComparable
    {
        private const int _start = 2;
        private int _current;

		public Primes()
		{
			_current = _start;
		}

		public object Clone()
		{
			return (Primes)MemberwiseClone();
		}

		public int CompareTo(object obj)
		{
			Primes primes = (Primes)obj;

			return GetCurrent() - primes.GetCurrent();
		}

		public int GetCurrent()
		{
			return _current;
		}

		public bool MoveNext()
		{
			int countDivider = 0;

			while (countDivider != 2)
			{
				_current++;
				countDivider = 0;

				for (int i = 1; i <= _current; i++)
				{
					if (_current % i == 0)
					{
						countDivider++;
					}
				}
				
			}

			return true;
		}

		public void Reset()
		{
			_current = _start;
		}
	}
}