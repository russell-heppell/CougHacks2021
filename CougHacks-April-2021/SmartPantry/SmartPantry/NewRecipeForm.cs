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
    public partial class NewRecipeForm : Form
    {
        Recipe recipe;
        string instructions;
        Dictionary<string, int> ingredients = new Dictionary<string, int>();
        User user;
        bool cooked;
        public NewRecipeForm(User user)
        {
            InitializeComponent();
            this.user = user;
            cooked = false;
        }

        public NewRecipeForm(User user, bool cooked) : this(user)
        {
            this.cooked = cooked;
        }

        private void saveRecipeButton_Click(object sender, EventArgs e)
        {
            string successMessage = "Save successful!";
            string successTitle = "Success!";
            string failedMessage = "Save not completed. Missing recipe name or recipe ingredients";
            string failedTitle = "Error";
            if (recipeNameTB.Text != "" && ingredients.Count != 0)
            {
                if (newRecipeDescriptionTB.Text != "")
                {
                    instructions = newRecipeDescriptionTB.Text;
                } else
                {
                    instructions = "";
                }
                recipe = new Recipe(recipeNameTB.Text, ingredients, instructions);
                user.addRecipe(recipe);
                newRecipeItemLB.Items.Clear();
                recipeNameTB.Clear();
                MessageBox.Show(successMessage, successTitle);

                if (cooked)
                {
                    CookedForm newForm = new CookedForm(user);
                    newForm.Show();
                }
            }
            else
            {
                MessageBox.Show(failedMessage, failedTitle);
            }
            this.Close();
        }

        private void addRecipeItemButton_Click(object sender, EventArgs e)
        {
            if (ingredient1.Text != "" && quantity1.Text != "")
            {
                ingredients.Add(ingredient1.Text, Int32.Parse(quantity1.Text));
                newRecipeItemLB.Items.Add(ingredient1.Text + " " + quantity1.Text);
            }
            ingredient1.Clear();
            quantity1.Clear();
        }

    }
}
