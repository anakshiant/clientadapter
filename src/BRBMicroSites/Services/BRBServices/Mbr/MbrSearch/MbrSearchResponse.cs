using System;
using System.Collections.Generic;
using System.ComponentModel;
using BRBMicroSites.Util;
using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.Mbr.MbrSearch
{
    public class MbrSearchResponse
    {
        public int MbrId { get; set; }
        public string MbrStatusCode { get; set; }
        public string ProcessorLogin { get; set; }
        public string ServiceNumber { get; set; }
        public string MbrReportNumber { get; set; }
        public string AirlineConfirmationNumber { get; set; }
        public string FileReferenceNumber { get; set; }
        public int? AirlineId { get; set; }
        public string DaysToLoss { get; set; }
        public string PaymentFirstName { get; set; }
        public string PaymentLastName { get; set; }
        public string PaymentAddress { get; set; }
        public string PaymentCity { get; set; }
        public string PaymentStateCode { get; set; }
        public string PaymentStateName { get; set; }
        public string PaymentCountryCode { get; set; }
        public string PaymentZipCode { get; set; }
        public string PaymentPhone { get; set; }
        public string PaymentEmail { get; set; }
        public string RoutingNumber { get; set; }
        public string AccountNumber { get; set; }
        public string BankName { get; set; }
        public string PaymentType { get; set; }
        public string PaymentTypeName
        {
            get
            {
                bool result = Enum.TryParse<PaymentBy>(PaymentType, out PaymentBy paymentBy);
                return result ? paymentBy.GetEnumDescription() : string.Empty;
            }
        }
        public string FlightNumber { get; set; }
        public string AirlineName { get; set; }
        public DateTime? LocalFlightArrivalDate { get; set; }

        public string LocalFlightArrivalTime { get; set; }
        public string LocalTimeZoneCode { get; set; }
        public string PaxFirstName { get; set; }
        public string PaxLastName { get; set; }
        public string PaxAddress { get; set; }
        public string PaxCity { get; set; }
        public string PaxStateName { get; set; }
        public string PaxCountryName { get; set; }
        public string PaxZipCode { get; set; }
        public string PaxPhone { get; set; }
        public string PaxEmail { get; set; }
        public string DeliveryPlaceDate { get; set; }
        public string DeliveryPlaceNote { get; set; }
        public string HotelName { get; set; }
        public string PayPalFirstName { get; set; }
        public string PayPalLastName { get; set; }
        public string PayPalEmail { get; set; }
        public string EntrySource { get; set; }
        public string PIRUrl { get; set; }
        public string MbrCaseId { get; set; }
        public string AliPayAccount { get; set; }

        public bool Denied { get; set; }
        public string MbrDenialReasonText { get; set; }

        public Note Notes { get; set; }
        public List<MbrNote> MbrNote { get; set; }

        public MbrSearchResponse()
        {
            Notes = new Note();
            MbrNote = new List<MbrNote>();
        }
    }


    public class Note
    {
        public string MbrNotesHTML { get; set; }
        public string PaxNotes { get; set; }
        public string BaggageUpdate { get; set; }
        public List<string> PaxAttachList { get; set; }
    }

    public class MbrNote
    {
        public string Description { get; set; }
    }

    public enum PaymentBy
    {
        [Description("Check")]
        CHECK,
        [Description("PayPal")]
        PPAL,
        [Description("Wire Transfer")]
        WIRE,
        [Description("Alipay")]
        ALPAY
    }
}