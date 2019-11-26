using BRBMicroSites.Libs.ApiClient;
using BRBMicroSites.Services.BRBServices.Service.Models;
using System.Collections.Generic;

namespace BRBMicroSites.Services.BRBServices.Service.Purchase
{
    [EndPoint("Service/Purchase")]
    public class ServicePurchaseRequest
    {
        public string ProductCode { get; set; }
        public string PromoCode { get; set; }
        public string CurrencyCode { get; set; }
        public string PurchaseEntrySource { get; set; }
        public CheckoutInfoModel CheckoutInfo { get; set; }
        public List<PurchasePassengerModel> PassengerList { get; set; }
        public string BillingMethodCode { get; set; }
    }
}
