using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CphAirportDataAccessLib.Repositories
{
    public class FlightRepository
    {
        public List<Flight> GetAllFlights()
        {
            var flights = new List<Flight>();
            using (var ctx = new AirportEntities())
            {
                flights = ctx.Flights.ToList();
            }

            return flights;
        }

        public List<Flight> GetAllFlightsByDestinationId(int id)
        {
            var flights = new List<Flight>();
            using (var ctx = new AirportEntities())
            {
                flights = ctx.Flights.Where(f => f.OperatorId == id).ToList();
            }

            return flights;
        }

    }
}
