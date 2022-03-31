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
    public partial class FoodForm : Form
    {
        private FoodItem foodItem;
        private User user;
        public FoodForm(FoodItem foodItem, User user)
        {
            this.foodItem = foodItem;
            this.user = user;
            InitializeComponent();
            populate();
        }

        private void populate()
        {
            if (foodItem != null)
            {
                nameTextBox.Text = foodItem.Name;
                quantityTextBox.Text = foodItem.TotalServings + "";
                dateTimePicker1.Value = foodItem.ExpirationDate;
                locationTextBox.Text = foodItem.Location;
            }

        }

        private void addToShopping_Click(object sender, EventArgs e)
        {
            if (amountToAdd.Value > 0)
            {
                user.UserShoppingList.Add(foodItem.Name, (int)amountToAdd.Value);
                this.Close();
            }
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && quantityTextBox.Text != "" && locationTextBox.Text != "")
            {
                foodItem.Name = nameTextBox.Text;
                foodItem.TotalServings = int.Parse(quantityTextBox.Text);
                foodItem.Location = locationTextBox.Text;
                foodItem.ExpirationDate = dateTimePicker1.Value;
                this.Close();
            }
        }
    }
}
