using System;
using Newtonsoft.Json;

namespace FbMessenger.Messaging.Infrastructure
{
    /// <summary>
    /// Calls ToString method on object. 
    /// Required in cases when JSON should 
    /// keep numeric values as string.
    /// e.g. {value: "1"}
    /// </summary>
    public class ToStringConverter : JsonConverter
    {
        /// <summary>
        /// Always return true because all .NET objects 
        /// have ToString methond.
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return true;
        }

        /// <summary>
        /// Calls ToString method on object
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            writer.WriteValue(value.ToString());
        }

        /// <summary>
        /// Returns false because is intended 
        /// only for serialization
        /// </summary>
        public override bool CanRead
        {
            get { return false; }
        }

        /// <summary>
        /// Not supported operation. Should not be called.
        /// </summary>
        /// <param name="reader"></param>
        /// <param name="objectType"></param>
        /// <param name="existingValue"></param>
        /// <param name="serializer"></param>
        /// <returns></returns>
        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            throw new NotSupportedException("Converter supports only write operations.");
        }
    }
}
