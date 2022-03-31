using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPantry
{
    public class ShoppingList
    {

        Dictionary<string, int> items;

        public ShoppingList()
        {
            this.items = new Dictionary<string, int>();
        }

        public Dictionary<string, int> Items
        {
            get { return this.items; }
        }

        public void Add(string food, int servings)
        {
            if (items.ContainsKey(food))
            {
                items[food] += servings;
            }
            else
            {
                items.Add(food, servings);
            }
        }

        public void Remove(string food)
        {
            items.Remove(food);
        }

        public void Clear()
        {
            this.items = new Dictionary<string, int>();
        }
    }
}
