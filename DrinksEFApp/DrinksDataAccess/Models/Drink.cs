using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DrinksDataAccess.Models.Enum;

namespace DrinksDataAccess.Models
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
