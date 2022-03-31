using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPantry
{
    public class User
    {
        private string username;
        private ShoppingList shoppingList;
        private List<FoodItem> mykitchen;
        private List<Recipe> recipes;
        public User (string username)
        {
            this.username = username;
            shoppingList = new ShoppingList();
            mykitchen = new List<FoodItem>();
            recipes = new List<Recipe>();
        }
        
        public string Username
        {
            get { return username; }
            set { username = value; }
        }

        public ShoppingList UserShoppingList
        {
            get { return shoppingList; }
            set { shoppingList = value; }
        }

        public List<FoodItem> MyKitchen
        {
            get { return mykitchen; }
            set { mykitchen = value; }
        }

        public List<Recipe> Recipes
        {
            get { return recipes; }
            set { recipes = value; }
        }

        public void addFoodToKitchen(FoodItem food)
        {
            foreach (FoodItem item in mykitchen)
            {
                if (item.Name.Equals(food.Name))
                {
                    item.TotalServings += food.TotalServings;
                    return;
                }
            }
            this.mykitchen.Add(food);
        }

        public void addRecipe(Recipe recipe)
        {
            this.recipes.Add(recipe);
        }
    } 

}
