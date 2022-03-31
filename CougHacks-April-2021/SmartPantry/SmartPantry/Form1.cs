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
    public partial class Form1 : Form
    {
        private User user;
        private FoodForm currentFoodForm = new FoodForm(null, null);
        private RecipeForm currentRecipeForm = new RecipeForm(null, null);
        public Form1(User user)
        {
            InitializeComponent();
            this.user = user;

            // initialize the All foods tab here (since its the initial default tab)
            foreach(var food in user.MyKitchen)
            {
                allFoodLB.Items.Add(food);
            }
        }

        private void cookedButton_Click(object sender, EventArgs e)
        {
            /*
             * This section for what happens when the "I cooked something!" button is clicked.
             * Basically, if you make something that uses more than one ingredient,
             * you can click here to deduct entire recipes worth of ingredients at once.
             * The ingredients and amounts (servings/serving sizes) will then be deducted
             * from the master food list. Ex: PB&J
             */

            CookedForm cookedForm = new CookedForm(user); // Initialize new form
            cookedForm.Show(); // Show the new form
             // Hide the current form

        }

        private void ateButton_Click(object sender, EventArgs e)
        {
            /* This section for what happens when the "I ate something!" button is clicked.
             * Basically, if you eat something individually (i.e. snacking) you go here
             * to deduct the amount. Ex: two servings of potato chips.
             */

            AteForm ateForm = new AteForm(user);
            ateForm.Show();
        }

        private void shoppingButton_Click(object sender, EventArgs e)
        {
            /* This section for what happens when the "Shopping List" button is clicked.
             * If you click here, lists all food items currently in your shopping list.
             */

            ShoppingForm shoppingForm = new ShoppingForm(user);
            shoppingForm.Show();
        }

        private void allFoodLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clicked on an item in the list.
            currentFoodForm.Close();
            FoodForm foodForm = new FoodForm((FoodItem)allFoodLB.SelectedItem, user);
            currentFoodForm = foodForm;
            foodForm.Show();
        }

        private void pantryLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clicked on an item in the list.
            currentFoodForm.Close();
            FoodForm foodForm = new FoodForm((FoodItem)pantryLB.SelectedItem, user);
            currentFoodForm = foodForm;
            foodForm.Show();
        }

        private void refrigeratorLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clicked on an item in the list.
            currentFoodForm.Close();
            FoodForm foodForm = new FoodForm((FoodItem)refrigeratorLB.SelectedItem, user);
            currentFoodForm = foodForm;
            foodForm.Show();
        }

        private void freezerLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clicked on an item in the list.
            currentFoodForm.Close();
            FoodForm foodForm = new FoodForm((FoodItem)freezerLB.SelectedItem, user);
            currentFoodForm = foodForm;
            foodForm.Show();
        }

        private void recipesLB_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clicked on an item in the list.
            currentRecipeForm.Close();
            RecipeForm recipeForm = new RecipeForm(user, (Recipe)recipesLB.SelectedItem);
            currentRecipeForm = recipeForm;
            recipeForm.Show();
        }

        private void tabControl_Selected(object sender, TabControlEventArgs e)
        {
            if (e.TabPageIndex == 0)
            {
                // All foods tab

                allFoodLB.Items.Clear();        
                foreach (var food in user.MyKitchen)
                {
                    allFoodLB.Items.Add(food);
                }
            }

            else if (e.TabPageIndex == 1)
            {
                // Pantry Tab

                pantryLB.Items.Clear();
                foreach(var food in user.MyKitchen)
                {
                    if(food.Location == "Pantry")
                    {
                        pantryLB.Items.Add(food);
                    }
                }
            }
            else if (e.TabPageIndex == 2)
            {
                //Refrigerator Tab

                refrigeratorLB.Items.Clear();
                foreach (var food in user.MyKitchen)
                {
                    if (food.Location == "Refrigerator")
                    {
                        refrigeratorLB.Items.Add(food);
                    }
                }
            }
            else if (e.TabPageIndex == 3)
            {
                // Freezer tab

                freezerLB.Items.Clear();
                foreach (var food in user.MyKitchen)
                {
                    if (food.Location == "Freezer")
                    {
                        freezerLB.Items.Add(food);
                    }
                }
            }

            else
            {
                // Recipes tab 

                recipesLB.Items.Clear();
                foreach (Recipe recipe in user.Recipes)
                {
                    recipesLB.Items.Add(recipe);
                }
            }
        }

        private void isActive(object sender, EventArgs e)
        {
            tabControl_Selected(sender, new TabControlEventArgs(tabControl.SelectedTab, tabControl.SelectedIndex, TabControlAction.Selected));
        }

        private void addRecipe_Click(object sender, EventArgs e)
        {
            NewRecipeForm newRecipe = new NewRecipeForm(user);
            newRecipe.Show();
        }

        private void addFoodItemButton_Click(object sender, EventArgs e)
        {
            NewFood newFood = new NewFood(user);
            newFood.Show();
        }
    }
}

