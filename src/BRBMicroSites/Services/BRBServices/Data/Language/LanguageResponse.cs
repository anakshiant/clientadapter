using System;
using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.Data.Language
{
    public class LanguageResponse
    {
        public string LanguageCode { get; set; }
        public string LanguageName { get; set; }
        public string Direction { get; set; }
    }
}