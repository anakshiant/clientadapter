using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BRBMicroSites.Services.BRBServices.ServiceAgreement;
using BRBMicroSites.Libs.ApiClient;
using Microsoft.Extensions.Logging;

namespace BRBMicroSites.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ServiceAgreementController : ControllerBase
    {
        private readonly IBRBClient _brbClient;
        private readonly ILogger<ServiceAgreementController> _logger;
        public ServiceAgreementController(IBRBClient brbClient, ILogger<ServiceAgreementController> logger)
        {
            _brbClient = brbClient;
            _logger = logger;
        }

        [HttpGet]
        public async Task<FileResult> Get()
        {
            var response = await _brbClient.Send<ServiceAgreementRequest, ServiceAgreementResponse>(new ServiceAgreementRequest
            {
                ApiToken = User.Identity.Name
            });

            if (response.Errors.Count() > 0)
            {
                return null;
            }

            byte[] rawData = Convert.FromBase64String(response.Data.RawData);

            return File(rawData, "application/pdf");
        }
    }
}