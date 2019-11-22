using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRBMicroSites.Libs.ApiClient
{
    /// <summary>
    /// Api Response returned by server
    /// </summary>
    /// <typeparam name="T">Response data</typeparam>
    public class ApiResponse<T>
    {
        /// <summary>
        /// Status Returned
        /// </summary>
        public bool Status { get; set; }
        /// <summary>
        /// Response Data
        /// </summary>
        public T Data { get; set; }
        /// <summary>
        /// List of api errors
        /// </summary>
        public List<ApiError> Errors { get; set; }
    }

    public class ApiError
    {
        public string ErrorMessage { get; set; }
    }
}
