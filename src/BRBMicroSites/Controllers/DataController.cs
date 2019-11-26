using System.Collections.Generic;
using System.Threading.Tasks;
using BRBMicroSites.Libs.ApiClient;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BRBMicroSites.Services.BRBServices.Data.Product;
using BRBMicroSites.Services.BRBServices.Data.Airline;
using BRBMicroSites.Services.BRBServices.Data.Country;
using BRBMicroSites.Services.BRBServices.Data.Language;
using BRBMicroSites.Services.BRBServices.Data.State;

namespace BRBMicroSites.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DataController : ControllerBase
    {

        private readonly ILogger<DataController> _logger;
        private readonly IBRBClient _brbClient;

        public DataController(IBRBClient brbClient, ILogger<DataController> logger)
        {
            _brbClient = brbClient;
            _logger = logger;
        }

        [HttpGet]
        [Route("product")]
        public async Task<ApiResponse<List<ProductResponse>>> Product()
        {
            return await _brbClient.Send<ProductRequest, List<ProductResponse>>(new ProductRequest());
        }

        [HttpGet]
        [Route("airline")]
        public async Task<ApiResponse<List<AirlineResponse>>> Airline()
        {
            return await _brbClient.Send<AirlineRequest, List<AirlineResponse>>(new AirlineRequest());
        }

        [HttpGet]
        [Route("language")]
        public async Task<ApiResponse<List<LanguageResponse>>> Language()
        {
            return await _brbClient.Send<LanguageRequest, List<LanguageResponse>>(new LanguageRequest());
        }


        [HttpGet]
        [Route("country")]
        public async Task<ApiResponse<List<CountryResponse>>> Country()
        {
            return await _brbClient.Send<CountryRequest, List<CountryResponse>>(new CountryRequest());
        }

        [HttpGet]
        [Route("state")]
        public async Task<ApiResponse<List<StateResponse>>> State()
        {
            return await _brbClient.Send<StateRequest, List<StateResponse>>(new StateRequest());
        }

    }
}
