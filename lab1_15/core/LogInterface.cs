using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_15.core
{
    public interface LogInterface
    {
        LogInterface Log(string str);
        LogInterface Write();
    }
}
