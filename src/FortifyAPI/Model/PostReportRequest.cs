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
    /// Post Report Request
    /// </summary>
    [DataContract]
    public partial class PostReportRequest :  IEquatable<PostReportRequest>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="PostReportRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostReportRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostReportRequest" /> class.
        /// </summary>
        /// <param name="ApplicationId">The application id (required).</param>
        /// <param name="ReleaseId">The release id (required).</param>
        /// <param name="ReportTemplateTypeId">The report template type id (required).</param>
        /// <param name="ReportName">The report name.</param>
        /// <param name="ReportFormat">The report format (required).</param>
        /// <param name="Notes">The report notes.</param>
        public PostReportRequest(int? ApplicationId = default(int?), int? ReleaseId = default(int?), int? ReportTemplateTypeId = default(int?), string ReportName = default(string), ReportFormatEnum ReportFormat = default(ReportFormatEnum), string Notes = default(string))
        {
            // to ensure "ApplicationId" is required (not null)
            if (ApplicationId == null)
            {
                throw new InvalidDataException("ApplicationId is a required property for PostReportRequest and cannot be null");
            }
            else
            {
                this.ApplicationId = ApplicationId;
            }
            // to ensure "ReleaseId" is required (not null)
            if (ReleaseId == null)
            {
                throw new InvalidDataException("ReleaseId is a required property for PostReportRequest and cannot be null");
            }
            else
            {
                this.ReleaseId = ReleaseId;
            }
            // to ensure "ReportTemplateTypeId" is required (not null)
            if (ReportTemplateTypeId == null)
            {
                throw new InvalidDataException("ReportTemplateTypeId is a required property for PostReportRequest and cannot be null");
            }
            else
            {
                this.ReportTemplateTypeId = ReportTemplateTypeId;
            }
            // to ensure "ReportFormat" is required (not null)
            if (ReportFormat == null)
            {
                throw new InvalidDataException("ReportFormat is a required property for PostReportRequest and cannot be null");
            }
            else
            {
                this.ReportFormat = ReportFormat;
            }
            this.ReportName = ReportName;
            this.Notes = Notes;
        }
        
        /// <summary>
        /// The application id
        /// </summary>
        /// <value>The application id</value>
        [DataMember(Name="applicationId", EmitDefaultValue=false)]
        public int? ApplicationId { get; set; }

        /// <summary>
        /// The release id
        /// </summary>
        /// <value>The release id</value>
        [DataMember(Name="releaseId", EmitDefaultValue=false)]
        public int? ReleaseId { get; set; }

        /// <summary>
        /// The report template type id
        /// </summary>
        /// <value>The report template type id</value>
        [DataMember(Name="reportTemplateTypeId", EmitDefaultValue=false)]
        public int? ReportTemplateTypeId { get; set; }

        /// <summary>
        /// The report name
        /// </summary>
        /// <value>The report name</value>
        [DataMember(Name="reportName", EmitDefaultValue=false)]
        public string ReportName { get; set; }


        /// <summary>
        /// The report notes
        /// </summary>
        /// <value>The report notes</value>
        [DataMember(Name="notes", EmitDefaultValue=false)]
        public string Notes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostReportRequest {\n");
            sb.Append("  ApplicationId: ").Append(ApplicationId).Append("\n");
            sb.Append("  ReleaseId: ").Append(ReleaseId).Append("\n");
            sb.Append("  ReportTemplateTypeId: ").Append(ReportTemplateTypeId).Append("\n");
            sb.Append("  ReportName: ").Append(ReportName).Append("\n");
            sb.Append("  ReportFormat: ").Append(ReportFormat).Append("\n");
            sb.Append("  Notes: ").Append(Notes).Append("\n");
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
            return this.Equals(input as PostReportRequest);
        }

        /// <summary>
        /// Returns true if PostReportRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostReportRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostReportRequest input)
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
                    this.ReleaseId == input.ReleaseId ||
                    (this.ReleaseId != null &&
                    this.ReleaseId.Equals(input.ReleaseId))
                ) && 
                (
                    this.ReportTemplateTypeId == input.ReportTemplateTypeId ||
                    (this.ReportTemplateTypeId != null &&
                    this.ReportTemplateTypeId.Equals(input.ReportTemplateTypeId))
                ) && 
                (
                    this.ReportName == input.ReportName ||
                    (this.ReportName != null &&
                    this.ReportName.Equals(input.ReportName))
                ) && 
                (
                    this.ReportFormat == input.ReportFormat ||
                    (this.ReportFormat != null &&
                    this.ReportFormat.Equals(input.ReportFormat))
                ) && 
                (
                    this.Notes == input.Notes ||
                    (this.Notes != null &&
                    this.Notes.Equals(input.Notes))
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
                if (this.ReleaseId != null)
                    hashCode = hashCode * 59 + this.ReleaseId.GetHashCode();
                if (this.ReportTemplateTypeId != null)
                    hashCode = hashCode * 59 + this.ReportTemplateTypeId.GetHashCode();
                if (this.ReportName != null)
                    hashCode = hashCode * 59 + this.ReportName.GetHashCode();
                if (this.ReportFormat != null)
                    hashCode = hashCode * 59 + this.ReportFormat.GetHashCode();
                if (this.Notes != null)
                    hashCode = hashCode * 59 + this.Notes.GetHashCode();
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
