using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__11._1
{
    class InvalidIndex : Exception
    {
        public InvalidIndex(string message)
            : base(message)
        { }
    }
}
