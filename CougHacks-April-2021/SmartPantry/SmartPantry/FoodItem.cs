using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPantry
{
    public class FoodItem
    {
        string name;
        string location;
        DateTime expirationDate;
        int totalServings;

        public FoodItem(string name, string location, DateTime expDate, int servings)
        {
            this.name = name;
            this.location = location;
            this.expirationDate = expDate;
            this.totalServings = servings;
        }

        public string Name
        {
            get { return this.name; }
            set { name = value; }
        }

        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public DateTime ExpirationDate
        {
            get { return this.expirationDate; }
            set { this.expirationDate = value; }
        }

        public int TotalServings
        {
            get { return this.totalServings; }
            set { this.totalServings = value; }
        }

        public override string ToString()
        {
            return name + " " + totalServings;
        }
    }
}
