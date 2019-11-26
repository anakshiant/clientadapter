namespace BRBMicroSites.Services.BRBServices.Promo.PromoCurrencyCodeValidation
{
    public class PromoCurrencyCodeValidateResponse
    {
        public string CurrencyCode { get; set; }

        public string PromoCode { get; set; }

        public bool IsValid { get; set; }
    }
}
