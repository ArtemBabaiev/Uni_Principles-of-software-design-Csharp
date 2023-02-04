using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__13._1
{
    class ComparatorByMark : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.GetAverage>y.GetAverage)
            {
                return 1;
            }
            else if (x.GetAverage < y.GetAverage)
            {
                return -1;
            }
            {
                return 0;
            }
        }
    }
    
    class ComparatorByName: IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            if (x.Name[0] > y.Name[0])
            {
                return 1;
            }
            else if (x.Name[0] < y.Name[0])
            {
                return -1;
            }
            {
                return 0;
            }
        }
    }
}
