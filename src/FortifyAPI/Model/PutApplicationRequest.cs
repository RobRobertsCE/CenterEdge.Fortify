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
    /// Put Application Request
    /// </summary>
    [DataContract]
    public partial class PutApplicationRequest :  IEquatable<PutApplicationRequest>, IValidatableObject
    {
        /// <summary>
        /// The business criticality type
        /// </summary>
        /// <value>The business criticality type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum BusinessCriticalityTypeEnum
        {
            
            /// <summary>
            /// Enum High for value: High
            /// </summary>
            [EnumMember(Value = "High")]
            High = 1,
            
            /// <summary>
            /// Enum Medium for value: Medium
            /// </summary>
            [EnumMember(Value = "Medium")]
            Medium = 2,
            
            /// <summary>
            /// Enum Low for value: Low
            /// </summary>
            [EnumMember(Value = "Low")]
            Low = 3
        }

        /// <summary>
        /// The business criticality type
        /// </summary>
        /// <value>The business criticality type</value>
        [DataMember(Name="businessCriticalityType", EmitDefaultValue=false)]
        public BusinessCriticalityTypeEnum BusinessCriticalityType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PutApplicationRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PutApplicationRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PutApplicationRequest" /> class.
        /// </summary>
        /// <param name="ApplicationName">The application title (required).</param>
        /// <param name="ApplicationDescription">Description of the application that will help you manage multiple applications.</param>
        /// <param name="EmailList">List the email addresses of additional people who should be informed of activity related to this release. Separate multiple email addresses with a semicolon or comma.</param>
        /// <param name="Attributes">Application attributes. This is an array of key/value objects. Example, [{\&quot;Attribute 1\&quot;: \&quot;value 1\&quot;}, {\&quot;Attribute 2\&quot;: \&quot;value 2\&quot;}, {\&quot;Attribute 3\&quot;: \&quot;value 3\&quot;} ].</param>
        /// <param name="BusinessCriticalityType">The business criticality type (required).</param>
        public PutApplicationRequest(string ApplicationName = default(string), string ApplicationDescription = default(string), string EmailList = default(string), List<ApplicationAttribute> Attributes = default(List<ApplicationAttribute>), BusinessCriticalityTypeEnum BusinessCriticalityType = default(BusinessCriticalityTypeEnum))
        {
            // to ensure "ApplicationName" is required (not null)
            if (ApplicationName == null)
            {
                throw new InvalidDataException("ApplicationName is a required property for PutApplicationRequest and cannot be null");
            }
            else
            {
                this.ApplicationName = ApplicationName;
            }
            // to ensure "BusinessCriticalityType" is required (not null)
            if (BusinessCriticalityType == null)
            {
                throw new InvalidDataException("BusinessCriticalityType is a required property for PutApplicationRequest and cannot be null");
            }
            else
            {
                this.BusinessCriticalityType = BusinessCriticalityType;
            }
            this.ApplicationDescription = ApplicationDescription;
            this.EmailList = EmailList;
            this.Attributes = Attributes;
        }
        
        /// <summary>
        /// The application title
        /// </summary>
        /// <value>The application title</value>
        [DataMember(Name="applicationName", EmitDefaultValue=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Description of the application that will help you manage multiple applications
        /// </summary>
        /// <value>Description of the application that will help you manage multiple applications</value>
        [DataMember(Name="applicationDescription", EmitDefaultValue=false)]
        public string ApplicationDescription { get; set; }

        /// <summary>
        /// List the email addresses of additional people who should be informed of activity related to this release. Separate multiple email addresses with a semicolon or comma
        /// </summary>
        /// <value>List the email addresses of additional people who should be informed of activity related to this release. Separate multiple email addresses with a semicolon or comma</value>
        [DataMember(Name="emailList", EmitDefaultValue=false)]
        public string EmailList { get; set; }

        /// <summary>
        /// Application attributes. This is an array of key/value objects. Example, [{\&quot;Attribute 1\&quot;: \&quot;value 1\&quot;}, {\&quot;Attribute 2\&quot;: \&quot;value 2\&quot;}, {\&quot;Attribute 3\&quot;: \&quot;value 3\&quot;} ]
        /// </summary>
        /// <value>Application attributes. This is an array of key/value objects. Example, [{\&quot;Attribute 1\&quot;: \&quot;value 1\&quot;}, {\&quot;Attribute 2\&quot;: \&quot;value 2\&quot;}, {\&quot;Attribute 3\&quot;: \&quot;value 3\&quot;} ]</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<ApplicationAttribute> Attributes { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PutApplicationRequest {\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  ApplicationDescription: ").Append(ApplicationDescription).Append("\n");
            sb.Append("  EmailList: ").Append(EmailList).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  BusinessCriticalityType: ").Append(BusinessCriticalityType).Append("\n");
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
            return this.Equals(input as PutApplicationRequest);
        }

        /// <summary>
        /// Returns true if PutApplicationRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PutApplicationRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PutApplicationRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationName == input.ApplicationName ||
                    (this.ApplicationName != null &&
                    this.ApplicationName.Equals(input.ApplicationName))
                ) && 
                (
                    this.ApplicationDescription == input.ApplicationDescription ||
                    (this.ApplicationDescription != null &&
                    this.ApplicationDescription.Equals(input.ApplicationDescription))
                ) && 
                (
                    this.EmailList == input.EmailList ||
                    (this.EmailList != null &&
                    this.EmailList.Equals(input.EmailList))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
                ) && 
                (
                    this.BusinessCriticalityType == input.BusinessCriticalityType ||
                    (this.BusinessCriticalityType != null &&
                    this.BusinessCriticalityType.Equals(input.BusinessCriticalityType))
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
                if (this.ApplicationName != null)
                    hashCode = hashCode * 59 + this.ApplicationName.GetHashCode();
                if (this.ApplicationDescription != null)
                    hashCode = hashCode * 59 + this.ApplicationDescription.GetHashCode();
                if (this.EmailList != null)
                    hashCode = hashCode * 59 + this.EmailList.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.BusinessCriticalityType != null)
                    hashCode = hashCode * 59 + this.BusinessCriticalityType.GetHashCode();
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