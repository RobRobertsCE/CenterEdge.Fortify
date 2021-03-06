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
    /// Lookup Item
    /// </summary>
    [DataContract]
    public partial class LookupItem :  IEquatable<LookupItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LookupItem" /> class.
        /// </summary>
        /// <param name="Value">The value property.</param>
        /// <param name="Text">The text property.</param>
        /// <param name="Group">The group property.</param>
        public LookupItem(string Value = default(string), string Text = default(string), string Group = default(string))
        {
            this.Value = Value;
            this.Text = Text;
            this.Group = Group;
        }
        
        /// <summary>
        /// The value property
        /// </summary>
        /// <value>The value property</value>
        [DataMember(Name="value", EmitDefaultValue=false)]
        public string Value { get; set; }

        /// <summary>
        /// The text property
        /// </summary>
        /// <value>The text property</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public string Text { get; set; }

        /// <summary>
        /// The group property
        /// </summary>
        /// <value>The group property</value>
        [DataMember(Name="group", EmitDefaultValue=false)]
        public string Group { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LookupItem {\n");
            sb.Append("  Value: ").Append(Value).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
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
            return this.Equals(input as LookupItem);
        }

        /// <summary>
        /// Returns true if LookupItem instances are equal
        /// </summary>
        /// <param name="input">Instance of LookupItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LookupItem input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Value == input.Value ||
                    (this.Value != null &&
                    this.Value.Equals(input.Value))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
                ) && 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
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
                if (this.Value != null)
                    hashCode = hashCode * 59 + this.Value.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                if (this.Group != null)
                    hashCode = hashCode * 59 + this.Group.GetHashCode();
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
