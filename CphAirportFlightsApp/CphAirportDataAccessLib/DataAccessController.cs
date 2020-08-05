using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CphAirportDataAccessLib.Repositories;

namespace CphAirportDataAccessLib
{
    public class DataAccessController
    {
        public FlightRepository FlightRepository { get; set; } = new FlightRepository();

        public AirlineRepository AirlineRepository { get; set; } = new AirlineRepository();

        public List<string> GetAllFlights()
        {
            var flights = FlightRepository.GetAllFlights();
            var flightNames = new List<string>();

            foreach (var flight in flights)
            {
                flightNames.Add($"Flight {flight.Route.Airport} - {flight.Route.Airport1}. With Airline: {flight.Airline.Name}. Operated by {flight.Airline1}.");
            }

            return flightNames;
        }

    }
}
