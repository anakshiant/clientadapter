using System;

namespace BRBMicroSites.Services.BRBServices.FlightDetail
{
    public class FlightDetailsResponse
    {
        public int Id { get; set; }
        public DateTime ScheduledFlightDepartureTime { get; set; }
        public DateTime ScheduledFlightArrivalTime { get; set; }
        public string Status { get; set; }
        public string DepartureAirport { get; set; }
        public string DepartureTerminal { get; set; }
        public string ScheduledGateDeparture { get; set; }
        public string TaxiOutMinutes { get; set; }
        public string TaxiInMinutes { get; set; }
        public string ArrivalAirport { get; set; }
        public string ArrivalTerminal { get; set; }
        public string ScheduledGateArrival { get; set; }
        public string DelayDepartureGate { get; set; }
        public string DelayArrivalGate { get; set; }
        public string DepartureAirportCode { get; set; }
        public string ArrivalAirportCode { get; set; }
        public string FlightNumber { get; set; }
        public string BaggageCarousal { get; set; }
    }
}
