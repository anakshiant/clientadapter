using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.BagRegistration
{
    [EndPoint("BagCheckIn/RegisterBagInformation")]
    public class RegisterBagRequest
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string BagTagNumber { get; set; }
        public string FlightNumber { get; set; }
        public string BoardingPass { get; set; }
        public string BaggageTag { get; set; }
        public string DepartureAirportCode { get; set; }
    }
}
