using System;
using FbMessengerClient.WebhookEvents.Messages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FbMessengerClient.WebhookEvents.Infrastructure.Converters
{
    /// <summary>
    /// 
    /// </summary>
    public class MessagingBaseConverter : JsonConverter
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(MessagingBase));
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            if (jo["message"] != null)
                return jo.ToObject<MessagingMessage>(serializer);

            return jo.ToObject<MessagingBase>(serializer);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }
    }
}
