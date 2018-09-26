using System;
using System.Collections.Generic;
using System.Text;

namespace FbMessenger.Messaging
{
    /// <summary>
    /// Specifies the person's name
    /// </summary>
    public class RecipientName
    {
        /// <summary>
        /// Recipient First name
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Recipient Last name
        /// </summary>
        public string LastName { get; set; }
    }
}
