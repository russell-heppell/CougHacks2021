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
    public partial class CookedForm : Form
    {
        User user;
        public CookedForm(User user)
        {
            InitializeComponent();
            this.user = user;
            foreach (var recipe in user.Recipes)
            {
                cookedRecipeList.Items.Add(recipe.Name);
            }
        }

        private void cookedNewRecipeButton_Click(object sender, EventArgs e)
        {
            // Functionality when "New Recipe" button clicked.
            
            NewRecipeForm newRecipeForm = new NewRecipeForm(user, true);
            newRecipeForm.Show();
            this.Close();
        }

        private void recipeSearchTB_TextChanged(object sender, EventArgs e)
        {
            // Searching for recipe that they cooked.
        }

        private void SelectRecipe_Click(object sender, EventArgs e)
        {
            // update the users food items.

            // get the selected recipe
            string selectedRecipe = cookedRecipeList.GetItemText(cookedRecipeList.SelectedItem);

            Recipe recipe = null;

            foreach(var rec in user.Recipes)
            {
                if(rec.Name == selectedRecipe)
                {
                    recipe = rec;
                    break;
                }
            }
            if (recipe == null) return;

            // loop through the ingredients in the recipe and the users food items to find matches,
            // then decrement the users foodItem.totalServings 
            foreach(var ingredient in recipe.Ingredients)
            {
                foreach(var foodItem in user.MyKitchen)
                {
                    if(ingredient.Key == foodItem.Name)
                    {
                        // get the number of servings for the ingredient in the recipe, update
                        // users total servings in their kitchen.
                        int recipeIngredientServing = ingredient.Value;
                        foodItem.TotalServings -= recipeIngredientServing;

                        // maybe check here if any of the users food items are close to empty/empty?
                    }
                }
            }

            MessageBox.Show("Your kitchen has been updated!");
            this.Close();
        }

    }
}
