using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_15.core
{
    public abstract class LogAbstract
    {
        protected String FormatLog(String[] strings)
        {
            return String.Join(";\n\r", strings);
        }
        protected void WriteConsole(String s)
        {
            Console.WriteLine(s);
        }
        protected void WriteConsole(String[] s)
        {
            Console.WriteLine(FormatLog(s));
        }
    }
}
