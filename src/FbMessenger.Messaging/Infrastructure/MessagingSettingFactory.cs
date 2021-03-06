﻿using Newtonsoft.Json;
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
