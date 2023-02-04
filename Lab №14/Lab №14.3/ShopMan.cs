using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab__14._3
{
    class ShopMan
    {
        private string name;
        private int numToBuy;
        private List<string> Cart;

        public ShopMan(string name, int howMuch)
        {
            this.name = name;
            this.Cart = new List<string>();
            this.numToBuy = howMuch;
        }

        public string Name { get => name; }
        public int NumToBuy { get => numToBuy; }

        public void AddToCart(string item)
        {
            numToBuy--;
            Cart.Add(item);
        }
        private string ListStr()
        {
            string str = "";
            foreach (var item in Cart)
            {
                str += item + " ";
            }
            return str;
        }
        public override string ToString()
        {
            return $"Ім'я: {name} | Список: {ListStr()}";
        }
    }
}
