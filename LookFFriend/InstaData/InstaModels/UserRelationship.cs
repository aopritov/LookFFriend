using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InstaData.InstaModels
{
        /// <summary>
        /// User Information
        /// </summary>
        public class Relationship
        {
            /// <summary>
            /// Id
            /// </summary>
            [Key]
            [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
            public long RelationshipId { get; set; }
            /// <summary>
            /// Reference to User who makes the action
            /// </summary>
            [Required]
            // foreign key
            [ForeignKey("UserSubjectId")]
            public User UserSubject { get; set; }
            public long UserObjectId { get; set; }
            public long UserSubjectId { get; set; }
            /// <summary>
            /// Reference to User who is influenced by the action
            /// </summary>
            [Required]
            // foreign key
            [ForeignKey("UserObjectId")]
            public User UserObject { get; set; }
            /// <summary>
            /// Date of following
            /// </summary>
            [Required]
            public DateTime? FollowedDate { get; set; }
            public DateTime? UnfollowedDate { get; set; }
        }
}
