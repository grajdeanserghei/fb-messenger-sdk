using System;
using System.Collections.Generic;
using System.Text;

namespace FbMessengerClient.Messaging.Buttons
{
    public interface IButton
    {
        ButtonType Type { get; }
    }
}
