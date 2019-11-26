using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BRBMicroSites.Services.Translation
{
    public class TranslationRequest
    {
        public string Lang { get; set; }
        public List<string> Keys { get; set; }

        public TranslationRequest()
        {
            Keys = new List<string>();
        }
    }
}
