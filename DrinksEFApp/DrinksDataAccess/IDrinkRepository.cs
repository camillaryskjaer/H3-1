using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinksDataAccess.Models;

namespace DrinksDataAccess
{
    interface IDrinkRepository
    {
        List<Drink> GetAllDrinks();

        List<Drink> GetDrinksByIngredient(string ingredientName);

        List<Drink> GetDrinksByAlcohol();

        void AddDrink();

    }
}
