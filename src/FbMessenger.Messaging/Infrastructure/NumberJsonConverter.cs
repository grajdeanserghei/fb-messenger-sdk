using System;
using Newtonsoft.Json;

namespace FbMessenger.Messaging.Infrastructure
{
    /// <summary>
    /// JSON converter that mimics Javascript Number behaviour: 
    /// serializes <see cref="double"/>, 
    /// <see cref="float"/> and <see cref="decimal"/>
    /// to 1 instead of 1.0 if the value is integer.
    /// </summary>
    public class NumberJsonConverter : JsonConverter
    {
        /// <summary>
        /// Can't read values because the intent of the converter
        /// is only to serialize to JSON.
        /// </summary>
        public override bool CanRead
        {
            get
            {
                return false;
            }
        }

        /// <summary>
        /// Read operation is not supported and should not be called.
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

        /// <summary>
        /// Returns true if Type is one of
        /// <see cref="double"/>, 
        /// <see cref="float"/> and <see cref="decimal"/>.
        /// </summary>
        /// <param name="objectType"></param>
        /// <returns></returns>
        public override bool CanConvert(Type objectType)
        {
            return (objectType == typeof(decimal) || objectType == typeof(float) || objectType == typeof(double));
        }

        /// <summary>
        /// Converts float pointing values to 
        /// JS Number representation
        /// </summary>
        /// <param name="writer"></param>
        /// <param name="value"></param>
        /// <param name="serializer"></param>
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            if (IsWholeValue(value))
            {
                writer.WriteRawValue(JsonConvert.ToString(Convert.ToInt64(value)));
            }
            else
            {
                writer.WriteRawValue(JsonConvert.ToString(value));
            }
        }

        private static bool IsWholeValue(object value)
        {
            if (value is decimal)
            {
                decimal decimalValue = (decimal)value;
                int precision = (decimal.GetBits(decimalValue)[3] >> 16) & 0x000000FF;
                return precision == 0;
            }
            else if (value is float || value is double)
            {
                double doubleValue = (double)value;
                return doubleValue == Math.Truncate(doubleValue);
            }

            return false;
        }
    }
}
