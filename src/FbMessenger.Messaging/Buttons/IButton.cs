using System;
using System.Collections.Generic;
using System.Text;

namespace FbMessenger.Messaging.Buttons
{
    public interface IButton
    {
        ButtonType Type { get; }
    }
}
