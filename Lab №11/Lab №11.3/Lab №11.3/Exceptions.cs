using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__11._3
{

        class DifferentSize : Exception
        {
            public DifferentSize(string message)
                : base(message)
            { }
        }

}
