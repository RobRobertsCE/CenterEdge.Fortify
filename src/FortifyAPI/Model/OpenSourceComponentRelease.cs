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
    /// OpenSourceComponentRelease
    /// </summary>
    [DataContract]
    public partial class OpenSourceComponentRelease :  IEquatable<OpenSourceComponentRelease>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="OpenSourceComponentRelease" /> class.
        /// </summary>
        /// <param name="ApplicationId">ApplicationId.</param>
        /// <param name="ApplicationName">ApplicationName.</param>
        /// <param name="ReleaseId">ReleaseId.</param>
        /// <param name="ReleaseName">ReleaseName.</param>
        public OpenSourceComponentRelease(int? ApplicationId = default(int?), string ApplicationName = default(string), int? ReleaseId = default(int?), string ReleaseName = default(string))
        {
            this.ApplicationId = ApplicationId;
            this.ApplicationName = ApplicationName;
            this.ReleaseId = ReleaseId;
            this.ReleaseName = ReleaseName;
        }
        
        /// <summary>
        /// Gets or Sets ApplicationId
        /// </summary>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public int? ApplicationId { get; set; }

        /// <summary>
        /// Gets or Sets ApplicationName
        /// </summary>
        [DataMember(Name="applicationName", EmitDefaultValue=false)]
        public string ApplicationName { get; set; }

        /// <summary>
        /// Gets or Sets ReleaseId
        /// </summary>
        [DataMember(Name="releaseId", EmitDefaultValue=false)]
        public int? ReleaseId { get; set; }

        /// <summary>
        /// Gets or Sets ReleaseName
        /// </summary>
        [DataMember(Name="releaseName", EmitDefaultValue=false)]
        public string ReleaseName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class OpenSourceComponentRelease {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ApplicationName: ").Append(ApplicationName).Append("\n");
            sb.Append("  ReleaseId: ").Append(ReleaseId).Append("\n");
            sb.Append("  ReleaseName: ").Append(ReleaseName).Append("\n");
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
            return this.Equals(input as OpenSourceComponentRelease);
        }

        /// <summary>
        /// Returns true if OpenSourceComponentRelease instances are equal
        /// </summary>
        /// <param name="input">Instance of OpenSourceComponentRelease to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OpenSourceComponentRelease input)
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
                    this.ReleaseId == input.ReleaseId ||
                    (this.ReleaseId != null &&
                    this.ReleaseId.Equals(input.ReleaseId))
                ) && 
                (
                    this.ReleaseName == input.ReleaseName ||
                    (this.ReleaseName != null &&
                    this.ReleaseName.Equals(input.ReleaseName))
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
                if (this.ReleaseId != null)
                    hashCode = hashCode * 59 + this.ReleaseId.GetHashCode();
                if (this.ReleaseName != null)
                    hashCode = hashCode * 59 + this.ReleaseName.GetHashCode();
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
