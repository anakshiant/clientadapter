using System;
using System.Threading.Tasks;

namespace BRBMicroSites.Services.HostTokenMapService
{
    public interface IHostTokenMapService
    {
        string GetToken(string host);
        void AddToken(string host, string token);
    }
}