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
    /// Generic List Response
    /// </summary>
    [DataContract]
    public partial class UserApplicationAccessListResponse :  IEquatable<UserApplicationAccessListResponse>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UserApplicationAccessListResponse" /> class.
        /// </summary>
        /// <param name="Items">The list of items.</param>
        /// <param name="TotalCount">Total count of items.</param>
        public UserApplicationAccessListResponse(List<UserApplicationAccess> Items = default(List<UserApplicationAccess>), int? TotalCount = default(int?))
        {
            this.Items = Items;
            this.TotalCount = TotalCount;
        }
        
        /// <summary>
        /// The list of items
        /// </summary>
        /// <value>The list of items</value>
        [DataMember(Name="items", EmitDefaultValue=false)]
        public List<UserApplicationAccess> Items { get; set; }

        /// <summary>
        /// Total count of items
        /// </summary>
        /// <value>Total count of items</value>
        [DataMember(Name="totalCount", EmitDefaultValue=false)]
        public int? TotalCount { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class UserApplicationAccessListResponse {\n");
            sb.Append("  Items: ").Append(Items).Append("\n");
            sb.Append("  TotalCount: ").Append(TotalCount).Append("\n");
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
            return this.Equals(input as UserApplicationAccessListResponse);
        }

        /// <summary>
        /// Returns true if UserApplicationAccessListResponse instances are equal
        /// </summary>
        /// <param name="input">Instance of UserApplicationAccessListResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserApplicationAccessListResponse input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Items == input.Items ||
                    this.Items != null &&
                    this.Items.SequenceEqual(input.Items)
                ) && 
                (
                    this.TotalCount == input.TotalCount ||
                    (this.TotalCount != null &&
                    this.TotalCount.Equals(input.TotalCount))
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
                if (this.Items != null)
                    hashCode = hashCode * 59 + this.Items.GetHashCode();
                if (this.TotalCount != null)
                    hashCode = hashCode * 59 + this.TotalCount.GetHashCode();
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