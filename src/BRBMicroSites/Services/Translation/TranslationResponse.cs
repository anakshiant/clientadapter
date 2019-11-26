using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRBMicroSites.Services.Translation
{
    public class TranslationResponse
    {
        public string Lang { get; set; }
        public Dictionary<string, string> Values { get; set; }

        public TranslationResponse()
        {
            Values = new Dictionary<string, string>();
        }
    }
}
