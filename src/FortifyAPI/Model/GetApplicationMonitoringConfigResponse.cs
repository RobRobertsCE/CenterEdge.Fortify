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
    /// Get Application Monitoring Config Response
    /// </summary>
    [DataContract]
    public partial class GetApplicationMonitoringConfigResponse :  IEquatable<GetApplicationMonitoringConfigResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetApplicationMonitoringConfigResponse" /> class.
        /// </summary>
        /// <param name="Enabled">Indicates whether Application Monitoring is enabled for the application.</param>
        /// <param name="ScanUrl">The Scan Url to monitor.</param>
        /// <param name="LastCompletedDate">Last application monitoring scan completed date.</param>
        public GetApplicationMonitoringConfigResponse(bool? Enabled = default(bool?), string ScanUrl = default(string), DateTime? LastCompletedDate = default(DateTime?))
        {
            this.Enabled = Enabled;
            this.ScanUrl = ScanUrl;
            this.LastCompletedDate = LastCompletedDate;
        }
        
        /// <summary>
        /// Indicates whether Application Monitoring is enabled for the application
        /// </summary>
        /// <value>Indicates whether Application Monitoring is enabled for the application</value>
        [DataMember(Name="enabled", EmitDefaultValue=false)]
        public bool? Enabled { get; set; }

        /// <summary>
        /// The Scan Url to monitor
        /// </summary>
        /// <value>The Scan Url to monitor</value>
        [DataMember(Name="scanUrl", EmitDefaultValue=false)]
        public string ScanUrl { get; set; }

        /// <summary>
        /// Last application monitoring scan completed date
        /// </summary>
        /// <value>Last application monitoring scan completed date</value>
        [DataMember(Name="lastCompletedDate", EmitDefaultValue=false)]
        public DateTime? LastCompletedDate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class GetApplicationMonitoringConfigResponse {\n");
            sb.Append("  Enabled: ").Append(Enabled).Append("\n");
            sb.Append("  ScanUrl: ").Append(ScanUrl).Append("\n");
            sb.Append("  LastCompletedDate: ").Append(LastCompletedDate).Append("\n");
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
            return this.Equals(input as GetApplicationMonitoringConfigResponse);
        }

        /// <summary>
        /// Returns true if GetApplicationMonitoringConfigResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of GetApplicationMonitoringConfigResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GetApplicationMonitoringConfigResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Enabled == input.Enabled ||
                    (this.Enabled != null &&
                    this.Enabled.Equals(input.Enabled))
                ) && 
                (
                    this.ScanUrl == input.ScanUrl ||
                    (this.ScanUrl != null &&
                    this.ScanUrl.Equals(input.ScanUrl))
                ) && 
                (
                    this.LastCompletedDate == input.LastCompletedDate ||
                    (this.LastCompletedDate != null &&
                    this.LastCompletedDate.Equals(input.LastCompletedDate))
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
                if (this.Enabled != null)
                    hashCode = hashCode * 59 + this.Enabled.GetHashCode();
                if (this.ScanUrl != null)
                    hashCode = hashCode * 59 + this.ScanUrl.GetHashCode();
                if (this.LastCompletedDate != null)
                    hashCode = hashCode * 59 + this.LastCompletedDate.GetHashCode();
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