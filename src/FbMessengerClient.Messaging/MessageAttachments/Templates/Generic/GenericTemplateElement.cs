using System;
using System.Collections.Generic;
using System.Text;
using FbMessengerClient.Messaging.Buttons;
using Newtonsoft.Json;

namespace FbMessengerClient.Messaging.MessageAttachments.Templates.Generic
{
    public class GenericTemplateElement
    {
        /// <summary>
        /// The title to display in the template. 
        /// 80 character limit.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// <strong>Optional.</strong> The URL of the image to 
        /// display in the template.
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// <strong>Optional.</strong> The subtitle to display in 
        /// the template. 80 character limit.
        /// </summary>
        public string Subtitle { get; set; }

        /// <summary>
        /// <strong>Optional.</strong> The default action executed when 
        /// the template is tapped. Accepts the same 
        /// properties as URL button, except title.
        /// </summary>
        [JsonProperty("default_action")]
        public UrlButtonDefault DefaultAction { get; set; }

        /// <summary>
        /// <strong>Optional.</strong> An array of buttons to append 
        /// to the template. A maximum of 3 
        /// buttons per element is supported.
        /// </summary>
        public IButton[] Buttons { get; set; }
    }
}
