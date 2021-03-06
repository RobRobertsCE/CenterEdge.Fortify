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
    /// Post Auto Report Request
    /// </summary>
    [DataContract]
    public partial class PostAutoReportRequest :  IEquatable<PostAutoReportRequest>, IValidatableObject
    {
        /// <summary>
        /// The report format
        /// </summary>
        /// <value>The report format</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReportFormatEnum
        {
            
            /// <summary>
            /// Enum Pdf for value: Pdf
            /// </summary>
            [EnumMember(Value = "Pdf")]
            Pdf = 1,
            
            /// <summary>
            /// Enum Html for value: Html
            /// </summary>
            [EnumMember(Value = "Html")]
            Html = 2
        }

        /// <summary>
        /// The report format
        /// </summary>
        /// <value>The report format</value>
        [DataMember(Name="reportFormat", EmitDefaultValue=false)]
        public ReportFormatEnum ReportFormat { get; set; }
        /// <summary>
        /// Defines ProjectSDLCStatusTypes
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ProjectSDLCStatusTypesEnum
        {
            
            /// <summary>
            /// Enum Production for value: Production
            /// </summary>
            [EnumMember(Value = "Production")]
            Production = 1,
            
            /// <summary>
            /// Enum QA for value: QA
            /// </summary>
            [EnumMember(Value = "QA")]
            QA = 2,
            
            /// <summary>
            /// Enum Development for value: Development
            /// </summary>
            [EnumMember(Value = "Development")]
            Development = 3,
            
            /// <summary>
            /// Enum Retired for value: Retired
            /// </summary>
            [EnumMember(Value = "Retired")]
            Retired = 4
        }


        /// <summary>
        /// SDLC Status IDs
        /// </summary>
        /// <value>SDLC Status IDs</value>
        [DataMember(Name="projectSDLCStatusTypes", EmitDefaultValue=false)]
        public List<ProjectSDLCStatusTypesEnum> ProjectSDLCStatusTypes { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostAutoReportRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostAutoReportRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostAutoReportRequest" /> class.
        /// </summary>
        /// <param name="StaticScanReportId">The report id used for Static Scans.</param>
        /// <param name="DynamicScanReportId">The report id used for Dynamic Scans.</param>
        /// <param name="EmailReport">Enable/Disable email reporting (required).</param>
        /// <param name="ReportFormat">The report format (required).</param>
        /// <param name="EmailNotificationList">List of emails separated by semicolon.</param>
        /// <param name="ProjectSDLCStatusTypes">SDLC Status IDs.</param>
        public PostAutoReportRequest(int? StaticScanReportId = default(int?), int? DynamicScanReportId = default(int?), bool? EmailReport = default(bool?), ReportFormatEnum ReportFormat = default(ReportFormatEnum), string EmailNotificationList = default(string), List<ProjectSDLCStatusTypesEnum> ProjectSDLCStatusTypes = default(List<ProjectSDLCStatusTypesEnum>))
        {
            // to ensure "EmailReport" is required (not null)
            if (EmailReport == null)
            {
                throw new InvalidDataException("EmailReport is a required property for PostAutoReportRequest and cannot be null");
            }
            else
            {
                this.EmailReport = EmailReport;
            }
            // to ensure "ReportFormat" is required (not null)
            if (ReportFormat == null)
            {
                throw new InvalidDataException("ReportFormat is a required property for PostAutoReportRequest and cannot be null");
            }
            else
            {
                this.ReportFormat = ReportFormat;
            }
            this.StaticScanReportId = StaticScanReportId;
            this.DynamicScanReportId = DynamicScanReportId;
            this.EmailNotificationList = EmailNotificationList;
            this.ProjectSDLCStatusTypes = ProjectSDLCStatusTypes;
        }
        
        /// <summary>
        /// The report id used for Static Scans
        /// </summary>
        /// <value>The report id used for Static Scans</value>
        [DataMember(Name="staticScanReportId", EmitDefaultValue=false)]
        public int? StaticScanReportId { get; set; }

        /// <summary>
        /// The report id used for Dynamic Scans
        /// </summary>
        /// <value>The report id used for Dynamic Scans</value>
        [DataMember(Name="dynamicScanReportId", EmitDefaultValue=false)]
        public int? DynamicScanReportId { get; set; }

        /// <summary>
        /// Enable/Disable email reporting
        /// </summary>
        /// <value>Enable/Disable email reporting</value>
        [DataMember(Name="emailReport", EmitDefaultValue=false)]
        public bool? EmailReport { get; set; }


        /// <summary>
        /// List of emails separated by semicolon
        /// </summary>
        /// <value>List of emails separated by semicolon</value>
        [DataMember(Name="emailNotificationList", EmitDefaultValue=false)]
        public string EmailNotificationList { get; set; }


        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostAutoReportRequest {\n");
            sb.Append("  StaticScanReportId: ").Append(StaticScanReportId).Append("\n");
            sb.Append("  DynamicScanReportId: ").Append(DynamicScanReportId).Append("\n");
            sb.Append("  EmailReport: ").Append(EmailReport).Append("\n");
            sb.Append("  ReportFormat: ").Append(ReportFormat).Append("\n");
            sb.Append("  EmailNotificationList: ").Append(EmailNotificationList).Append("\n");
            sb.Append("  ProjectSDLCStatusTypes: ").Append(ProjectSDLCStatusTypes).Append("\n");
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
            return this.Equals(input as PostAutoReportRequest);
        }

        /// <summary>
        /// Returns true if PostAutoReportRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostAutoReportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostAutoReportRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.StaticScanReportId == input.StaticScanReportId ||
                    (this.StaticScanReportId != null &&
                    this.StaticScanReportId.Equals(input.StaticScanReportId))
                ) && 
                (
                    this.DynamicScanReportId == input.DynamicScanReportId ||
                    (this.DynamicScanReportId != null &&
                    this.DynamicScanReportId.Equals(input.DynamicScanReportId))
                ) && 
                (
                    this.EmailReport == input.EmailReport ||
                    (this.EmailReport != null &&
                    this.EmailReport.Equals(input.EmailReport))
                ) && 
                (
                    this.ReportFormat == input.ReportFormat ||
                    (this.ReportFormat != null &&
                    this.ReportFormat.Equals(input.ReportFormat))
                ) && 
                (
                    this.EmailNotificationList == input.EmailNotificationList ||
                    (this.EmailNotificationList != null &&
                    this.EmailNotificationList.Equals(input.EmailNotificationList))
                ) && 
                (
                    this.ProjectSDLCStatusTypes == input.ProjectSDLCStatusTypes ||
                    this.ProjectSDLCStatusTypes != null &&
                    this.ProjectSDLCStatusTypes.SequenceEqual(input.ProjectSDLCStatusTypes)
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
                if (this.StaticScanReportId != null)
                    hashCode = hashCode * 59 + this.StaticScanReportId.GetHashCode();
                if (this.DynamicScanReportId != null)
                    hashCode = hashCode * 59 + this.DynamicScanReportId.GetHashCode();
                if (this.EmailReport != null)
                    hashCode = hashCode * 59 + this.EmailReport.GetHashCode();
                if (this.ReportFormat != null)
                    hashCode = hashCode * 59 + this.ReportFormat.GetHashCode();
                if (this.EmailNotificationList != null)
                    hashCode = hashCode * 59 + this.EmailNotificationList.GetHashCode();
                if (this.ProjectSDLCStatusTypes != null)
                    hashCode = hashCode * 59 + this.ProjectSDLCStatusTypes.GetHashCode();
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
