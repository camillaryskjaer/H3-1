using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinksDataAccess.DataAccess;
using DrinksDataAccess.Models;

namespace DrinksDataAccess
{
    class DrinkRepository : IDrinkRepository
    {
        public List<Drink> GetAllDrinks()
        {
            var drinks = new List<Drink>();
            using (var ctx = new DrinksContext())
            {
                drinks = ctx.Drinks.Select(d => d).ToList();
            }

            return drinks;
        }

        public List<Drink> GetDrinksByIngredient(string ingredientName)
        {
            throw new NotImplementedException();
        }

        public List<Drink> GetDrinksByAlcohol()
        {
            throw new NotImplementedException();
        }

        public void AddDrink()
        {
            throw new NotImplementedException();
        }

        public void AddDrink(Drink drink)
        {
            throw new NotImplementedException();
        }
    }
}
