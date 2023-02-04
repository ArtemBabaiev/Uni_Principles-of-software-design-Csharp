using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__12._5_alt
{
    class Trees: IEnumerable<Tree>
    {
        private List<Tree> arr;

        public Trees()
        {
            this.arr = new List<Tree>();
        }

        public void AddTree(Tree tree)
        {
            arr.Add(tree);
        }
        public void SortByPrice()
        {
            arr.Sort();
        }
        public void SortBy2()
        {
            arr.Sort(new TreeComparator());
        }

        public IEnumerator<Tree> GetEnumerator()
        {
            return arr.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return arr.GetEnumerator();
        }
    }
}
