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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using FortifyAPI.Client;
using FortifyAPI.Model;

namespace FortifyAPI.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface IMultiFactorAuthorizationCodeApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Send an Authorization code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestModel">the username, password, and authorization method</param>
        /// <returns></returns>
        void MultiFactorAuthorizationCodeV3Post (PostMultiFactorAuthorizationCodeRequest requestModel);

        /// <summary>
        /// Send an Authorization code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestModel">the username, password, and authorization method</param>
        /// <returns>ApiResponse of Object(void)</returns>
        ApiResponse<Object> MultiFactorAuthorizationCodeV3PostWithHttpInfo (PostMultiFactorAuthorizationCodeRequest requestModel);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Send an Authorization code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestModel">the username, password, and authorization method</param>
        /// <returns>Task of void</returns>
        System.Threading.Tasks.Task MultiFactorAuthorizationCodeV3PostAsync (PostMultiFactorAuthorizationCodeRequest requestModel);

        /// <summary>
        /// Send an Authorization code
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestModel">the username, password, and authorization method</param>
        /// <returns>Task of ApiResponse</returns>
        System.Threading.Tasks.Task<ApiResponse<Object>> MultiFactorAuthorizationCodeV3PostAsyncWithHttpInfo (PostMultiFactorAuthorizationCodeRequest requestModel);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class MultiFactorAuthorizationCodeApi : IMultiFactorAuthorizationCodeApi
    {
        private FortifyAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiFactorAuthorizationCodeApi"/> class.
        /// </summary>
        /// <returns></returns>
        public MultiFactorAuthorizationCodeApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FortifyAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MultiFactorAuthorizationCodeApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public MultiFactorAuthorizationCodeApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = FortifyAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public FortifyAPI.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<String, String> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Send an Authorization code 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestModel">the username, password, and authorization method</param>
        /// <returns></returns>
        public void MultiFactorAuthorizationCodeV3Post (PostMultiFactorAuthorizationCodeRequest requestModel)
        {
             MultiFactorAuthorizationCodeV3PostWithHttpInfo(requestModel);
        }

        /// <summary>
        /// Send an Authorization code 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestModel">the username, password, and authorization method</param>
        /// <returns>ApiResponse of Object(void)</returns>
        public ApiResponse<Object> MultiFactorAuthorizationCodeV3PostWithHttpInfo (PostMultiFactorAuthorizationCodeRequest requestModel)
        {
            // verify the required parameter 'requestModel' is set
            if (requestModel == null)
                throw new ApiException(400, "Missing required parameter 'requestModel' when calling MultiFactorAuthorizationCodeApi->MultiFactorAuthorizationCodeV3Post");

            var localVarPath = "/api/v3/multi-factor-authorization-code";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded", 
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (requestModel != null && requestModel.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(requestModel); // http body (model) parameter
            }
            else
            {
                localVarPostBody = requestModel; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MultiFactorAuthorizationCodeV3Post", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

        /// <summary>
        /// Send an Authorization code 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestModel">the username, password, and authorization method</param>
        /// <returns>Task of void</returns>
        public async System.Threading.Tasks.Task MultiFactorAuthorizationCodeV3PostAsync (PostMultiFactorAuthorizationCodeRequest requestModel)
        {
             await MultiFactorAuthorizationCodeV3PostAsyncWithHttpInfo(requestModel);

        }

        /// <summary>
        /// Send an Authorization code 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="requestModel">the username, password, and authorization method</param>
        /// <returns>Task of ApiResponse</returns>
        public async System.Threading.Tasks.Task<ApiResponse<Object>> MultiFactorAuthorizationCodeV3PostAsyncWithHttpInfo (PostMultiFactorAuthorizationCodeRequest requestModel)
        {
            // verify the required parameter 'requestModel' is set
            if (requestModel == null)
                throw new ApiException(400, "Missing required parameter 'requestModel' when calling MultiFactorAuthorizationCodeApi->MultiFactorAuthorizationCodeV3Post");

            var localVarPath = "/api/v3/multi-factor-authorization-code";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json", 
                "text/json", 
                "application/xml", 
                "text/xml", 
                "application/x-www-form-urlencoded", 
                "multipart/form-data"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json",
                "text/json",
                "application/xml",
                "text/xml"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (requestModel != null && requestModel.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(requestModel); // http body (model) parameter
            }
            else
            {
                localVarPostBody = requestModel; // byte array
            }


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("MultiFactorAuthorizationCodeV3Post", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Object>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                null);
        }

    }
}
