namespace BRBMicroSites.Services.BRBServices.Data.Product
{
    public class ProductResponse
    {
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string CurrencyCode { get; set; }
        public string CurrencyName { get; set; }
        public decimal BagCoverage { get; set; }
        public string CurrencySymbol { get; set; }
    }
}