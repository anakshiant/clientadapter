namespace BRBMicroSites.Services.BRBServices.Service.Models
{
    public class PurchasePassengerModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public int? OrderSequence { get; set; }
        public int? AirlineId { get; set; }
        public string AirlineCode { get; set; }
        public string AirlineCodeType { get; set; }
        public string AirlineConfirmationNumber { get; set; }
        public int? LastAirlineId { get; set; }
        public string LastAirlineCode { get; set; }
        public string LastAirlineCodeType { get; set; }
        public string LastAirlineConfNumber { get; set; }
        public string AirlineName { get; set; }
    }
}
