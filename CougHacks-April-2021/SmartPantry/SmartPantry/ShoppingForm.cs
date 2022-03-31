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
    public partial class ShoppingForm : Form
    {
        private User user;
        public ShoppingForm(User user)
        {
            this.user = user;
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            foreach (string item in user.UserShoppingList.Items.Keys)
            {
                shoppingList.Items.Add(item + " " + user.UserShoppingList.Items[item]);
            }
        }

        private void newShoppingItemButton_Click(object sender, EventArgs e)
        {
            // Functionality when "New Shopping Item" button pushed.
            NewFood newFood = new NewFood(user);
            newFood.Show();
        }

        private void boughtAndClear_Click(object sender, EventArgs e)
        {
            foreach (string item in user.UserShoppingList.Items.Keys)
            {
                bool found = false;
                foreach (FoodItem foodItem in user.MyKitchen)
                {
                    if (item.Equals(foodItem.Name))
                    {
                        foodItem.TotalServings += user.UserShoppingList.Items[item];
                        found = true;
                    }
                }
                if (!found)
                {
                    NewFood newFoodForm = new NewFood(user, item, user.UserShoppingList.Items[item]);
                    newFoodForm.Show();
                }
            }
            user.UserShoppingList.Clear();

            MessageBox.Show("Your kitchen has been updated!!");

            this.Close();
        }
    }
}
