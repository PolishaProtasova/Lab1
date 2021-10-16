using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1_15.Protasova
{
    class ProtasovaException : Exception
    {
        public ProtasovaException(string message) : base(message) { }
    }
}
