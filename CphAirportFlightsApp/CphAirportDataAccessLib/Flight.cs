//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CphAirportDataAccessLib
{
    using System;
    using System.Collections.Generic;
    
    public partial class Flight
    {
        public int Id { get; set; }
        public Nullable<int> RouteId { get; set; }
        public Nullable<int> OwnerId { get; set; }
        public Nullable<int> OperatorId { get; set; }
    
        public virtual Airline Airline { get; set; }
        public virtual Airline Airline1 { get; set; }
        public virtual Route Route { get; set; }
    }
}