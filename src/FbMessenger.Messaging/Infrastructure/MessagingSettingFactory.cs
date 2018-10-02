using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FbMessenger.Messaging.Infrastructure
{
    /// <summary>
    /// Create Json serialization settings for models serialization.
    /// </summary>
    public class MessagingSettingFactory
    {
        public JsonSerializerSettings GetSettings()
        {
            return GetDefaultSettings();
        }

        /// <summary>
        /// Create <see cref="JsonSerializerSettings"/> 
        /// to serialize Messaging models.
        /// </summary>
        /// <returns></returns>
        public static JsonSerializerSettings GetDefaultSettings()
        {
            var contractResolver = new DefaultContractResolver
            {
                NamingStrategy = new SnakeCaseNamingStrategy()
            };
            var settings = new JsonSerializerSettings
            {
                ContractResolver = contractResolver,
                NullValueHandling = NullValueHandling.Ignore,
            };

            settings.Converters.Add(new NumberJsonConverter());

            return settings;
        }
    }
}
