using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.PayPal.PaypalPaymentCreation
{
    [EndPoint("Paypal/CreatePayment")]
    public class PaypalCreatePaymentRequest
    {
        public string ServiceNumber { get; set; }
        public string ReturnUrl { get; set; }
    }
}
