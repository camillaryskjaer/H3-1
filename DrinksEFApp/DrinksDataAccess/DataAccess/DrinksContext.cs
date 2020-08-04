using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinksDataAccess.Models;

namespace DrinksDataAccess.DataAccess
{
    public class DrinksContext : DbContext
    {
        public DrinksContext() : base()
        {
            
        }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Liquid> Liquids { get; set; }
        public DbSet<Alcohol> Alcohols { get; set; }
    }
}
