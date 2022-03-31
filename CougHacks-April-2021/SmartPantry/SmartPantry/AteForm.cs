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
    public partial class AteForm : Form
    {
        User user;
        public AteForm(User user)
        {
            InitializeComponent();
            this.user = user;

            foreach(var food in user.MyKitchen)
            {
                ateList.Items.Add(food.Name);
            }

        }

        private void ateNewFoodButton_Click(object sender, EventArgs e)
        {
            // Functionality when "New Food" button clicked.
            NewFood newFood = new NewFood(user);
            newFood.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void selectFood_Click(object sender, EventArgs e)
        {
            string selectedFood = ateList.GetItemText(ateList.SelectedItem);

            if (selectedFood == "") return;

            int servings = (int)servingPicker.Value;

            foreach(var food in user.MyKitchen)
            {
                if(food.Name == selectedFood)
                {
                    food.TotalServings -= servings;
                }
            }

            MessageBox.Show("Your kitchen has been updated!!");

            this.Close();

        }
    }
}
