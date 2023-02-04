using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__12._5_alt
{
    class Tree : IComparable<Tree>
    {
        private string species;
        private int price;
        private int height;

        public string Species { get => species; set => species = value; }
        public int Price { get => price; set => price = value; }
        public int Height { get => height; set => height = value; }

        public Tree(string species, int price, int height)
        {
            this.Species = species;
            this.Price = price;
            this.Height = height;
        }
        public int CompareTo(Tree obj)
        {
            if (this.Price > obj.Price)
            {
                return 1;
            }
            else if (this.Price < obj.Price)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
        
        public override string ToString()
        {
            return $"{Species} | {Price} | {Height}";
        }
    }
}
