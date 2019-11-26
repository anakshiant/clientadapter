using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRBMicroSites.Services.Translation
{
    public interface ITranslationService
    {
        string Translate(string key, string lang);
    }
}
