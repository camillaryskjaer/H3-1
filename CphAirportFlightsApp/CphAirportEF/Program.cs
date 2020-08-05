using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CphAirportDataAccessLib;

namespace CphAirportEF
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataAccessController = new DataAccessController();

            var flights = dataAccessController.GetAllFlights();

            foreach (var flight in flights)
            {
                Console.WriteLine(flight);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
