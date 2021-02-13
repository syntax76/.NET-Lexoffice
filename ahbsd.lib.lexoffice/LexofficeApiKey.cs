using System;
using ahbsd.lib.ApiKey;

namespace ahbsd.lib.lexoffice
{
    /// <summary>
    /// Speziell für LexOffice zu verwendender API-Schlüssel.
    /// </summary>
    /// <remarks>Schlüssel im <see cref="string"/>-Format; siehe <see cref="ApiKeyEventHandler{T}"/>.</remarks>
    public class LexofficeApiKey : ApiKeyHolder<string>
    {
        /// <summary>
        /// Konstruktor ohne Parameter.
        /// </summary>
        public LexofficeApiKey()
            : base()
        { }

        /// <summary>
        /// Konstruktor mit Angabe eines API-Schlüssels.
        /// </summary>
        /// <param name="apiKey"></param>
        public LexofficeApiKey(string apiKey)
            : base(apiKey)
        { }

        /// <summary>
        /// Konstruktor mit Angabe eines anderen <see cref="LexofficeApiKey"/>.
        /// </summary>
        /// <param name="appKey">Anderer <see cref="LexofficeApiKey"/>.</param>
        public LexofficeApiKey(LexofficeApiKey appKey)
            : base(appKey.ApiKey)
        { }
    }
}
