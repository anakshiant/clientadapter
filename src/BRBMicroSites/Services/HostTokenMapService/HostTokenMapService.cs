using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRBMicroSites.Services.HostTokenMapService
{
    public class HostTokenMapService : IHostTokenMapService
    {
        private readonly List<HostTokenMap> _hosts = new List<HostTokenMap>();

        public HostTokenMapService(IOptions<List<HostTokenMap>> hosts)
        {
            _hosts = hosts.Value;
        }

        public Task AddToken(string host, string token)
        {
            throw new NotImplementedException();
        }

        public Task<string> GetToken(string host)
        {
            HostTokenMap hostToken = _hosts
                .Where(h => h.Host.Equals(host, StringComparison.OrdinalIgnoreCase))
                .FirstOrDefault();

            if (hostToken == null)
            {
                return Task.FromResult(string.Empty);
            }
            else
            {
                return Task.FromResult(hostToken.Token);
            }
        }
    }
}