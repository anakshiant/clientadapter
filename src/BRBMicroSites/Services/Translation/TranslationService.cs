using System.Globalization;

namespace BRBMicroSites.Services.Translation
{
    public class TranslationService : ITranslationService
    {
        public string Translate(string key, string lang)
        {
            return BRB.Resources.Translation.ResourceManager.GetString(key, new CultureInfo(lang));
        }
    }
}
