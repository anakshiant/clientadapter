using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.Promo.PromoValidation
{
    [EndPoint("Service/ValidatePromoCode")]
    public class ValidatePromoRequest
    {
        public string ProductCode { get; set; }
        public string PromoCode { get; set; }
    }
}
