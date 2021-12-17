using System;
using System.Collections.Generic;
using System.Text;

namespace pr8_chel
{
	class Evens : ISeries
	{
		private const int _start  = 2;
		private const int _step  = 2;
		private int _current;

		public Evens()
		{
			_current = _start;
		}
		public int GetCurrent()
		{
			return _current;
		}

		public bool MoveNext()
		{
			_current += _step;
			return true;
		}

		public void Reset()
		{
			_current = _start;
		}
	}
}
