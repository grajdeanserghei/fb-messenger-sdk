using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace FbMessenger.Messaging.Infrastructure
{
    /// <summary>
    /// Create Json serialization settings for models serialization.
    /// </summary>
    public class MessagingSettingFactory
    {
        /// <summary>
        /// Create <see cref="JsonSerializerSettings"/> 
        /// to serialize Messaging models.
        /// </summary>
        /// <returns></returns>
        public JsonSerializerSettings GetSettings()
        {
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                NullValueHandling = NullValueHandling.Ignore
            };

            return settings;
        }
    }
}
