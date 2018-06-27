/* 
 * Fortify on Demand Web API Explorer
 *
 * No description provided (generated by Swagger Codegen https://github.com/swagger-api/swagger-codegen)
 *
 * OpenAPI spec version: v3
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = FortifyAPI.Client.SwaggerDateConverter;

namespace FortifyAPI.Model
{
    /// <summary>
    /// Audit Comment
    /// </summary>
    [DataContract]
    public partial class AuditComment :  IEquatable<AuditComment>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AuditComment" /> class.
        /// </summary>
        /// <param name="Username">The user name.</param>
        /// <param name="CommentDate">The comment date.</param>
        /// <param name="Comment">The audit comment.</param>
        public AuditComment(string Username = default(string), DateTime? CommentDate = default(DateTime?), string Comment = default(string))
        {
            this.Username = Username;
            this.CommentDate = CommentDate;
            this.Comment = Comment;
        }
        
        /// <summary>
        /// The user name
        /// </summary>
        /// <value>The user name</value>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// The comment date
        /// </summary>
        /// <value>The comment date</value>
        [DataMember(Name="commentDate", EmitDefaultValue=false)]
        public DateTime? CommentDate { get; set; }

        /// <summary>
        /// The audit comment
        /// </summary>
        /// <value>The audit comment</value>
        [DataMember(Name="comment", EmitDefaultValue=false)]
        public string Comment { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AuditComment {\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  CommentDate: ").Append(CommentDate).Append("\n");
            sb.Append("  Comment: ").Append(Comment).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AuditComment);
        }

        /// <summary>
        /// Returns true if AuditComment instances are equal
        /// </summary>
        /// <param name="input">Instance of AuditComment to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AuditComment input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && 
                (
                    this.CommentDate == input.CommentDate ||
                    (this.CommentDate != null &&
                    this.CommentDate.Equals(input.CommentDate))
                ) && 
                (
                    this.Comment == input.Comment ||
                    (this.Comment != null &&
                    this.Comment.Equals(input.Comment))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.CommentDate != null)
                    hashCode = hashCode * 59 + this.CommentDate.GetHashCode();
                if (this.Comment != null)
                    hashCode = hashCode * 59 + this.Comment.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}