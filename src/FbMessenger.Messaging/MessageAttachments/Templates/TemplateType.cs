using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum TemplateType
    {
        [EnumMember(Value = "generic")]
        Generic,
    }
}
