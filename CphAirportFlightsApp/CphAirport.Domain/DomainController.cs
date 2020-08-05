using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CphAirportDataAccessLib;

namespace CphAirport.Domain
{
    public class DomainController
    {
        public DataAccessController AccessController { get; set; } = new DataAccessController();
    }
}
