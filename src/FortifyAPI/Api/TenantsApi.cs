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
    public interface ITenantsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get tenant features
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TenantFeatureListResponse</returns>
        TenantFeatureListResponse TenantsV3GetFeatures ();

        /// <summary>
        /// Get tenant features
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TenantFeatureListResponse</returns>
        ApiResponse<TenantFeatureListResponse> TenantsV3GetFeaturesWithHttpInfo ();
        /// <summary>
        /// Get tenant data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetTenantResponse</returns>
        GetTenantResponse TenantsV3GetTenant ();

        /// <summary>
        /// Get tenant data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetTenantResponse</returns>
        ApiResponse<GetTenantResponse> TenantsV3GetTenantWithHttpInfo ();
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get tenant features
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TenantFeatureListResponse</returns>
        System.Threading.Tasks.Task<TenantFeatureListResponse> TenantsV3GetFeaturesAsync ();

        /// <summary>
        /// Get tenant features
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TenantFeatureListResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<TenantFeatureListResponse>> TenantsV3GetFeaturesAsyncWithHttpInfo ();
        /// <summary>
        /// Get tenant data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GetTenantResponse</returns>
        System.Threading.Tasks.Task<GetTenantResponse> TenantsV3GetTenantAsync ();

        /// <summary>
        /// Get tenant data
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GetTenantResponse)</returns>
        System.Threading.Tasks.Task<ApiResponse<GetTenantResponse>> TenantsV3GetTenantAsyncWithHttpInfo ();
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class TenantsApi : ITenantsApi
    {
        private FortifyAPI.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public TenantsApi(String basePath)
        {
            this.Configuration = new Configuration { BasePath = basePath };

            ExceptionFactory = FortifyAPI.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TenantsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public TenantsApi(Configuration configuration = null)
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
        /// Get tenant features 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>TenantFeatureListResponse</returns>
        public TenantFeatureListResponse TenantsV3GetFeatures ()
        {
             ApiResponse<TenantFeatureListResponse> localVarResponse = TenantsV3GetFeaturesWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get tenant features 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of TenantFeatureListResponse</returns>
        public ApiResponse< TenantFeatureListResponse > TenantsV3GetFeaturesWithHttpInfo ()
        {

            var localVarPath = "/api/v3/tenants/features";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TenantsV3GetFeatures", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TenantFeatureListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TenantFeatureListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TenantFeatureListResponse)));
        }

        /// <summary>
        /// Get tenant features 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of TenantFeatureListResponse</returns>
        public async System.Threading.Tasks.Task<TenantFeatureListResponse> TenantsV3GetFeaturesAsync ()
        {
             ApiResponse<TenantFeatureListResponse> localVarResponse = await TenantsV3GetFeaturesAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get tenant features 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (TenantFeatureListResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<TenantFeatureListResponse>> TenantsV3GetFeaturesAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v3/tenants/features";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TenantsV3GetFeatures", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<TenantFeatureListResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (TenantFeatureListResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(TenantFeatureListResponse)));
        }

        /// <summary>
        /// Get tenant data 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>GetTenantResponse</returns>
        public GetTenantResponse TenantsV3GetTenant ()
        {
             ApiResponse<GetTenantResponse> localVarResponse = TenantsV3GetTenantWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get tenant data 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of GetTenantResponse</returns>
        public ApiResponse< GetTenantResponse > TenantsV3GetTenantWithHttpInfo ()
        {

            var localVarPath = "/api/v3/tenants";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TenantsV3GetTenant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetTenantResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetTenantResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetTenantResponse)));
        }

        /// <summary>
        /// Get tenant data 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of GetTenantResponse</returns>
        public async System.Threading.Tasks.Task<GetTenantResponse> TenantsV3GetTenantAsync ()
        {
             ApiResponse<GetTenantResponse> localVarResponse = await TenantsV3GetTenantAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get tenant data 
        /// </summary>
        /// <exception cref="FortifyAPI.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (GetTenantResponse)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<GetTenantResponse>> TenantsV3GetTenantAsyncWithHttpInfo ()
        {

            var localVarPath = "/api/v3/tenants";
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



            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("TenantsV3GetTenant", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<GetTenantResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (GetTenantResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(GetTenantResponse)));
        }

    }
}
