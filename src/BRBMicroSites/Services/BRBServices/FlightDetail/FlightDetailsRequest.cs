using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.FlightDetail
{
    [EndPoint("BagCheckIn/FlightDetails")]
    public class FlightDetailsRequest
    {
        public string FlightNumber { get; set; }
        public string DepartureAirportCode { get; set; }
        public string DestinationAirportCode { get; set; }
        public string LocalTimeZone { get; set; }
    }
}
