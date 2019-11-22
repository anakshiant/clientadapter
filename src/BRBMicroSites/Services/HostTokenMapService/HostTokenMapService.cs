using System;
using System.Collections.Generic;
using System.Linq;

namespace BRBMicroSites.Services.HostTokenMapService
{
    public class HostTokenMapService : IHostTokenMapService
    {
        private readonly List<HostTokenMap> _hosts = new List<HostTokenMap>{
            new HostTokenMap{Host="www.smilebox.com",Token="TT1/QTc1QUYzQjktNjk5Ni00RTI1LUI0ODUtRjlDRkM4MUMzOUVC"}
        };

        public void AddToken(string host, string token)
        {
            throw new NotImplementedException();
        }

        public string GetToken(string host)
        {
            return _hosts.First().Token;
        }
    }
}