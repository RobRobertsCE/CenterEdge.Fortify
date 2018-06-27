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
    /// Options for starting the scan
    /// </summary>
    [DataContract]
    public partial class StartDynamicScanRequest :  IEquatable<StartDynamicScanRequest>, IValidatableObject
    {
        /// <summary>
        /// The entitlement frequency type to use for the scan
        /// </summary>
        /// <value>The entitlement frequency type to use for the scan</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EntitlementFrequencyTypeEnum
        {
            
            /// <summary>
            /// Enum SingleScan for value: SingleScan
            /// </summary>
            [EnumMember(Value = "SingleScan")]
            SingleScan = 1,
            
            /// <summary>
            /// Enum Subscription for value: Subscription
            /// </summary>
            [EnumMember(Value = "Subscription")]
            Subscription = 2
        }

        /// <summary>
        /// The entitlement frequency type to use for the scan
        /// </summary>
        /// <value>The entitlement frequency type to use for the scan</value>
        [DataMember(Name="entitlementFrequencyType", EmitDefaultValue=false)]
        public EntitlementFrequencyTypeEnum EntitlementFrequencyType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="StartDynamicScanRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected StartDynamicScanRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="StartDynamicScanRequest" /> class.
        /// </summary>
        /// <param name="StartDate">Date when the scan should start, in MM/dd/yyyy HH:mm format (required).</param>
        /// <param name="AssessmentTypeId">The assessment type id to use for the scan (required).</param>
        /// <param name="EntitlementId">The entitlement id to consume for the scan (required).</param>
        /// <param name="EntitlementFrequencyType">The entitlement frequency type to use for the scan (required).</param>
        /// <param name="IsRemediationScan">Indicates if the scan is a remediation scan. If not supplied the default value is false (required).</param>
        /// <param name="IsBundledAssessment">Indicates if the assessment is a bundled assessment. If not supplied legacy behavior will apply.</param>
        /// <param name="ParentAssessmentTypeId">The parent assessment type id for the bundled assessment. If not supplied legacy behavior will apply.</param>
        public StartDynamicScanRequest(DateTime? StartDate = default(DateTime?), int? AssessmentTypeId = default(int?), int? EntitlementId = default(int?), EntitlementFrequencyTypeEnum EntitlementFrequencyType = default(EntitlementFrequencyTypeEnum), bool? IsRemediationScan = default(bool?), bool? IsBundledAssessment = default(bool?), int? ParentAssessmentTypeId = default(int?))
        {
            // to ensure "StartDate" is required (not null)
            if (StartDate == null)
            {
                throw new InvalidDataException("StartDate is a required property for StartDynamicScanRequest and cannot be null");
            }
            else
            {
                this.StartDate = StartDate;
            }
            // to ensure "AssessmentTypeId" is required (not null)
            if (AssessmentTypeId == null)
            {
                throw new InvalidDataException("AssessmentTypeId is a required property for StartDynamicScanRequest and cannot be null");
            }
            else
            {
                this.AssessmentTypeId = AssessmentTypeId;
            }
            // to ensure "EntitlementId" is required (not null)
            if (EntitlementId == null)
            {
                throw new InvalidDataException("EntitlementId is a required property for StartDynamicScanRequest and cannot be null");
            }
            else
            {
                this.EntitlementId = EntitlementId;
            }
            // to ensure "EntitlementFrequencyType" is required (not null)
            if (EntitlementFrequencyType == null)
            {
                throw new InvalidDataException("EntitlementFrequencyType is a required property for StartDynamicScanRequest and cannot be null");
            }
            else
            {
                this.EntitlementFrequencyType = EntitlementFrequencyType;
            }
            // to ensure "IsRemediationScan" is required (not null)
            if (IsRemediationScan == null)
            {
                throw new InvalidDataException("IsRemediationScan is a required property for StartDynamicScanRequest and cannot be null");
            }
            else
            {
                this.IsRemediationScan = IsRemediationScan;
            }
            this.IsBundledAssessment = IsBundledAssessment;
            this.ParentAssessmentTypeId = ParentAssessmentTypeId;
        }
        
        /// <summary>
        /// Date when the scan should start, in MM/dd/yyyy HH:mm format
        /// </summary>
        /// <value>Date when the scan should start, in MM/dd/yyyy HH:mm format</value>
        [DataMember(Name="startDate", EmitDefaultValue=false)]
        public DateTime? StartDate { get; set; }

        /// <summary>
        /// The assessment type id to use for the scan
        /// </summary>
        /// <value>The assessment type id to use for the scan</value>
        [DataMember(Name="assessmentTypeId", EmitDefaultValue=false)]
        public int? AssessmentTypeId { get; set; }

        /// <summary>
        /// The entitlement id to consume for the scan
        /// </summary>
        /// <value>The entitlement id to consume for the scan</value>
        [DataMember(Name="entitlementId", EmitDefaultValue=false)]
        public int? EntitlementId { get; set; }


        /// <summary>
        /// Indicates if the scan is a remediation scan. If not supplied the default value is false
        /// </summary>
        /// <value>Indicates if the scan is a remediation scan. If not supplied the default value is false</value>
        [DataMember(Name="isRemediationScan", EmitDefaultValue=false)]
        public bool? IsRemediationScan { get; set; }

        /// <summary>
        /// Indicates if the assessment is a bundled assessment. If not supplied legacy behavior will apply
        /// </summary>
        /// <value>Indicates if the assessment is a bundled assessment. If not supplied legacy behavior will apply</value>
        [DataMember(Name="isBundledAssessment", EmitDefaultValue=false)]
        public bool? IsBundledAssessment { get; set; }

        /// <summary>
        /// The parent assessment type id for the bundled assessment. If not supplied legacy behavior will apply
        /// </summary>
        /// <value>The parent assessment type id for the bundled assessment. If not supplied legacy behavior will apply</value>
        [DataMember(Name="parentAssessmentTypeId", EmitDefaultValue=false)]
        public int? ParentAssessmentTypeId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class StartDynamicScanRequest {\n");
            sb.Append("  StartDate: ").Append(StartDate).Append("\n");
            sb.Append("  AssessmentTypeId: ").Append(AssessmentTypeId).Append("\n");
            sb.Append("  EntitlementId: ").Append(EntitlementId).Append("\n");
            sb.Append("  EntitlementFrequencyType: ").Append(EntitlementFrequencyType).Append("\n");
            sb.Append("  IsRemediationScan: ").Append(IsRemediationScan).Append("\n");
            sb.Append("  IsBundledAssessment: ").Append(IsBundledAssessment).Append("\n");
            sb.Append("  ParentAssessmentTypeId: ").Append(ParentAssessmentTypeId).Append("\n");
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
            return this.Equals(input as StartDynamicScanRequest);
        }

        /// <summary>
        /// Returns true if StartDynamicScanRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of StartDynamicScanRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(StartDynamicScanRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StartDate == input.StartDate ||
                    (this.StartDate != null &&
                    this.StartDate.Equals(input.StartDate))
                ) && 
                (
                    this.AssessmentTypeId == input.AssessmentTypeId ||
                    (this.AssessmentTypeId != null &&
                    this.AssessmentTypeId.Equals(input.AssessmentTypeId))
                ) && 
                (
                    this.EntitlementId == input.EntitlementId ||
                    (this.EntitlementId != null &&
                    this.EntitlementId.Equals(input.EntitlementId))
                ) && 
                (
                    this.EntitlementFrequencyType == input.EntitlementFrequencyType ||
                    (this.EntitlementFrequencyType != null &&
                    this.EntitlementFrequencyType.Equals(input.EntitlementFrequencyType))
                ) && 
                (
                    this.IsRemediationScan == input.IsRemediationScan ||
                    (this.IsRemediationScan != null &&
                    this.IsRemediationScan.Equals(input.IsRemediationScan))
                ) && 
                (
                    this.IsBundledAssessment == input.IsBundledAssessment ||
                    (this.IsBundledAssessment != null &&
                    this.IsBundledAssessment.Equals(input.IsBundledAssessment))
                ) && 
                (
                    this.ParentAssessmentTypeId == input.ParentAssessmentTypeId ||
                    (this.ParentAssessmentTypeId != null &&
                    this.ParentAssessmentTypeId.Equals(input.ParentAssessmentTypeId))
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
                if (this.StartDate != null)
                    hashCode = hashCode * 59 + this.StartDate.GetHashCode();
                if (this.AssessmentTypeId != null)
                    hashCode = hashCode * 59 + this.AssessmentTypeId.GetHashCode();
                if (this.EntitlementId != null)
                    hashCode = hashCode * 59 + this.EntitlementId.GetHashCode();
                if (this.EntitlementFrequencyType != null)
                    hashCode = hashCode * 59 + this.EntitlementFrequencyType.GetHashCode();
                if (this.IsRemediationScan != null)
                    hashCode = hashCode * 59 + this.IsRemediationScan.GetHashCode();
                if (this.IsBundledAssessment != null)
                    hashCode = hashCode * 59 + this.IsBundledAssessment.GetHashCode();
                if (this.ParentAssessmentTypeId != null)
                    hashCode = hashCode * 59 + this.ParentAssessmentTypeId.GetHashCode();
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
