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
    /// Application
    /// </summary>
    [DataContract]
    public partial class Application :  IEquatable<Application>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Application" /> class.
        /// </summary>
        /// <param name="ApplicationId">The application id.</param>
        /// <param name="ApplicationName">The name of the application.</param>
        /// <param name="ApplicationDescription">Description of the application that will help you manage multiple applications.</param>
        /// <param name="ApplicationCreatedDate">The date the application was created.</param>
        /// <param name="BusinessCriticalityTypeId">The business criticality type id.</param>
        /// <param name="BusinessCriticalityType">The business criticality type name.</param>
        /// <param name="EmailList">List the email addresses of additional people who should be informed of activity related to this release.</param>
        /// <param name="ApplicationTypeId">The application type id.</param>
        /// <param name="ApplicationType">The application type name.</param>
        /// <param name="Attributes">Application attributes.</param>
        public Application(int? ApplicationId = default(int?), string ApplicationName = default(string), string ApplicationDescription = default(string), DateTime? ApplicationCreatedDate = default(DateTime?), int? BusinessCriticalityTypeId = default(int?), string BusinessCriticalityType = default(string), string EmailList = default(string), int? ApplicationTypeId = default(int?), string ApplicationType = default(string), List<ApplicationAttributeExtended> Attributes = default(List<ApplicationAttributeExtended>))
        {
            this.ApplicationId = ApplicationId;
            this.ApplicationName = ApplicationName;
            this.ApplicationDescription = ApplicationDescription;
            this.ApplicationCreatedDate = ApplicationCreatedDate;
            this.BusinessCriticalityTypeId = BusinessCriticalityTypeId;
            this.BusinessCriticalityType = BusinessCriticalityType;
            this.EmailList = EmailList;
            this.ApplicationTypeId = ApplicationTypeId;
            this.ApplicationType = ApplicationType;
            this.Attributes = Attributes;
        }
        
        /// <summary>
        /// The application id
        /// </summary>
        /// <value>The application id</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public int? ApplicationId { get; set; }

        /// <summary>
        /// The name of the application
        /// </summary>
        /// <value>The name of the application</value>
        [DataMember(Name="applicationName", EmitDefaultValue=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Description of the application that will help you manage multiple applications
        /// </summary>
        /// <value>Description of the application that will help you manage multiple applications</value>
        [DataMember(Name="applicationDescription", EmitDefaultValue=false)]
        public string ApplicationDescription { get; set; }

        /// <summary>
        /// The date the application was created
        /// </summary>
        /// <value>The date the application was created</value>
        [DataMember(Name="applicationCreatedDate", EmitDefaultValue=false)]
        public DateTime? ApplicationCreatedDate { get; set; }

        /// <summary>
        /// The business criticality type id
        /// </summary>
        /// <value>The business criticality type id</value>
        [DataMember(Name="businessCriticalityTypeId", EmitDefaultValue=false)]
        public int? BusinessCriticalityTypeId { get; set; }

        /// <summary>
        /// The business criticality type name
        /// </summary>
        /// <value>The business criticality type name</value>
        [DataMember(Name="businessCriticalityType", EmitDefaultValue=false)]
        public string BusinessCriticalityType { get; set; }

        /// <summary>
        /// List the email addresses of additional people who should be informed of activity related to this release
        /// </summary>
        /// <value>List the email addresses of additional people who should be informed of activity related to this release</value>
        [DataMember(Name="emailList", EmitDefaultValue=false)]
        public string EmailList { get; set; }

        /// <summary>
        /// The application type id
        /// </summary>
        /// <value>The application type id</value>
        [DataMember(Name="applicationTypeId", EmitDefaultValue=false)]
        public int? ApplicationTypeId { get; set; }

        /// <summary>
        /// The application type name
        /// </summary>
        /// <value>The application type name</value>
        [DataMember(Name="applicationType", EmitDefaultValue=false)]
        public string ApplicationType { get; set; }

        /// <summary>
        /// Application attributes
        /// </summary>
        /// <value>Application attributes</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public List<ApplicationAttributeExtended> Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Application {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  ApplicationDescription: ").Append(ApplicationDescription).Append("\n");
            sb.Append("  ApplicationCreatedDate: ").Append(ApplicationCreatedDate).Append("\n");
            sb.Append("  BusinessCriticalityTypeId: ").Append(BusinessCriticalityTypeId).Append("\n");
            sb.Append("  BusinessCriticalityType: ").Append(BusinessCriticalityType).Append("\n");
            sb.Append("  EmailList: ").Append(EmailList).Append("\n");
            sb.Append("  ApplicationTypeId: ").Append(ApplicationTypeId).Append("\n");
            sb.Append("  ApplicationType: ").Append(ApplicationType).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(input as Application);
        }

        /// <summary>
        /// Returns true if Application instances are equal
        /// </summary>
        /// <param name="input">Instance of Application to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Application input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationId == input.ApplicationId ||
                    (this.ApplicationId != null &&
                    this.ApplicationId.Equals(input.ApplicationId))
                ) && 
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
                    this.ApplicationCreatedDate == input.ApplicationCreatedDate ||
                    (this.ApplicationCreatedDate != null &&
                    this.ApplicationCreatedDate.Equals(input.ApplicationCreatedDate))
                ) && 
                (
                    this.BusinessCriticalityTypeId == input.BusinessCriticalityTypeId ||
                    (this.BusinessCriticalityTypeId != null &&
                    this.BusinessCriticalityTypeId.Equals(input.BusinessCriticalityTypeId))
                ) && 
                (
                    this.BusinessCriticalityType == input.BusinessCriticalityType ||
                    (this.BusinessCriticalityType != null &&
                    this.BusinessCriticalityType.Equals(input.BusinessCriticalityType))
                ) && 
                (
                    this.EmailList == input.EmailList ||
                    (this.EmailList != null &&
                    this.EmailList.Equals(input.EmailList))
                ) && 
                (
                    this.ApplicationTypeId == input.ApplicationTypeId ||
                    (this.ApplicationTypeId != null &&
                    this.ApplicationTypeId.Equals(input.ApplicationTypeId))
                ) && 
                (
                    this.ApplicationType == input.ApplicationType ||
                    (this.ApplicationType != null &&
                    this.ApplicationType.Equals(input.ApplicationType))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    this.Attributes != null &&
                    this.Attributes.SequenceEqual(input.Attributes)
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
                if (this.ApplicationId != null)
                    hashCode = hashCode * 59 + this.ApplicationId.GetHashCode();
                if (this.ApplicationName != null)
                    hashCode = hashCode * 59 + this.ApplicationName.GetHashCode();
                if (this.ApplicationDescription != null)
                    hashCode = hashCode * 59 + this.ApplicationDescription.GetHashCode();
                if (this.ApplicationCreatedDate != null)
                    hashCode = hashCode * 59 + this.ApplicationCreatedDate.GetHashCode();
                if (this.BusinessCriticalityTypeId != null)
                    hashCode = hashCode * 59 + this.BusinessCriticalityTypeId.GetHashCode();
                if (this.BusinessCriticalityType != null)
                    hashCode = hashCode * 59 + this.BusinessCriticalityType.GetHashCode();
                if (this.EmailList != null)
                    hashCode = hashCode * 59 + this.EmailList.GetHashCode();
                if (this.ApplicationTypeId != null)
                    hashCode = hashCode * 59 + this.ApplicationTypeId.GetHashCode();
                if (this.ApplicationType != null)
                    hashCode = hashCode * 59 + this.ApplicationType.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
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
