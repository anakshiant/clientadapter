using System;

namespace BRBMicroSites.Services.BRBServices.Service.ServiceInfo
{
    public class FetchServiceInformationResponse
    {
        public int ServiceId { get; set; }
        public string AgentLogin { get; set; }


        public string ServiceNumber { get; set; }
        public string ServiceAgreementPrefix { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }

        public DateTime PurchaseDate { get; set; }

        public decimal TotalPrice { get; set; }
        public decimal TotalCoverage { get; set; }
        public decimal TotalSavings { get; set; }
        public decimal TotalCharge { get; set; }
        public decimal BagCoverage { get; set; }

        public string EntrySourceCode { get; set; }
        public string ServiceStatusCode { get; set; }
        public string PaymentTransCode { get; set; }
        public string PaymentTransLog { get; set; }
        public string PaymentExceptionLog { get; set; }
        public string BillingMethodCode { get; set; }
        public string PromoCode { get; set; }

        public int? ApiTokenId { get; set; }

        public int? PromoId { get; set; }
        public string GatewayCode { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string CreateBy { get; set; }
        public string LanguageCode { get; set; }

        public string AlternativeCurrencyCode { get; set; }
        public decimal? AlternativeCurrencyTotalCharge { get; set; }
        public bool PaidInAlternativeCurrency { get; set; }
        public string Currency { get; set; }


        public string ServiceTypeCode { get; set; }

        public string CustomerReferenceNumber { get; set; }

        //Paypal Refund Information
        public string PP_RefundId { get; set; }
        public decimal? PP_RefundAmount { get; set; }
        public decimal? PP_RefundFee { get; set; }
        public string PP_RefundState { get; set; }
        public string PP_RefundLog { get; set; }
        public int PaxCount { get; set; }

    }
}
