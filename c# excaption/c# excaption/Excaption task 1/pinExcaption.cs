using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__excaption
{
    public class pinExcaption:ApplicationException
    {
        public override string Message => "Sizin pin duzgun deyil";
    }
}
