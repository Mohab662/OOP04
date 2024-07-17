using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP04.Interfaces
{
    internal interface ISeries
    {
        // 1. Signature For Property
        public int Current { get; set; }

        // 1. Signature For Methods
        public void GetNext();
        public void Reset()
        {
            Current = 0;
        }
    }
}
