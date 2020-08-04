using System;
using System.Collections.Generic;
using System.Text;
using EFCocktailsDataAccessLibrary.Models;
using Microsoft.EntityFrameworkCore;

namespace EFCocktailsDataAccessLibrary.DataAccess
{
    public class DrinksContext : DbContext
    {
        public DrinksContext(DbContextOptions options) : base(options) { }

        public DbSet<Drink> Drinks { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Item> Items { get; set; }
        public DbSet<Liquid> Liquids { get; set; }
        public DbSet<Alcohol> Alcohols { get; set; }

    }
}
