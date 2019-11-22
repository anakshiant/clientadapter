using System;
using System.Collections.Generic;
using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.Mbr.MbrFiling
{
    [EndPoint("MBR/FileMbr")]
    public class MbrFilingRequest
    {
        public bool SendSMSNotification { get; set; }
        public string FlightNumber { get; set; }
        public int? AirlineId { get; set; }
        public string AirlineConfirmationNumber { get; set; }
        public bool IsSwiftCode { get; set; }
        public DateTime? LocalFlightArrivalDate { get; set; }
        public string LocalFlightArrivalTime { get; set; }
        public string LocalTimeZoneCode { get; set; }
        public string FileReferenceNumber { get; set; }
        public byte LostBags { get; set; }
        public string ServiceNumber { get; set; }
        public string PaxFirstName { get; set; }
        public string PaxLastName { get; set; }
        public string PaxAddress { get; set; }
        public string PaxCity { get; set; }
        public string PaxStateCode { get; set; }
        public string PaxStateName { get; set; }
        public string PaxCountryCode { get; set; }
        public string PaxZipCode { get; set; }
        public string PaxPhone { get; set; }
        public string PaxEmail { get; set; }
        public string PaxConfirmEmail { get; set; }

        public List<MbrFilingBagModel> BagList { get; set; }
        public List<MbrFilingContactModel> MbrContactList { get; set; }

        public string PaymentCode { get; set; }
        public string PaymentFirstName { get; set; }
        public string PaymentLastName { get; set; }
        public string PaymentAddress { get; set; }
        public string PaymentCity { get; set; }
        public string PaymentStateCode { get; set; }
        public string PaymentCountryCode { get; set; }
        public string PaymentZipCode { get; set; }
        public string PaymentStateName { get; set; }
        public string PaymentPhone { get; set; }
        public string PaymentEmail { get; set; }
        public string PaymentConfirmEmail { get; set; }
        public string BankName { get; set; }
        public string RoutingNumber { get; set; }
        public string AccountNumber { get; set; }

        public string PayPalFirstName { get; set; }
        public string PayPalLastName { get; set; }
        public string PayPalEmail { get; set; }
        public string AlipayAccount { get; set; }
        public string EntrySource { get; set; }
        public string LanguageCode { get; set; }
        public string DeliveryPlaceNote { get; set; }
        public int? PirUploadFileId { get; set; }

    }
    public class MbrFilingBagModel
    {
        public string BagTagNumber { get; set; }
        public byte OrderSequence { get; set; }
    }
    public class MbrFilingContactModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public int OrderSequence { get; set; }
    }
}