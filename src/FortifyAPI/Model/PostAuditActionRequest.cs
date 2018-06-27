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
    /// Post Audit Action Request
    /// </summary>
    [DataContract]
    public partial class PostAuditActionRequest :  IEquatable<PostAuditActionRequest>, IValidatableObject
    {
        /// <summary>
        /// The audit action
        /// </summary>
        /// <value>The audit action</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuditActionEnum
        {
            
            /// <summary>
            /// Enum Cancel for value: Cancel
            /// </summary>
            [EnumMember(Value = "Cancel")]
            Cancel = 1,
            
            /// <summary>
            /// Enum Start for value: Start
            /// </summary>
            [EnumMember(Value = "Start")]
            Start = 2,
            
            /// <summary>
            /// Enum Submit for value: Submit
            /// </summary>
            [EnumMember(Value = "Submit")]
            Submit = 3
        }

        /// <summary>
        /// The audit action
        /// </summary>
        /// <value>The audit action</value>
        [DataMember(Name="auditAction", EmitDefaultValue=false)]
        public AuditActionEnum AuditAction { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuditActionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostAuditActionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostAuditActionRequest" /> class.
        /// </summary>
        /// <param name="AuditAction">The audit action (required).</param>
        public PostAuditActionRequest(AuditActionEnum AuditAction = default(AuditActionEnum))
        {
            // to ensure "AuditAction" is required (not null)
            if (AuditAction == null)
            {
                throw new InvalidDataException("AuditAction is a required property for PostAuditActionRequest and cannot be null");
            }
            else
            {
                this.AuditAction = AuditAction;
            }
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostAuditActionRequest {\n");
            sb.Append("  AuditAction: ").Append(AuditAction).Append("\n");
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
            return this.Equals(input as PostAuditActionRequest);
        }

        /// <summary>
        /// Returns true if PostAuditActionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostAuditActionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostAuditActionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AuditAction == input.AuditAction ||
                    (this.AuditAction != null &&
                    this.AuditAction.Equals(input.AuditAction))
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
                if (this.AuditAction != null)
                    hashCode = hashCode * 59 + this.AuditAction.GetHashCode();
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