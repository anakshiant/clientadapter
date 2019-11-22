using System;
using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.Mbr.MbrSearch
{
    [EndPoint("MBRSearch/GetMbrDetails")]
    public class MbrSearchRequest
    {
        public int MbrId { get; set; }
    }
}