namespace BRBMicroSites.Services.BRBServices.Promo.PromoValidation
{
    public class ValidatePromoResponse
    {
        public int PromoId { get; set; }
        public string PromoCode { get; set; }
        public string GroupName { get; set; }
        public string PromoTypeCode { get; set; }
        public string PromoDurationCode { get; set; }
        public string ProductCode { get; set; }
    }
}
