using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.Service.ServiceInfo
{
    [EndPoint("Service/FetchServiceInformation")]
    public class FetchServiceInformationRequest
    {
        public string ServiceNumber { get; set; }
    }
}
