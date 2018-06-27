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
    /// Post User Request
    /// </summary>
    [DataContract]
    public partial class PostUserRequest :  IEquatable<PostUserRequest>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PostUserRequest" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PostUserRequest() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PostUserRequest" /> class.
        /// </summary>
        /// <param name="UserName">The username (required).</param>
        /// <param name="Email">The user&#39;s email address (required).</param>
        /// <param name="FirstName">The user&#39;s first name (required).</param>
        /// <param name="LastName">The user&#39;s last name (required).</param>
        /// <param name="PhoneNumber">The user&#39;s phone number.</param>
        /// <param name="RoleId">The The user&#39;s role id (required).</param>
        /// <param name="PasswordNeverExpires">Indicates if the password never expires.</param>
        /// <param name="IsSuspended">Indicates if the user&#39;s account is suspended.</param>
        public PostUserRequest(string UserName = default(string), string Email = default(string), string FirstName = default(string), string LastName = default(string), string PhoneNumber = default(string), int? RoleId = default(int?), bool? PasswordNeverExpires = default(bool?), bool? IsSuspended = default(bool?))
        {
            // to ensure "UserName" is required (not null)
            if (UserName == null)
            {
                throw new InvalidDataException("UserName is a required property for PostUserRequest and cannot be null");
            }
            else
            {
                this.UserName = UserName;
            }
            // to ensure "Email" is required (not null)
            if (Email == null)
            {
                throw new InvalidDataException("Email is a required property for PostUserRequest and cannot be null");
            }
            else
            {
                this.Email = Email;
            }
            // to ensure "FirstName" is required (not null)
            if (FirstName == null)
            {
                throw new InvalidDataException("FirstName is a required property for PostUserRequest and cannot be null");
            }
            else
            {
                this.FirstName = FirstName;
            }
            // to ensure "LastName" is required (not null)
            if (LastName == null)
            {
                throw new InvalidDataException("LastName is a required property for PostUserRequest and cannot be null");
            }
            else
            {
                this.LastName = LastName;
            }
            // to ensure "RoleId" is required (not null)
            if (RoleId == null)
            {
                throw new InvalidDataException("RoleId is a required property for PostUserRequest and cannot be null");
            }
            else
            {
                this.RoleId = RoleId;
            }
            this.PhoneNumber = PhoneNumber;
            this.PasswordNeverExpires = PasswordNeverExpires;
            this.IsSuspended = IsSuspended;
        }
        
        /// <summary>
        /// The username
        /// </summary>
        /// <value>The username</value>
        [DataMember(Name="userName", EmitDefaultValue=false)]
        public string UserName { get; set; }

        /// <summary>
        /// The user&#39;s email address
        /// </summary>
        /// <value>The user&#39;s email address</value>
        [DataMember(Name="email", EmitDefaultValue=false)]
        public string Email { get; set; }

        /// <summary>
        /// The user&#39;s first name
        /// </summary>
        /// <value>The user&#39;s first name</value>
        [DataMember(Name="firstName", EmitDefaultValue=false)]
        public string FirstName { get; set; }

        /// <summary>
        /// The user&#39;s last name
        /// </summary>
        /// <value>The user&#39;s last name</value>
        [DataMember(Name="lastName", EmitDefaultValue=false)]
        public string LastName { get; set; }

        /// <summary>
        /// The user&#39;s phone number
        /// </summary>
        /// <value>The user&#39;s phone number</value>
        [DataMember(Name="phoneNumber", EmitDefaultValue=false)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The The user&#39;s role id
        /// </summary>
        /// <value>The The user&#39;s role id</value>
        [DataMember(Name="roleId", EmitDefaultValue=false)]
        public int? RoleId { get; set; }

        /// <summary>
        /// Indicates if the password never expires
        /// </summary>
        /// <value>Indicates if the password never expires</value>
        [DataMember(Name="passwordNeverExpires", EmitDefaultValue=false)]
        public bool? PasswordNeverExpires { get; set; }

        /// <summary>
        /// Indicates if the user&#39;s account is suspended
        /// </summary>
        /// <value>Indicates if the user&#39;s account is suspended</value>
        [DataMember(Name="isSuspended", EmitDefaultValue=false)]
        public bool? IsSuspended { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class PostUserRequest {\n");
            sb.Append("  UserName: ").Append(UserName).Append("\n");
            sb.Append("  Email: ").Append(Email).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  RoleId: ").Append(RoleId).Append("\n");
            sb.Append("  PasswordNeverExpires: ").Append(PasswordNeverExpires).Append("\n");
            sb.Append("  IsSuspended: ").Append(IsSuspended).Append("\n");
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
            return this.Equals(input as PostUserRequest);
        }

        /// <summary>
        /// Returns true if PostUserRequest instances are equal
        /// </summary>
        /// <param name="input">Instance of PostUserRequest to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PostUserRequest input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.UserName == input.UserName ||
                    (this.UserName != null &&
                    this.UserName.Equals(input.UserName))
                ) && 
                (
                    this.Email == input.Email ||
                    (this.Email != null &&
                    this.Email.Equals(input.Email))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.RoleId == input.RoleId ||
                    (this.RoleId != null &&
                    this.RoleId.Equals(input.RoleId))
                ) && 
                (
                    this.PasswordNeverExpires == input.PasswordNeverExpires ||
                    (this.PasswordNeverExpires != null &&
                    this.PasswordNeverExpires.Equals(input.PasswordNeverExpires))
                ) && 
                (
                    this.IsSuspended == input.IsSuspended ||
                    (this.IsSuspended != null &&
                    this.IsSuspended.Equals(input.IsSuspended))
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
                if (this.UserName != null)
                    hashCode = hashCode * 59 + this.UserName.GetHashCode();
                if (this.Email != null)
                    hashCode = hashCode * 59 + this.Email.GetHashCode();
                if (this.FirstName != null)
                    hashCode = hashCode * 59 + this.FirstName.GetHashCode();
                if (this.LastName != null)
                    hashCode = hashCode * 59 + this.LastName.GetHashCode();
                if (this.PhoneNumber != null)
                    hashCode = hashCode * 59 + this.PhoneNumber.GetHashCode();
                if (this.RoleId != null)
                    hashCode = hashCode * 59 + this.RoleId.GetHashCode();
                if (this.PasswordNeverExpires != null)
                    hashCode = hashCode * 59 + this.PasswordNeverExpires.GetHashCode();
                if (this.IsSuspended != null)
                    hashCode = hashCode * 59 + this.IsSuspended.GetHashCode();
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
