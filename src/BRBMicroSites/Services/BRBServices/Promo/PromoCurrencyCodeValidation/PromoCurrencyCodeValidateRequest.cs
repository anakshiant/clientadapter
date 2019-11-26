using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.Promo.PromoCurrencyCodeValidation
{
    [EndPoint("Service/PromoCurrencyCodeValidate")]
    public class PromoCurrencyCodeValidateRequest
    {
        public string CurrencyCode { get; set; }

        public string PromoCode { get; set; }

        public bool IsValid { get; set; }
    }
}
