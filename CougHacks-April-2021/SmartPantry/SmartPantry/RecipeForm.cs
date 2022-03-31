using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPantry
{
    public partial class RecipeForm : Form
    {
        private Recipe recipe;
        private User user;
        public RecipeForm(User user, Recipe recipe)
        {
            this.user = user;
            this.recipe = recipe;
            InitializeComponent();
            populate();
        }

        public void populate()
        {
            if (recipe != null)
            {
                nameTextBox.Text = recipe.Name;
                directionsText.Text = recipe.Instructions;
                foreach (string item in recipe.Ingredients.Keys)
                {
                    ingredientsLB.Items.Add(item + " " + recipe.Ingredients[item]);
                }
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && ingredientsLB.Items.Count > 0)
            {
                recipe.Name = nameTextBox.Text;
                recipe.Instructions = directionsText.Text;
                /*Dictionary<string, int> items = new Dictionary<string, int>();
                foreach (string item in ingredientsLB.Items)
                {
                    string[] itemArray = item.Split(' ');
                    items.Add(itemArray[0], int.Parse(itemArray[1]));
                }
                recipe.Ingredients = items;*/
                this.Close();
            }
        }

        private void addIngredientsToShopping_Click(object sender, EventArgs e)
        {
            // add missing or insufficient ingredients to shopping list
            foreach (string item in ingredientsLB.Items)
            {
                string[] itemArray = item.Split(' ');
                string name = itemArray[0];
                int amount = int.Parse(itemArray[1]);
                bool found = false;
                foreach (FoodItem foodItem in user.MyKitchen)
                {
                    if (name.Equals(foodItem.Name))
                    {
                        if (amount > foodItem.TotalServings)
                        {
                            user.UserShoppingList.Add(name, amount - foodItem.TotalServings);
                            found = true;
                        }   
                    }
                }
                // add
                if (!found)
                {
                    user.UserShoppingList.Add(name, amount);
                }
            }
        }
    }
}
