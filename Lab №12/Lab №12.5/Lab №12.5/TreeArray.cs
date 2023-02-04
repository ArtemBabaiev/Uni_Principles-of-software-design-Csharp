using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__12._5
{
    class TreeArray:IEnumerable<Tree>
    {
        private List<Tree> trees;
        public TreeArray()
        {
            trees = new List<Tree>();
        }
        public void AddTree(Tree tree)
        {
            trees.Add(tree);
        }
        public IEnumerator<Tree> GetEnumerator()
        {
            foreach (var item in trees)
            {
                yield return item;
            }
        }
        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
        
    }
}
