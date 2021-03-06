﻿namespace FbMessenger.Messaging.Buttons
{
    /// <summary>
    /// The URL Button opens a web page in the Messenger webview.
    /// </summary>
    public class UrlButtonDefault : IButton
    {
        /// <summary>
        /// Type of button. Must be web_url.
        /// </summary>
        public ButtonType Type => ButtonType.WebUrl;

        /// <summary>
        /// This URL is opened in a mobile browser 
        /// when the button is tapped. 
        /// Must use HTTPS protocol if 
        /// messenger_extensions is true.
        /// </summary>
        public string Url { get; set; }

        /// <summary>
        /// Optional. Height of the Webview. 
        /// Valid values: compact, tall, full. 
        /// Defaults to full.
        /// </summary>
        public WebviewHeightRatioType? WebviewHeightRatio { get; set; }

        /// <summary>
        /// Optional. Must be true if using Messenger Extensions.
        /// </summary>
        public bool? MessengerExtensions { get; set; }

        /// <summary>
        /// The URL to use on clients that 
        /// don't support Messenger Extensions. 
        /// If this is not defined, 
        /// the url will be used as the fallback. 
        /// It may only be specified if 
        /// messenger_extensions is true.
        /// </summary>
        public string FallbackUrl { get; set; }

        /// <summary>
        /// Optional. Set to hide to disable the share 
        /// button in the Webview (for sensitive info). 
        /// This does not affect any shares 
        /// initiated by the developer using Extensions.
        /// </summary>
        public WebviewShareButtonType? WebviewShareButton { get; set; }
    }
}
