using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRBMicroSites.Libs.ApiClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BRBMicroSites.Services.BRBServices.Mbr.MbrSearch;
using BRBMicroSites.Services.BRBServices.Mbr.MbrFiling;

namespace BRBMicroSites.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MbrController : ControllerBase
    {

        private readonly ILogger<MbrController> _logger;
        private readonly IBRBClient _brbClient;

        public MbrController(IBRBClient brbClient, ILogger<MbrController> logger)
        {
            _brbClient = brbClient;
            _logger = logger;
        }

        [HttpGet]
        [Route("{MbrId}")]
        public async Task<ApiResponse<MbrSearchResponse>> Get([FromRoute] MbrSearchRequest mbrSearchRequest)
        {
            return await _brbClient.Send<MbrSearchRequest, MbrSearchResponse>(mbrSearchRequest);
        }

        [HttpGet]
        public async Task<ApiResponse<MbrGridSearchResponse>> Get([FromQuery] MbrGridSearchRequest mbrGridSearchRequest)
        {
            return await _brbClient.Send<MbrGridSearchRequest, MbrGridSearchResponse>(mbrGridSearchRequest);
        }

        [HttpPost]
        public async Task<ApiResponse<MbrFilingResponse>> Post([FromBody] MbrFilingRequest mbrFilingRequest)
        {
            return await _brbClient.Send<MbrFilingRequest, MbrFilingResponse>(mbrFilingRequest);
        }
    }
}
