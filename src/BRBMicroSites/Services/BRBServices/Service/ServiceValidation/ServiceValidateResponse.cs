using BRBMicroSites.Services.BRBServices.Service.Models;
using System.Collections.Generic;

namespace BRBMicroSites.Services.BRBServices.Service.ServiceValidation
{
    public class ServiceValidateResponse
    {
        public int ServiceId { get; set; }
        public string ServiceKey { get; set; }
        public string ServiceNumber { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public int PassengerCount { get; set; }
        public decimal TotalPrice { get; set; }
        public decimal TotalSavings { get; set; }
        public decimal TotalCharge { get; set; }
        public decimal MaximumLossCoverage { get; set; }
        public string BRBPhoneNumber { get; set; }
        public string PromoCodes { get; set; }
        public decimal CoveragePerBag { get; set; }
        public string AlternativeCurrencyCode { get; set; }
        public string CurrencySymbol { get; set; }
        public string TotalChargeDisplay { get; set; }
        public string BillingMethodCode { get; set; }
        public string Currency { get; set; }

        public List<PurchasePassengerModel> Passenger { get; set; }
    }
}
