using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    public interface ITest
    {
        string Description { get; set; }
        int Month { get; set; }
        DateTime ComputeNextServiceDate();
    }
}
