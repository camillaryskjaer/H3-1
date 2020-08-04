using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrinksDataAccess.Models
{
    public class Alcohol : Liquid
    {
        public int Percent { get; set; }

        public Alcohol()
        {

        }
    }
}
