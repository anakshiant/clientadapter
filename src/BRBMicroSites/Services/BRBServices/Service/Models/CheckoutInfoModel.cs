namespace BRBMicroSites.Services.BRBServices.Service.Models
{
    public class CheckoutInfoModel
    {
        public string CreditCardNumber { get; set; }
        public string CreditCardExpirationDate { get; set; }
        public string CreditCardCVV { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string ZipCode { get; set; }
        public string CountryCode { get; set; }
        public string CountryName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PaymentTypeCode { get; set; }
    }
}
