using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FbMessenger.WebhookEvents.Messages;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace FbMessenger.WebhookEvents.Infrastructure.Converters
{
    /// <summary>
    /// Converts <see cref="IPayload"/> to concrete objects.
    /// </summary>
    public class PayloadConverter : JsonConverter
    {
        private static readonly string[] MultimediaTypes = new[]
            {
                "image",
                "audio",
                "video",
                "file"
            };

        public override bool CanConvert(Type objectType)
        {
            return objectType == typeof(IPayload);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            JObject jo = JObject.Load(reader);
            if (jo["url"] != null)
            {
                return jo.ToObject<MultumediaPayload>(serializer);
            }
            else if(jo["location"] != null)
            {
                return jo.ToObject<LocationPayload>(serializer);
            }

            throw new InvalidOperationException($"Unable to deserialize messaging payload.");
        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotSupportedException();
        }
    }
}
