using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.Data.Airline
{
    [EndPoint("Data/GetAirlineList")]
    public class AirlineResponse
    {
        public int AirlineId { get; set; }
        public string AirlineName { get; set; }

        public string AirlineICAOCode { get; set; }

        public string AirlineIATACode { get; set; }
        public string ChineseAirlineName { get; set; }
    }
}