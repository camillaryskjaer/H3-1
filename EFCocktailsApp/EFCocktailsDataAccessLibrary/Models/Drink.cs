using System;
using System.Collections.Generic;
using System.Text;
using EFCocktailsDataAccessLibrary.Models.Enums;

namespace EFCocktailsDataAccessLibrary.Models
{
    public class Drink
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public GlassType Glass { get; set; }
        public List<Item> Items { get; set; }

        public Drink()
        {

        }

    }
}
