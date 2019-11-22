using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BRBMicroSites.Libs.ApiClient
{
    /// <summary>
    /// BRB http client interface
    /// </summary>
    public interface IBRBClient
    {
        Task<ApiResponse<TResponseData>> Send<TRequestData, TResponseData>(TRequestData request, CancellationToken cancellationToken = default(CancellationToken));
        Task<string> SendRequestForMultiPartFormData(MultipartFormDataContent form, string url, CancellationToken cancellationToken = default(CancellationToken));
    }
}
