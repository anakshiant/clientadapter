using System;
using BRBMicroSites.Libs.ApiClient;

namespace BRBMicroSites.Services.BRBServices.Data.Product
{
    [EndPoint("Data/GetProductList")]
    public class ProductRequest
    {
        public string CurrencyCode { get; set; }
    }
}