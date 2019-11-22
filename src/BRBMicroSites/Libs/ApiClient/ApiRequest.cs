using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRBMicroSites.Libs.ApiClient
{
    /// <summary>
    /// Api Request data
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiRequest<T>
    {
        public ApiRequest(string endPoint)
        {
            EndPoint = endPoint;
        }
        /// <summary>
        /// The endpoint to hit to api
        /// </summary>
        public string EndPoint { get; }
        /// <summary>
        /// Request data payload
        /// </summary>
        public T RequestData { get; set; }

    }
}
