using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c__excaption.Excaption_task_1
{
    public class balansExcaption: ApplicationException
    {
        public override string Message => "Balansda yeterli qeder mebleg yoxdur";
    }
}
