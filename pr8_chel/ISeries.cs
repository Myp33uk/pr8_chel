using System;
using System.Collections.Generic;
using System.Text;

namespace pr8_chel
{
    interface ISeries
    {
        int GetCurrent();
        bool MoveNext();
        void Reset();
    }
}
