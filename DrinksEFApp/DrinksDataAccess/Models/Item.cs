using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksDataAccess.Models
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
