using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__12._5
{
    class CompareTree : IComparer <Tree>
    {
        public int Compare(Tree x, Tree y)
        {
            if (x.Height * x.Price > y.Height * y.Price)
            {
                return 1;
            }
            else if (x.Height * x.Price < y.Height * y.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }

    }
}
