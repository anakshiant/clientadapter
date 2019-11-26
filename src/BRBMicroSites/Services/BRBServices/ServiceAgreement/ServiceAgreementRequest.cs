using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.ServiceAgreement
{
    [EndPoint("Service/ServiceAgreementDoc")]
    public class ServiceAgreementRequest
    {
        public string ApiToken { get; set; }
    }
}
