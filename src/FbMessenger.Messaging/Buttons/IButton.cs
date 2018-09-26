namespace FbMessenger.Messaging.Buttons
{
    /// <summary>
    /// Base interface for Button.
    /// </summary>
    public interface IButton
    {
        /// <summary>
        /// Specifies type of button.
        /// </summary>
        ButtonType Type { get; }
    }
}
