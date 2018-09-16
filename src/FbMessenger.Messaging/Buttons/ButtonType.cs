﻿using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace FbMessenger.Messaging.Buttons
{
    /// <summary>
    /// Defines available button types
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ButtonType
    {
        /// <summary>
        /// Button for <see cref="UrlButton"/> and <see cref="UrlButtonDefault"/>
        /// </summary>
        [EnumMember(Value = "web_url")]
        WebUrl,

    }
}
