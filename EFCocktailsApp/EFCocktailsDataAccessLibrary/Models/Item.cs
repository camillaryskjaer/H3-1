using System;
using System.Collections.Generic;
using System.Text;

namespace EFCocktailsDataAccessLibrary.Models
{
    public class Item
    {
        public int Id { get; set; }

        public Ingredient Ingredient { get; set; }
        public int Amount { get; set; }
        public string Unit { get; set; }

        public Item()
        {

        }
    }
}
