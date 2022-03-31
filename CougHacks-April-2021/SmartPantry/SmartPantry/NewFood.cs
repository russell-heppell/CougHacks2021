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
    public partial class NewFood : Form
    {
        User user;

        public NewFood(User user)
        {
            this.user = user;

            InitializeComponent();
        }

        public NewFood(User user, string item, int amount) : this(user)
        {
            nameTextBox.Text = item;
            quantityTextBox.Text = amount + "";
        }

        private void addNewFoodButton_Click(object sender, EventArgs e)
        {
            if (nameTextBox.Text != "" && quantityTextBox.Text != "" && locationTextBox.Text != "") 
            {
                string name = nameTextBox.Text;
                int quantity = int.Parse(quantityTextBox.Text);
                string location = locationTextBox.Text;
                user.addFoodToKitchen(new FoodItem(name, location, expirationPicker.Value, quantity));
                this.Close();
            }
            
        }


    }
}
