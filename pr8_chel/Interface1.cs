using System;
using System.Collections.Generic;
using System.Text;

namespace pr8_chel
{
    interface ISeries
    {
        int GetNext();
        void Reset();
        void SetStart(int x);
    }
}
