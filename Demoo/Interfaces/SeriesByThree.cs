﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demoo.Interfaces
{
    internal class SeriesByThree : ISeries
    {
        public int Current { get  ; set  ; }

        public void GetNext()
        {
            Current += 3;
        }

        public void Reset()
        {
            Current = 0;
        }
    }
}
