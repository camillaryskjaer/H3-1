using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CphAirportDataAccessLib.Repositories
{
    public class AirlineRepository
    {
        public List<Airline> GetAllAirlines()
        {
            var airlines = new List<Airline>();
            using (var ctx = new AirportEntities())
            {
                airlines = ctx.Airlines.ToList();
            }

            return airlines;
        }

        public Airline GetAirlineById(int id)
        {
            var airline = new Airline();
            using (var ctx = new AirportEntities())
            {
                airline = ctx.Airlines.FirstOrDefault(a => a.Id == id);
            }

            return airline;
        }
    }
}
