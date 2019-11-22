using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BRBMicroSites.Libs.ApiClient
{
    /// <summary>
    /// End point attribute
    /// </summary>
    public class EndPointAttribute : Attribute
    {
        /// <summary>
        /// Endpont to hit
        /// </summary>
        public string Endpoint { get; }

        public EndPointAttribute(string endPoint)
        {
            Endpoint = endPoint;
        }
    }
}
