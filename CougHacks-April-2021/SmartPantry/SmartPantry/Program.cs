using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartPantry
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            User user;
            try
            {
                user = FlatStorage.ReadFromFile("dummy");
            }
            catch (FileNotFoundException e)
            {
                user = new User("dummy");
                // fill user with info 
                FoodItem food1 = new FoodItem("Bread", "Pantry", new DateTime(2020, 07, 11), 2);
                FoodItem food2 = new FoodItem("Peanut Butter", "Pantry", new DateTime(2020, 07, 11), 1);
                FoodItem food3 = new FoodItem("Jelly", "Refrigerator", new DateTime(2020, 07, 11), 1);
                FoodItem food4 = new FoodItem("Chicken", "Freezer", new DateTime(2020, 07, 11), 4);


                user.addFoodToKitchen(food1);
                user.addFoodToKitchen(food2);
                user.addFoodToKitchen(food3);
                user.addFoodToKitchen(food4);

                //Recipe
                Dictionary<string, int> ingredients = new Dictionary<string, int>()
                {
                    { "Bread", 2 },
                    {"Peanut Butter", 1 },
                    {"Jelly", 1 }
                };

                Recipe recipe = new Recipe("PB & J", ingredients, "These are the instructions.");

                user.addRecipe(recipe);
            }
            Application.Run(new Form1(user));
            
            FlatStorage.SaveToFile(user);
        }
    }
}
