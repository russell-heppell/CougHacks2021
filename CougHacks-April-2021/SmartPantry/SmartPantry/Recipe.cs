using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPantry
{
    public class Recipe
    {
        string name;
        Dictionary<string, int> ingredients;
        string instructions;

        public Recipe(string name, Dictionary<string, int> ingredients, string instructions)
        {
            this.name = name;
            this.ingredients = ingredients;
            this.instructions = instructions;
        }
        
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public Dictionary<string, int> Ingredients
        {
            get { return ingredients; }
            set { ingredients = value; }
        }

        public string Instructions
        {
            get { return instructions; }
            set { instructions = value; }
        }

        public override string ToString()
        {
            return name;
        }
    }
}
