using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Threading;


namespace BRBMicroSites.Libs.ApiClient
{
    /// <summary>
    /// BRB api client
    /// </summary>
    public class BRBClient : IBRBClient
    {
        /// <summary>
        /// Http client
        /// </summary>
        private HttpClient _httpClient;
        public BRBClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        /// <summary>
        /// Send the request to server and return response
        /// </summary>
        /// <typeparam name="TRequestData">Request Data Payload</typeparam>
        /// <typeparam name="TResponseData">Api Response Data</typeparam>
        /// <param name="request">Request</param>
        /// <returns>Api response data</returns>
        public async Task<ApiResponse<TResponseData>> Send<TRequestData, TResponseData>(TRequestData request, CancellationToken cancellationToken = default(CancellationToken))
        {
            ApiRequest<TRequestData> apiRequest = ApiRequestResolver.Resolve(request);
            ApiResponse<TResponseData> response = null;
            cancellationToken.ThrowIfCancellationRequested();
            try
            {
                var responseMessage = await _httpClient.PostAsJsonAsync(apiRequest.EndPoint, apiRequest.RequestData, cancellationToken);

                if (!responseMessage.IsSuccessStatusCode)
                {
                    throw new Exception(responseMessage.StatusCode.ToString());
                }

                response = await responseMessage.Content.ReadAsAsync<ApiResponse<TResponseData>>(cancellationToken);

            }
            catch (Exception exception)
            {
                throw exception;
            }

            return response;
        }


        public async Task<string> SendRequestForMultiPartFormData(MultipartFormDataContent form, string url, CancellationToken cancellationToken = default(CancellationToken))
        {
            cancellationToken.ThrowIfCancellationRequested();
            var response = await _httpClient.PostAsync(url, form);
            var responseString = await response.Content.ReadAsStringAsync();
            return responseString;
        }

    }
}
