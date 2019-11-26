using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRBMicroSites.Services.HostTokenMapService;
using System.Security.Claims;
using System.Web;

namespace BRBMicroSites.Auth
{
    public class AuthenticationHandler : IAuthenticationHandler
    {
        string host;
        private readonly IHostTokenMapService _hostTokenMapService;
        public AuthenticationHandler(IHostTokenMapService hostTokenMapService)
        {
            _hostTokenMapService = hostTokenMapService;
        }

        public async Task<AuthenticateResult> AuthenticateAsync()
        {
            string token = await _hostTokenMapService.GetToken(host);
            var claimIdentity = new ClaimsIdentity("BRB");
            claimIdentity.AddClaim(new Claim(ClaimTypes.Name, token));

            AuthenticationTicket ticket = new AuthenticationTicket(new ClaimsPrincipal(claimIdentity), "BRB");

            return AuthenticateResult.Success(ticket);
        }

        public Task ChallengeAsync(AuthenticationProperties properties)
        {
            throw new NotImplementedException();
        }

        public Task ForbidAsync(AuthenticationProperties properties)
        {
            throw new NotImplementedException();
        }

        public Task InitializeAsync(AuthenticationScheme scheme, HttpContext context)
        {
            host = context.Request.Headers["ClientHost"];
            return Task.CompletedTask;
        }
    }
}
