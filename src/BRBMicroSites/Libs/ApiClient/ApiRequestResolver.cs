using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRBMicroSites.Libs.ApiClient
{
    /// <summary>
    /// Resolve the Api REquest object with endpoint
    /// </summary>
    public class ApiRequestResolver
    {
        /// <summary>
        /// Create an api request object with the endpoint provided by requet object
        /// </summary>
        /// <typeparam name="T">Request payload</typeparam>
        /// <param name="requestData">Request payload</param>
        /// <returns></returns>
        public static ApiRequest<T> Resolve<T>(T requestData)
        {
            var requestDataType = typeof(T);

            Attribute[] attributes = Attribute.GetCustomAttributes(requestDataType);

            string endPoint = attributes
                .ToList()
                .Where(attribute => attribute is EndPointAttribute)
                .Select(attribute => ((EndPointAttribute)attribute).Endpoint)
                .First();

            return new ApiRequest<T>(endPoint)
            {
                RequestData = requestData
            };
        }
    }
}
