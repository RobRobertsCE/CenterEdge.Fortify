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
    /// Field Filter
    /// </summary>
    [DataContract]
    public partial class FieldFilter :  IEquatable<FieldFilter>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FieldFilter" /> class.
        /// </summary>
        /// <param name="FieldName">The field name.</param>
        /// <param name="FieldFilterValues">List of field filter values.</param>
        public FieldFilter(string FieldName = default(string), List<FieldFilterValue> FieldFilterValues = default(List<FieldFilterValue>))
        {
            this.FieldName = FieldName;
            this.FieldFilterValues = FieldFilterValues;
        }
        
        /// <summary>
        /// The field name
        /// </summary>
        /// <value>The field name</value>
        [DataMember(Name="fieldName", EmitDefaultValue=false)]
        public string FieldName { get; set; }

        /// <summary>
        /// List of field filter values
        /// </summary>
        /// <value>List of field filter values</value>
        [DataMember(Name="fieldFilterValues", EmitDefaultValue=false)]
        public List<FieldFilterValue> FieldFilterValues { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FieldFilter {\n");
            sb.Append("  FieldName: ").Append(FieldName).Append("\n");
            sb.Append("  FieldFilterValues: ").Append(FieldFilterValues).Append("\n");
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
            return this.Equals(input as FieldFilter);
        }

        /// <summary>
        /// Returns true if FieldFilter instances are equal
        /// </summary>
        /// <param name="input">Instance of FieldFilter to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FieldFilter input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.FieldName == input.FieldName ||
                    (this.FieldName != null &&
                    this.FieldName.Equals(input.FieldName))
                ) && 
                (
                    this.FieldFilterValues == input.FieldFilterValues ||
                    this.FieldFilterValues != null &&
                    this.FieldFilterValues.SequenceEqual(input.FieldFilterValues)
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
                if (this.FieldName != null)
                    hashCode = hashCode * 59 + this.FieldName.GetHashCode();
                if (this.FieldFilterValues != null)
                    hashCode = hashCode * 59 + this.FieldFilterValues.GetHashCode();
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
