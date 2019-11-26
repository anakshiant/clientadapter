using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BRBMicroSites.Services.Translation;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BRBMicroSites.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TranslationController : ControllerBase
    {
        private readonly ITranslationService _translationService;

        public TranslationController(ITranslationService translationService)
        {
            _translationService = translationService;
        }

        [HttpPost]
        public TranslationResponse Get(TranslationRequest translationRequest)
        {
            TranslationResponse response = new TranslationResponse()
            {
                Lang = translationRequest.Lang
            };

            response.Values = translationRequest.Keys.Aggregate(new Dictionary<string, string>(), (accumlater, key) =>
              {
                  string value = _translationService.Translate(key, translationRequest.Lang);
                  accumlater.Add(key, value);
                  return accumlater;
              });

            return response;
        }
    }
}