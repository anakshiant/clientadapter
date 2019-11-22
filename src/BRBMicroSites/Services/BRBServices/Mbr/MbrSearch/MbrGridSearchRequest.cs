using System;
using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.Mbr.MbrSearch
{
    [EndPoint("MBRSearch/MbrGridSearchResult")]
    public class MbrGridSearchRequest
    {
        public string MbrNumber { get; set; }
        public string ServiceNumber { get; set; }
        public string FileReferenceNumber { get; set; }
        public string BagTagNumber { get; set; }

    }
}