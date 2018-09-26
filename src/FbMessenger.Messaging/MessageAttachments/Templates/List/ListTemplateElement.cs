namespace FbMessenger.Messaging.MessageAttachments.Templates
{
    /// <summary>
    /// Element of List template
    /// Has same properties as <see cref="BaseTemplateElement"/> but 
    /// applies different rules.
    /// 1. Element must also have one or both of image_url or subtitle set.
    /// 2. DefaultAction only allowed when messenger_extensions property is set to true
    /// </summary>
    public class ListTemplateElement : BaseTemplateElement
    {
    }
}