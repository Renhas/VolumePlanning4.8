using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SLAN
{
    public interface IMyReader
    {
        InequalitySystem Read(string file);

    }
}
