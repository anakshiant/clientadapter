using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.PayPal.PaypalSuccessFull
{
    [EndPoint("Paypal/PaymentSuccessful")]
    public class PaypalPaymentSuccessfulRequest
    {
        public string paymentId { get; set; }
        public string token { get; set; }
        public string PayerId { get; set; }
    }
}
