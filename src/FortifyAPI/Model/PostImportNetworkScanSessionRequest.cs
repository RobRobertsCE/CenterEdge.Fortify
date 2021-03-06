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
    /// Post Import Network Scan Session Request
    /// </summary>
    [DataContract]
    public partial class PostImportNetworkScanSessionRequest :  IEquatable<PostImportNetworkScanSessionRequest>, IValidatableObject
    {
        /// <summary>
        /// NetworkScanType
        /// </summary>
        /// <value>NetworkScanType</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum NetworkScanTypeEnum
        {
            
            /// <summary>
            /// Enum Nessus for value: Nessus
            /// </summary>
            [EnumMember(Value = "Nessus")]
            Nessus = 1,
            
            /// <summary>
            /// Enum Nexpose for value: Nexpose
            /// </summary>
            [EnumMember(Value = "Nexpose")]
            Nexpose = 2,
            
            /// <summary>
            /// Enum Qualys for value: Qualys
            /// </summary>
            [EnumMember(Value = "Qualys")]
            Qualys = 3,
            
            /// <summary>
            /// Enum Tripwire for value: Tripwire
            /// </summary>
            [EnumMember(Value = "Tripwire")]
            Tripwire = 4
        }

        /// <summary>
        /// NetworkScanType
        /// </summary>
        /// <value>NetworkScanType</value>
        [DataMember(Name="networkScanType", EmitDefaultValue=false)]
        public NetworkScanTypeEnum NetworkScanType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostImportNetworkScanSessionRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostImportNetworkScanSessionRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostImportNetworkScanSessionRequest" /> class.
        /// </summary>
        /// <param name="FileLength">FileLength (required).</param>
        /// <param name="NetworkScanType">NetworkScanType (required).</param>
        /// <param name="CommonPortsOnly">CommonPortsOnly (required).</param>
        /// <param name="Hosts">Hosts.</param>
        public PostImportNetworkScanSessionRequest(long? FileLength = default(long?), NetworkScanTypeEnum NetworkScanType = default(NetworkScanTypeEnum), bool? CommonPortsOnly = default(bool?), List<string> Hosts = default(List<string>))
        {
            // to ensure "FileLength" is required (not null)
            if (FileLength == null)
            {
                throw new InvalidDataException("FileLength is a required property for PostImportNetworkScanSessionRequest and cannot be null");
            }
            else
            {
                this.FileLength = FileLength;
            }
            // to ensure "NetworkScanType" is required (not null)
            if (NetworkScanType == null)
            {
                throw new InvalidDataException("NetworkScanType is a required property for PostImportNetworkScanSessionRequest and cannot be null");
            }
            else
            {
                this.NetworkScanType = NetworkScanType;
            }
            // to ensure "CommonPortsOnly" is required (not null)
            if (CommonPortsOnly == null)
            {
                throw new InvalidDataException("CommonPortsOnly is a required property for PostImportNetworkScanSessionRequest and cannot be null");
            }
            else
            {
                this.CommonPortsOnly = CommonPortsOnly;
            }
            this.Hosts = Hosts;
        }
        
        /// <summary>
        /// FileLength
        /// </summary>
        /// <value>FileLength</value>
        [DataMember(Name="fileLength", EmitDefaultValue=false)]
        public long? FileLength { get; set; }


        /// <summary>
        /// CommonPortsOnly
        /// </summary>
        /// <value>CommonPortsOnly</value>
        [DataMember(Name="commonPortsOnly", EmitDefaultValue=false)]
        public bool? CommonPortsOnly { get; set; }

        /// <summary>
        /// Hosts
        /// </summary>
        /// <value>Hosts</value>
        [DataMember(Name="hosts", EmitDefaultValue=false)]
        public List<string> Hosts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostImportNetworkScanSessionRequest {\n");
            sb.Append("  FileLength: ").Append(FileLength).Append("\n");
            sb.Append("  NetworkScanType: ").Append(NetworkScanType).Append("\n");
            sb.Append("  CommonPortsOnly: ").Append(CommonPortsOnly).Append("\n");
            sb.Append("  Hosts: ").Append(Hosts).Append("\n");
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
            return this.Equals(input as PostImportNetworkScanSessionRequest);
        }

        /// <summary>
        /// Returns true if PostImportNetworkScanSessionRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostImportNetworkScanSessionRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostImportNetworkScanSessionRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FileLength == input.FileLength ||
                    (this.FileLength != null &&
                    this.FileLength.Equals(input.FileLength))
                ) && 
                (
                    this.NetworkScanType == input.NetworkScanType ||
                    (this.NetworkScanType != null &&
                    this.NetworkScanType.Equals(input.NetworkScanType))
                ) && 
                (
                    this.CommonPortsOnly == input.CommonPortsOnly ||
                    (this.CommonPortsOnly != null &&
                    this.CommonPortsOnly.Equals(input.CommonPortsOnly))
                ) && 
                (
                    this.Hosts == input.Hosts ||
                    this.Hosts != null &&
                    this.Hosts.SequenceEqual(input.Hosts)
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
                if (this.FileLength != null)
                    hashCode = hashCode * 59 + this.FileLength.GetHashCode();
                if (this.NetworkScanType != null)
                    hashCode = hashCode * 59 + this.NetworkScanType.GetHashCode();
                if (this.CommonPortsOnly != null)
                    hashCode = hashCode * 59 + this.CommonPortsOnly.GetHashCode();
                if (this.Hosts != null)
                    hashCode = hashCode * 59 + this.Hosts.GetHashCode();
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
