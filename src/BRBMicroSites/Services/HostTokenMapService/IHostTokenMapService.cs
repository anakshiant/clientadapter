using System;
using System.Threading.Tasks;

namespace BRBMicroSites.Services.HostTokenMapService
{
    public interface IHostTokenMapService
    {
        Task<string> GetToken(string host);
        Task AddToken(string host, string token);
    }
}