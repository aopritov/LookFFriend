using System;
using System.ComponentModel.DataAnnotations;
using InstaData.Enum;

namespace InstaData.InstaModels
{
        /// <summary>
        /// User Information
        /// </summary>
        public class User
        {
            /// <summary>
            /// Gets or sets the identifier.
            /// </summary>
            /// <value>
            /// The identifier.
            /// </value>
            public long UserId { get; set; }
            /// <summary>
            /// Gets or sets the username.
            /// </summary>
            /// <value>
            /// The username.
            /// </value>
            public string Username { get; set; }
            /// <summary>
            /// Gets or sets the status of relationship
            /// </summary>
            public CommonStatus Status { get; set; }
        }
}
