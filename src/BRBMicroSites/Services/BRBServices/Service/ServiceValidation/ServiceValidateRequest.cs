using BRBMicroSites.Libs.ApiClient;
using BRBMicroSites.Services.BRBServices.Service.Models;
using System;
using System.Collections.Generic;

namespace BRBMicroSites.Services.BRBServices.Service.ServiceValidation
{
    [EndPoint("Service/ValidateServicePurchase")]
    public class ServiceValidateRequest
    {
        public string UserLogin { get; set; }
        public string UserPassword { get; set; }
        public string AgentTypeCode { get; set; }
        public string AgentPCC { get; set; }
        public string AgentID { get; set; }
        public string ProductCode { get; set; }
        public bool IsInternational { get; set; }
        public string PromoCode { get; set; }
        public string ServiceAgreementPrefix { get; set; }
        public string PNRNumber { get; set; }
        public string FlightNumber { get; set; }
        public string LastFlightNumber { get; set; }
        public string DepartureDt { get; set; }
        public string LastArrivalDt { get; set; }
        public string ServiceTypeCode { get; set; }
        public string CustomerReferenceNumber { get; set; }
        public bool? ReplaceServiceNumberWithCRN { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public CheckoutInfoModel CheckoutInfo { get; set; }
        public List<PurchasePassengerModel> PassengerList { get; set; }
        public bool? SendPassengerConfirm { get; set; }
        public bool? SendAgentConfirm { get; set; }
        public string LanguageCode { get; set; }
        public string FlightDetails { get; set; }
        public string CurrencyCode { get; set; }

        public string AgentEmailSend { get; set; }
    }
}
