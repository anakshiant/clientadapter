using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.Service.ServiceAgentMail
{
    [EndPoint("Mbr/CheckAgentMailConfirmation")]
    public class ServiceAgentMailRequest
    {
        public string ServiceNumber { get; set; }
    }
}
