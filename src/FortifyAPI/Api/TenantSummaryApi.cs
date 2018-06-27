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
    public interface ITenantSummaryApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Retrieves a summary of the tenant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="daysFrom">Days back to look (optional)</param>
        /// <param name="sdlcStatus">The SDLC Status to retrieve information about (optional)</param>
        /// <returns>TenantSummaryListResponse</returns>
        TenantSummaryListResponse TenantSummaryV3GetTenantSummary (int? daysFrom = null, string sdlcStatus = null);

        /// <summary>
        /// Retrieves a summary of the tenant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="daysFrom">Days back to look (optional)</param>
        /// <param name="sdlcStatus">The SDLC Status to retrieve information about (optional)</param>
        /// <returns>ApiResponse of TenantSummaryListResponse</returns>
        ApiResponse<TenantSummaryListResponse> TenantSummaryV3GetTenantSummaryWithHttpInfo (int? daysFrom = null, string sdlcStatus = null);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Retrieves a summary of the tenant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="daysFrom">Days back to look (optional)</param>
        /// <param name="sdlcStatus">The SDLC Status to retrieve information about (optional)</param>
        /// <returns>Task of TenantSummaryListResponse</returns>
        System.Threading.Tasks.Task<TenantSummaryListResponse> TenantSummaryV3GetTenantSummaryAsync (int? daysFrom = null, string sdlcStatus = null);

        /// <summary>
        /// Retrieves a summary of the tenant
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="daysFrom">Days back to look (optional)</param>
        /// <param name="sdlcStatus">The SDLC Status to retrieve information about (optional)</param>
        /// <returns>Task of ApiResponse (TenantSummaryListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TenantSummaryListResponse>> TenantSummaryV3GetTenantSummaryAsyncWithHttpInfo (int? daysFrom = null, string sdlcStatus = null);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TenantSummaryApi : ITenantSummaryApi
    {
        private FortifyAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantSummaryApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TenantSummaryApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FortifyAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantSummaryApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TenantSummaryApi(Configuration configuration = null)
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
        /// Retrieves a summary of the tenant 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="daysFrom">Days back to look (optional)</param>
        /// <param name="sdlcStatus">The SDLC Status to retrieve information about (optional)</param>
        /// <returns>TenantSummaryListResponse</returns>
        public TenantSummaryListResponse TenantSummaryV3GetTenantSummary (int? daysFrom = null, string sdlcStatus = null)
        {
             ApiResponse<TenantSummaryListResponse> localVarResponse = TenantSummaryV3GetTenantSummaryWithHttpInfo(daysFrom, sdlcStatus);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Retrieves a summary of the tenant 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="daysFrom">Days back to look (optional)</param>
        /// <param name="sdlcStatus">The SDLC Status to retrieve information about (optional)</param>
        /// <returns>ApiResponse of TenantSummaryListResponse</returns>
        public ApiResponse< TenantSummaryListResponse > TenantSummaryV3GetTenantSummaryWithHttpInfo (int? daysFrom = null, string sdlcStatus = null)
        {

            var localVarPath = "/api/v3/tenant-summary";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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

            if (daysFrom != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "daysFrom", daysFrom)); // query parameter
            if (sdlcStatus != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sdlcStatus", sdlcStatus)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TenantSummaryV3GetTenantSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TenantSummaryListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TenantSummaryListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TenantSummaryListResponse)));
        }

        /// <summary>
        /// Retrieves a summary of the tenant 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="daysFrom">Days back to look (optional)</param>
        /// <param name="sdlcStatus">The SDLC Status to retrieve information about (optional)</param>
        /// <returns>Task of TenantSummaryListResponse</returns>
        public async System.Threading.Tasks.Task<TenantSummaryListResponse> TenantSummaryV3GetTenantSummaryAsync (int? daysFrom = null, string sdlcStatus = null)
        {
             ApiResponse<TenantSummaryListResponse> localVarResponse = await TenantSummaryV3GetTenantSummaryAsyncWithHttpInfo(daysFrom, sdlcStatus);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Retrieves a summary of the tenant 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="daysFrom">Days back to look (optional)</param>
        /// <param name="sdlcStatus">The SDLC Status to retrieve information about (optional)</param>
        /// <returns>Task of ApiResponse (TenantSummaryListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TenantSummaryListResponse>> TenantSummaryV3GetTenantSummaryAsyncWithHttpInfo (int? daysFrom = null, string sdlcStatus = null)
        {

            var localVarPath = "/api/v3/tenant-summary";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
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

            if (daysFrom != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "daysFrom", daysFrom)); // query parameter
            if (sdlcStatus != null) localVarQueryParams.AddRange(Configuration.ApiClient.ParameterToKeyValuePairs("", "sdlcStatus", sdlcStatus)); // query parameter


            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TenantSummaryV3GetTenantSummary", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TenantSummaryListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TenantSummaryListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TenantSummaryListResponse)));
        }

    }
}
