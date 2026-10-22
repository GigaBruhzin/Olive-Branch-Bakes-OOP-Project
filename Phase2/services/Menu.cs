using System;
using System.Collections.Generic;
using System.Text;

namespace Phase2.services
{
    internal class Menu
    {
        // Menu items are all tagged with specific allergens (nuts, peanuts, dairy, etc)

        // Class items include pastry type, allergens, any additional custom instructions (generic) and item specific custom instructions
    }

    public class FullMenu
    {
        public string FoodType { get; set; }
        public string AllergyTags { get; set; }
        public double Price { get; set; }
        
    }
}
