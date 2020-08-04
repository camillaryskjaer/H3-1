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
        static string connectionString = "Data Source=.;Initial Catalog=EFDataDB;Integrated Security=true;";
        public DrinksContext() : base(connectionString)
        {
        }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Liquid> Liquids { get; set; }
        public DbSet<Alcohol> Alcohols { get; set; }
    }
}
