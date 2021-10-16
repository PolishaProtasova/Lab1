using lab1_15.core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_15.Protasova
{
    class ProtasovaLog : LogAbstract, LogInterface
    {
        private static ProtasovaLog single = null;
        private ProtasovaLog() { }

        public static ProtasovaLog I()
        {
            if (single == null)
                single = new ProtasovaLog();
            return single;
        }

        List<string> list = new List<string>();

        public LogInterface Log(string str)
        {
            list.Add(str);
            return this;
        }

        public LogInterface Write()
        {
            WriteConsole(list.ToArray());
            return this;
        }
    }
}
